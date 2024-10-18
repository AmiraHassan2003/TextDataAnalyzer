using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalyzer
{
    public static class FileInfoExtension
    {
        public static bool isTextFile( this FileInfo fileInfo ) 
        {
            if(fileInfo.Extension == ".txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isCsvFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
