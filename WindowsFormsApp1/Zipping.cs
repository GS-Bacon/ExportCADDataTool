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
        public void MakeZipFile(string FilePath,string ZipFolderPath) //FilePath:エクスポートするファイルリスト ZipFolderPath:Zipファイルを出力するフォルダーパス
        {
            string[] FileNameList= new string[FilePath.Length];

            for(var i=0;i<FilePath.Length;i++)
            {
                FileNameList[i] = Path.GetFileNameWithoutExtension(@FilePath[i]);
            }
            string[] NameList = FileNameList.Distinct().ToArray();

            for (var i = 0; i < FilePath.Length; i++)
            {
                Debug.Print((string)FilePath[i]);
            }

            for (var i = 0; i < NameList.Length; i++)
            {
                using (ZipArchive ZipCADFile = ZipFile.Open(ZipFolderPath + "\\" + NameList[i] + ".zip", ZipArchiveMode.Update))
                {
                    for (var j = 0; j < FilePath.Length; j++)
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