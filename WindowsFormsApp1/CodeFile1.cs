using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidworksAPIControl;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Linq;
using System.IO.Compression;

namespace WindowsFormsApp1
{
    public class Zipping
    {
        public void BandFileName(string[] FilePath,string ZipFolderPath)
        {
            string[] FileNameList= new string[FilePath.Length];

            for(var i=0;i<FilePath.Length;i++)
            {
                FileNameList[i] = Path.GetFileNameWithoutExtension(@FilePath[i]);
            }
            FileNameList.Distinct();

            for (var i = 0; i < FileNameList.Length; i++)
            {
            }
        }
    }
}