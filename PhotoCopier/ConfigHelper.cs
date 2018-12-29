using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCopier
{
    static public class ConfigHelper
    {
        private static string _sourcePath;
        private static string _destPath;
        private static string _dngConverterFilePath;
        private static string _tempPath;

        public static string SourcePath
        {
            get
            {
                return _sourcePath;
            }
        }

        public static string DestPath
        {
            get
            {
                return _destPath;
            }
        }

        public static string DngConverterFilePath
        {
            get
            {
                return _dngConverterFilePath;
            }
        }

        public static string TempPath
        {
            get
            {
                return _tempPath;
            }
        }

        static public void InitializeConfig()
        {
            _sourcePath = System.Configuration.ConfigurationManager.AppSettings["SourcePath"];
            _destPath = System.Configuration.ConfigurationManager.AppSettings["DestPath"];
            _dngConverterFilePath = System.Configuration.ConfigurationManager.AppSettings["AdobeDngConvertFilePath"];
            _tempPath = System.Configuration.ConfigurationManager.AppSettings["TempPath"];
        }
    }
}
