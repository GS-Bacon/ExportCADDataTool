﻿using System.IO;
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
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Zipping
    {
        public void MakeZipFile(List<string> FilePath,string ZipFolderPath)
        {
            string[] FileNameList= new string[FilePath.Count];

            for(var i=0;i<FilePath.Count;i++)
            {
                FileNameList[i] = Path.GetFileNameWithoutExtension(@FilePath[i]);
            }
            string[] NameList = FileNameList.Distinct().ToArray();

            for (var i = 0; i < NameList.Length; i++)
            {
                Debug.Print((string)NameList[i]);
            }

            for (var i = 0; i < NameList.Length; i++)
            {
                using (ZipArchive ZipCADFile = ZipFile.Open(ZipFolderPath + "\\" + NameList[i] + ".zip", ZipArchiveMode.Update))
                {
                    for (var j = 0; j < FilePath.Count; j++)
                    {
                        if (NameList[i] == Path.GetFileNameWithoutExtension(@FilePath[j]))
                        {
                            ZipCADFile.CreateEntryFromFile(@FilePath[j], (string)Path.GetFileName(FilePath[j]), CompressionLevel.Optimal);
                        }
                    }
                }
            }
        }
    }
}