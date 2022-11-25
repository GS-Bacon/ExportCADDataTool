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
                savepath = MakeExportExtensionFolder(exportpath, CheckExportExtension());
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
    }
}


