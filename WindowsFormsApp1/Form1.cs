using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using SolidworksAPIControl;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SldWorks swapp = new SldWorks();
        SolidworksAPIControl.FileExport SolidworksFileExport = new SolidworksAPIControl.FileExport();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "CADデータファイル|*.SLDDRW;*.SLDPRT|すべてのファイル|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (string strFilePath in openFileDialog1.FileNames)
                {
                    // ファイルパスからファイル名を取得
                    string strFileName = System.IO.Path.GetFullPath(strFilePath);

                    // リストボックスにファイル名を表示
                    listBox1.Items.Add(strFileName);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExportDocDataType_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FileSelect_Enter(object sender, EventArgs e)
        {

        }

        private void NoMoveExportfile_CheckedChanged(object sender, EventArgs e)
        {
            if (NoMoveExportfile.Checked == true)
            {
                MoveExportFile.Checked = false;
                ExportFolder.Enabled = false;
                ExportFolderBotton.Enabled = false;
            }
            else
            {
                MoveExportFile.Checked = false;
                ExportFolder.Enabled = true;
                ExportFolderBotton.Enabled = true;
            }
        }

        private void MoveExportfile_CheckedChanged(object sender, EventArgs e)
        {
            if (MoveExportFile.Checked == true)
            {
                NoMoveExportfile.Checked = false;
                MoveExportFile.Checked = true;
            }

        }

        private void ExportFolderBotton_Click(object sender, EventArgs e)
        {
            var OpenFileDialog = new CommonOpenFileDialog();
            OpenFileDialog.IsFolderPicker = true;
            if (OpenFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            ExportFolder.Items.Add(OpenFileDialog.FileName);
        }

        private void ExportFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void MakeZipFileFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MakeZipFileBotton_Click(object sender, EventArgs e)
        {
            var zipfile = new CommonOpenFileDialog();
            zipfile.IsFolderPicker = true;
            if (zipfile.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            MakeZipFileFolder.Items.Add(zipfile.FileName);
        }

        private void CancelBotton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void GoBotton_Click(object sender, EventArgs e)
        {
            string[] savepath = new string[5];
            string exportpath;
            //StartSldworks();
            if (NoMoveExportfile.Checked == true)
            {
                exportpath = Path.GetDirectoryName((string)listBox1.Items[0]);
            }
            else
            {
                exportpath = (string)ExportFolder.Items[0];
            }
            if (ExportExtensionFolder.Checked == true)
            {
                savepath = MakeExportExtensionFolder(exportpath,CheckExportExtension());
            }
            else
            {
                for (var i = 0; i < savepath.Length; i++)
                {
                    savepath[i] = exportpath;
                }
            }
            //GoBotton.Enabled = false;
            ExportFiles(savepath);

            TaskCompleteDialog();

        }

        private void CheckDxf_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string[] ExportFiles(string[] exportFolderPath)
        {
            progressBar1.Maximum = listBox1.Items.Count;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            string[] AllExportPaht=null;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string filepath = (string)listBox1.Items[i];
                string fileExtension = Path.GetExtension(filepath);

                switch (fileExtension)
                {
                    case ".SLDDRW":
                        if (CheckPdf.Checked == true)
                        {
                            AllExportPaht[i]= SolidworksFileExport.ExportPdf(filepath, (string)exportFolderPath[0]);
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
            {   if (exportoption[i] == true)
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

        private void ExportFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                listBox1.Items.Add(item);
            }
        }
        private void TaskCompleteDialog()
        {
            DialogResult result = MessageBox.Show("変換作業を続行しますか？", "変換完了", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.Yes)
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

