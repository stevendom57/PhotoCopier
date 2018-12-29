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

            // copy all files to thge temp directory
            foreach(string filePath in filePathList)
            {
                var fileName = Path.GetFileName(filePath);

                // make the dest path
                var fileDestPath = ConfigHelper.TempPath + fileName;

                // copy the files and keep the original time date
                FileHelper.CopyFileExactly(filePath, fileDestPath);


            }

            // convert raw files to dng format
            DngConverter converter = new DngConverter();
            converter.ConvertFiles(ConfigHelper.TempPath);


        }
    }
}
