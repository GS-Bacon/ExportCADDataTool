using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidworksAPIControl;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Collections.Generic;

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
        public  List<string> ExportFiles(string[] exportFolderPath, string[] fileList, bool[] checkExtension)
        {

            List<string> AllExportPaht=new List<string>();
            for (int i = 0; i < fileList.Length; i++)
            {
                string filepath = fileList[i];
                string fileExtension = Path.GetExtension(filepath);
                string test;


                switch (fileExtension)
                {
                    case ".SLDDRW":
                        if (checkExtension[0] == true)
                        {
                            AllExportPaht.Add(solidworksFieExport.ExportPdf(filepath, (string)exportFolderPath[0]));
                        }
                        if (checkExtension[1] == true)
                        {
                            AllExportPaht.Add(solidworksFieExport.ExportDxf(filepath, (string)exportFolderPath[1]));
                        }

                        break;
                    case ".SLDPRT":
                        if (checkExtension[2] == true)
                        {
                            AllExportPaht.Add(solidworksFieExport.ExportIges(filepath, (string)exportFolderPath[2]));
                        }
                        if (checkExtension[3] == true)
                        {
                            AllExportPaht.Add(solidworksFieExport.ExportStep(filepath, (string)exportFolderPath[3]));
                        }
                        if (checkExtension[4] == true)
                        {
                            AllExportPaht.Add(solidworksFieExport.ExportStl(filepath, (string)exportFolderPath[4]));
                        }
                        break;

                }
            }
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