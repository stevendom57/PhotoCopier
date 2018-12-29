using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCopier
{
    public static class FileHelper
    {
        public static void CopyFileExactly(string copyFromPath, string copyToPath)
        {
            if (File.Exists(copyToPath))
            {
                var target = new FileInfo(copyToPath);
                if (target.IsReadOnly)
                    target.IsReadOnly = false;
            }

            var origin = new FileInfo(copyFromPath);
            origin.CopyTo(copyToPath, true);

            var destination = new FileInfo(copyToPath);
            if (destination.IsReadOnly)
            {
                destination.IsReadOnly = false;
                destination.CreationTime = origin.CreationTime;
                destination.LastWriteTime = origin.LastWriteTime;
                destination.LastAccessTime = origin.LastAccessTime;
                destination.IsReadOnly = true;
            }
            else
            {
                destination.CreationTime = origin.CreationTime;
                destination.LastWriteTime = origin.LastWriteTime;
                destination.LastAccessTime = origin.LastAccessTime;
            }
        }

        public static void SetDngTimestamp(string filePath)
        {
            var origin = new FileInfo(filePath);

            string dngFilePath = filePath.ToLower().Replace(".cr3", ".dng");
            var dngFile = new FileInfo(dngFilePath);
            dngFile.CreationTime = origin.CreationTime;
            dngFile.LastWriteTime = origin.LastWriteTime;
            dngFile.LastAccessTime = origin.LastAccessTime;
        }
    }
}
