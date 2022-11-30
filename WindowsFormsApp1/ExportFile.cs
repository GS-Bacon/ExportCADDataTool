using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidworksAPIControl;
using WindowsFormsApp1;

namespace FileExport
{

    public partial class Filexeport
    {
        SldWorks swapp = new SldWorks();
        public Form1 form;
        SolidworksAPIControl.FileExport SolidworksFileExport = new SolidworksAPIControl.FileExport();

        private string[] ExportFiles(string[] exportFolderPath, string[] fileList)
        {
            form.progressBar1.Maximum = form.listBox1.Items.Count;
            form.progressBar1.Minimum = 0;
            form.progressBar1.Value = 0;
            string[] AllExportPaht = null;
            for (int i = 0; i < fileList.Length; i++)
            {
                string filepath = fileList[i];
                string fileExtension = Path.GetExtension(filepath);

                switch (fileExtension)
                {
                    case ".SLDDRW":
                        if (form.CheckPdf.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportPdf(filepath, (string)exportFolderPath[0]);
                        }
                        if (form.CheckDxf.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportDxf(filepath, (string)exportFolderPath[1]);
                        }

                        break;
                    case ".SLDPRT":
                        if (form.CheckIges.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportIges(filepath, (string)exportFolderPath[2]);
                        }
                        if (form.CheckStep.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportStep(filepath, (string)exportFolderPath[3]);
                        }
                        if (form.CheckStl.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportStl(filepath, (string)exportFolderPath[4]);
                        }
                        break;

                }
                form.progressBar1.Value = i + 1;
            }
            return AllExportPaht;

        }
        private string[] MakeExportExtensionFolder(string exportpath, bool[] exportoption)
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

        private void TaskCompleteDialog()
        {
            DialogResult result = MessageBox.Show("変換作業を続行しますか？", "変換完了", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                form.progressBar1.Value = 0;
                form.listBox1.Items.Clear();
                form.ExportFolder.Items.Clear();
            }
            if (result == DialogResult.No)
            {
                form.Close();
            }
        }
        private bool[] CheckExportExtension()
        {
            bool[] Exportoption = new bool[5];

            Exportoption[0] = form.CheckPdf.Checked;
            Exportoption[1] = form.CheckDxf.Checked;
            Exportoption[2] = form.CheckIges.Checked;
            Exportoption[3] = form.CheckStep.Checked;
            Exportoption[4] = form.CheckStl.Checked;

            return Exportoption;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}