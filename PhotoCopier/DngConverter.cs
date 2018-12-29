using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoCopier
{
    class DngConverter
    {
        System.Windows.Forms.ListBox _loggingListBox;

        public DngConverter(System.Windows.Forms.ListBox loggingListBox)
        {
            _loggingListBox = loggingListBox;
        }
        // todo spd add logging to listbox

        public bool ConvertFiles(string path)
        {

            var filePathList = Directory.GetFiles(ConfigHelper.TempPath);

            // loop through all files, processing the cr3 files
            int successCount = 0;
            foreach (string filePath in filePathList)
            {
                var ext = Path.GetExtension(filePath);
                if (ext.ToLower() != ".cr3")
                {
                    continue;
                }

                string dngFilePath = filePath.ToLower().Replace(".cr3", ".dng");
                if (File.Exists(dngFilePath))
                {
                    // do not reconvert
                    MessageBox.Show("File " + dngFilePath + " already exists. Not converting");
                    continue;
                }

                // this is a cr3, convert it
                bool success = ConvertSingleFile(filePath);
                if (success == false)
                {
                    _loggingListBox.Items.Add("*** Error - Could not convert " + Path.GetFileName(filePath));
                    return false;
                }

                // set dng timestamp to cr3 timestamp
                FileHelper.SetDngTimestamp(filePath);

                successCount++;
                _loggingListBox.Items.Add("Converted " + Path.GetFileName(filePath));
            }

            _loggingListBox.Items.Add("--- Finished converting " + successCount + " files ---");
            return true;
 
        }

        private bool ConvertSingleFile(string filePath)
        {
            // uses adobe dng converter to convert cr3 into dng files
            //Set a time-out value.
            int timeOut = 5000;

            //Get path to system folder.
            string sysFolder = Environment.GetFolderPath(Environment.SpecialFolder.System);

            //Create a new process info structure.
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = ConfigHelper.DngConverterFilePath;
            pInfo.Arguments = "-c " + filePath;
            pInfo.CreateNoWindow = true;
            pInfo.UseShellExecute = true;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (Process exeProcess = Process.Start(pInfo))
                {
                    exeProcess.WaitForExit(timeOut);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
