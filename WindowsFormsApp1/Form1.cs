using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FileExeport fileExeport =new FileExeport();

       public void Form1_Load(object sender, EventArgs e)
       {
           FileExeport MyClassObj = new FileExeport();
           MyClassObj.Form1Obj= this;
       }

        public Form1()
        {
            InitializeComponent();
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
            string[] SavePath = new string[5];
            string ExportPath;
            string[] Filelist= new string[1];
            string[] ExportFilelist= new string[1];
            bool[] Exportoption = new bool[5];

            Exportoption[0] = CheckPdf.Checked;
            Exportoption[1] = CheckDxf.Checked;
            Exportoption[2] = CheckIges.Checked;
            Exportoption[3] = CheckStep.Checked;
            Exportoption[4] = CheckStl.Checked;

            //StartSldworks();
            if (NoMoveExportfile.Checked == true)
            {
                ExportPath = Path.GetDirectoryName((string)listBox1.Items[0]);
            }
            else
            {
                ExportPath = (string)ExportFolder.Items[0];
            }
            if (ExportExtensionFolder.Checked == true)
            {
                SavePath =  FileExeport.MakeExportExtensionFolder(ExportPath, Exportoption);
            }
            else
            {
                for (var i = 0; i < SavePath.Length; i++)
                {
                    SavePath[i] = ExportPath;
                }
            }
            Array.Resize(ref Filelist, listBox1.Items.Count);

            for (var i = 0;i<listBox1.Items.Count;i++)
            {
                Filelist[i]=(string)listBox1.Items[i];
            }


            ExportFilelist=fileExeport.ExportFiles(SavePath, Filelist,Exportoption);
            TaskCompleteDialog();

        }

        public void CheckDxf_CheckedChanged(object sender, EventArgs e)
        {

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

        public void CheckPdf_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void TaskCompleteDialog()
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
                Close();
            }
        }
    }
}


