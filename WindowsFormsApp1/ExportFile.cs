using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] ExportFiles(string[] exportFolderPath)
        {
            progressBar1.Maximum = listBox1.Items.Count;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            string[] AllExportPaht = null;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string filepath = (string)listBox1.Items[i];
                string fileExtension = Path.GetExtension(filepath);

                switch (fileExtension)
                {
                    case ".SLDDRW":
                        if (CheckPdf.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportPdf(filepath, (string)exportFolderPath[0]);
                        }
                        if (CheckDxf.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportDxf(filepath, (string)exportFolderPath[1]);
                        }

                        break;
                    case ".SLDPRT":
                        if (CheckIges.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportIges(filepath, (string)exportFolderPath[2]);
                        }
                        if (CheckStep.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportStep(filepath, (string)exportFolderPath[3]);
                        }
                        if (CheckStl.Checked == true)
                        {
                            AllExportPaht[i] = SolidworksFileExport.ExportStl(filepath, (string)exportFolderPath[4]);
                        }
                        break;

                }
                progressBar1.Value = i + 1;
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
                progressBar1.Value = 0;
                listBox1.Items.Clear();
                ExportFolder.Items.Clear();
            }
            if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        private bool[] CheckExportExtension()
        {
            bool[] Exportoption = new bool[5];

            Exportoption[0] = CheckPdf.Checked;
            Exportoption[1] = CheckDxf.Checked;
            Exportoption[2] = CheckIges.Checked;
            Exportoption[3] = CheckStep.Checked;
            Exportoption[4] = CheckStl.Checked;

            return Exportoption;
        }
    }
}