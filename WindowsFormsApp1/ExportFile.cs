using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidworksAPIControl;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace WindowsFormsApp1
{

    public class FileExeport
    {
        SolidworksFileExeport solidworksFieExport = new SolidworksFileExeport();
        public Form1 Form1Obj { get; set; }
        public void MyClass(Form1 Form1_Obj)
        {
            Form1Obj = Form1_Obj;
        }
        public  string[] ExportFiles(string[] exportFolderPath, string[] fileList, bool[] checkExtension)
        {

            string[] AllExportPaht=new string[1];
            for (int i = 0; i < fileList.Length; i++)
            {
                string filepath = fileList[i];
                string fileExtension = Path.GetExtension(filepath);


                switch (fileExtension)
                {
                    case ".SLDDRW":
                        if (checkExtension[0] == true)
                        {
                            AllExportPaht[AllExportPaht.Length - 1] = solidworksFieExport.ExportPdf(filepath, (string)exportFolderPath[0]);
                            Array.Resize(ref AllExportPaht, AllExportPaht.Length + 1);
                          
                        }
                        if (checkExtension[1] == true)
                        {
                            AllExportPaht[AllExportPaht.Length - 1] = solidworksFieExport.ExportDxf(filepath, (string)exportFolderPath[1]);
                            Array.Resize(ref AllExportPaht, AllExportPaht.Length + 1);
                        }

                        break;
                    case ".SLDPRT":
                        if (checkExtension[2] == true)
                        {
                            AllExportPaht[AllExportPaht.Length - 1] = solidworksFieExport.ExportIges(filepath, (string)exportFolderPath[2]);
                            Array.Resize(ref AllExportPaht, AllExportPaht.Length + 1);

                        }
                        if (checkExtension[3] == true)
                        {

                            AllExportPaht[AllExportPaht.Length - 1] = solidworksFieExport.ExportStep(filepath, (string)exportFolderPath[3]);
                            Array.Resize(ref AllExportPaht, AllExportPaht.Length + 1);                        
                        }
                        if (checkExtension[4] == true)
                        {
                            AllExportPaht[AllExportPaht.Length - 1] = solidworksFieExport.ExportStl(filepath, (string)exportFolderPath[4]);
                            Array.Resize(ref AllExportPaht, AllExportPaht.Length + 1);
                        }
                        break;

                }
            }
            Array.Resize(ref AllExportPaht, AllExportPaht.Length -1);
            return AllExportPaht;

        }
        public static string[] MakeExportExtensionFolder(string exportpath, bool[] exportoption)
        {
            string[] exportfolder = new string[5];
            string[] exporextension = new string[5] { "pdf", "dxf", "igs", "step", "stl" };
            for (int i = 0; i < exporextension.Length; i++)
            {
                if (exportoption[i] == true)
                {
                    if (Directory.GetDirectories(exportpath, "*" + exporextension[i] + "*").Length == 0)
                    {
                        Directory.CreateDirectory(exportpath + "\\" + exporextension[i]);
                        exportfolder[i] = (string)Directory.GetDirectories(exportpath, "*" + exporextension[i] + "*")[0];
                    }
                    else
                    {
                        exportfolder[i] = (string)Directory.GetDirectories(exportpath, "*" + exporextension[i] + "*")[0];
                    }
                }
            }
            return exportfolder;

        }


    }
}