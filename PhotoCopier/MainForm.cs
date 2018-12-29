using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoCopier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ConfigHelper.InitializeConfig();

            InitializeDisplay();
        }

        private void InitializeDisplay()
        {
            txtSource.Text = ConfigHelper.SourcePath;
            txtDest.Text = ConfigHelper.DestPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // get the list of files (flat structure) in the source directory
            var filePathList = Directory.GetFiles(txtSource.Text);

            // copy all files to the temp directory
            int successCount = 0;
            foreach(string filePath in filePathList)
            {
                var fileName = Path.GetFileName(filePath);

                // make the dest path
                var fileDestPath = ConfigHelper.TempPath + fileName;

                // copy the files and keep the original time date
                FileHelper.CopyFileExactly(filePath, fileDestPath);

                successCount++;
                lbOutput.Items.Add("Copied " + fileName);
            }

            lbOutput.Items.Add("--- Finished copying " + successCount + " files ---");

            // convert raw files to dng format
            DngConverter converter = new DngConverter(lbOutput);
            bool success = converter.ConvertFiles(ConfigHelper.TempPath);
            if (success != true)
            {
                MessageBox.Show("Something went wrong in the DNG converter. Aborting.");
                return;
            }

            // ok, all files are in the temp dir and ready to be copied to the final location
            success = CopyFilesToFinalLocation();


        }

        private bool CopyFilesToFinalLocation()
        {
            bool retval = true;

            var filePathList = Directory.GetFiles(ConfigHelper.TempPath);
            var destPath = ConfigHelper.DestPath;

            int successCount = 0;
            foreach (string filePath in filePathList)
            {
                var fileInfo = new FileInfo(filePath);

                DateTime fileCreateDate = fileInfo.CreationTime;

                string year = fileCreateDate.Year.ToString();
                string yearPath = Path.Combine(destPath, year);
                string datePath = Path.Combine(yearPath, fileCreateDate.ToString("yyyy-MM-dd"));

                // create the yyyy dir
                if (!Directory.Exists(yearPath))
                {
                    Directory.CreateDirectory(yearPath);
                }

                // create the yyyy/yyyy-mm-dd dir
                if (!Directory.Exists(datePath))
                {
                    Directory.CreateDirectory(datePath);
                }

                // now copy the file here
                try
                {
                    FileHelper.CopyFileExactly(filePath, Path.Combine(datePath, Path.GetFileName(filePath)));
                }
                catch(Exception ex)
                {
                    lbOutput.Items.Add("Could not copy " + filePath);
                    continue;
                }

                // now delete the file from the temp dir
                File.Delete(filePath);

                successCount++;
                lbOutput.Items.Add("Successfully moved file " + filePath + " to final location");
            }

            lbOutput.Items.Add("Copied " + successCount + " files to final location");

            return retval;
        }
    }
}
