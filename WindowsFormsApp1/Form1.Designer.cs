namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GetFilePathBotton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CheckDxf = new System.Windows.Forms.CheckBox();
            this.CheckStep = new System.Windows.Forms.CheckBox();
            this.CheckIges = new System.Windows.Forms.CheckBox();
            this.CheckStl = new System.Windows.Forms.CheckBox();
            this.CheckPdf = new System.Windows.Forms.CheckBox();
            this.NoMoveExportfile = new System.Windows.Forms.CheckBox();
            this.ExportModeDataType = new System.Windows.Forms.GroupBox();
            this.ExportDocDataType = new System.Windows.Forms.GroupBox();
            this.ExportOptions = new System.Windows.Forms.GroupBox();
            this.ExportFolderBotton = new System.Windows.Forms.Button();
            this.MoveExportFile = new System.Windows.Forms.CheckBox();
            this.ExportFolder = new System.Windows.Forms.ListBox();
            this.ExportExtensionFolder = new System.Windows.Forms.CheckBox();
            this.CancelBotton = new System.Windows.Forms.Button();
            this.GoBotton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MakeZipFileBotton = new System.Windows.Forms.Button();
            this.MakeZipFileFolder = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FileSelect = new System.Windows.Forms.GroupBox();
            this.ExportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExportModeDataType.SuspendLayout();
            this.ExportDocDataType.SuspendLayout();
            this.ExportOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.FileSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetFilePathBotton
            // 
            this.GetFilePathBotton.Location = new System.Drawing.Point(156, 18);
            this.GetFilePathBotton.Name = "GetFilePathBotton";
            this.GetFilePathBotton.Size = new System.Drawing.Size(75, 23);
            this.GetFilePathBotton.TabIndex = 0;
            this.GetFilePathBotton.Text = "参照";
            this.GetFilePathBotton.UseVisualStyleBackColor = true;
            this.GetFilePathBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 352);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // CheckDxf
            // 
            this.CheckDxf.AutoSize = true;
            this.CheckDxf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckDxf.Location = new System.Drawing.Point(52, 18);
            this.CheckDxf.Name = "CheckDxf";
            this.CheckDxf.Size = new System.Drawing.Size(40, 16);
            this.CheckDxf.TabIndex = 4;
            this.CheckDxf.Text = "dxf";
            this.CheckDxf.UseVisualStyleBackColor = true;
            this.CheckDxf.CheckedChanged += new System.EventHandler(this.CheckDxf_CheckedChanged);
            // 
            // CheckStep
            // 
            this.CheckStep.AutoSize = true;
            this.CheckStep.Location = new System.Drawing.Point(6, 18);
            this.CheckStep.Name = "CheckStep";
            this.CheckStep.Size = new System.Drawing.Size(46, 16);
            this.CheckStep.TabIndex = 7;
            this.CheckStep.Text = "step";
            this.CheckStep.UseVisualStyleBackColor = true;
            // 
            // CheckIges
            // 
            this.CheckIges.AutoSize = true;
            this.CheckIges.Location = new System.Drawing.Point(58, 18);
            this.CheckIges.Name = "CheckIges";
            this.CheckIges.Size = new System.Drawing.Size(39, 16);
            this.CheckIges.TabIndex = 8;
            this.CheckIges.Text = "igs";
            this.CheckIges.UseVisualStyleBackColor = true;
            // 
            // CheckStl
            // 
            this.CheckStl.AutoSize = true;
            this.CheckStl.Location = new System.Drawing.Point(103, 18);
            this.CheckStl.Name = "CheckStl";
            this.CheckStl.Size = new System.Drawing.Size(37, 16);
            this.CheckStl.TabIndex = 9;
            this.CheckStl.Text = "stl";
            this.CheckStl.UseVisualStyleBackColor = true;
            this.CheckStl.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // CheckPdf
            // 
            this.CheckPdf.AutoSize = true;
            this.CheckPdf.Location = new System.Drawing.Point(6, 18);
            this.CheckPdf.Name = "CheckPdf";
            this.CheckPdf.Size = new System.Drawing.Size(40, 16);
            this.CheckPdf.TabIndex = 13;
            this.CheckPdf.Text = "pdf";
            this.CheckPdf.UseVisualStyleBackColor = true;
            this.CheckPdf.CheckedChanged += new System.EventHandler(this.CheckPdf_CheckedChanged);
            // 
            // NoMoveExportfile
            // 
            this.NoMoveExportfile.AutoSize = true;
            this.NoMoveExportfile.Checked = true;
            this.NoMoveExportfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoMoveExportfile.Location = new System.Drawing.Point(6, 18);
            this.NoMoveExportfile.Name = "NoMoveExportfile";
            this.NoMoveExportfile.Size = new System.Drawing.Size(133, 16);
            this.NoMoveExportfile.TabIndex = 14;
            this.NoMoveExportfile.Text = "元のファイルと同じ場所";
            this.NoMoveExportfile.UseVisualStyleBackColor = true;
            this.NoMoveExportfile.CheckedChanged += new System.EventHandler(this.NoMoveExportfile_CheckedChanged);
            // 
            // ExportModeDataType
            // 
            this.ExportModeDataType.Controls.Add(this.CheckStep);
            this.ExportModeDataType.Controls.Add(this.CheckIges);
            this.ExportModeDataType.Controls.Add(this.CheckStl);
            this.ExportModeDataType.Location = new System.Drawing.Point(255, 76);
            this.ExportModeDataType.Name = "ExportModeDataType";
            this.ExportModeDataType.Size = new System.Drawing.Size(365, 46);
            this.ExportModeDataType.TabIndex = 15;
            this.ExportModeDataType.TabStop = false;
            this.ExportModeDataType.Text = "モデルエクスポートファイル形式";
            // 
            // ExportDocDataType
            // 
            this.ExportDocDataType.Controls.Add(this.CheckPdf);
            this.ExportDocDataType.Controls.Add(this.CheckDxf);
            this.ExportDocDataType.Location = new System.Drawing.Point(255, 24);
            this.ExportDocDataType.Name = "ExportDocDataType";
            this.ExportDocDataType.Size = new System.Drawing.Size(365, 46);
            this.ExportDocDataType.TabIndex = 16;
            this.ExportDocDataType.TabStop = false;
            this.ExportDocDataType.Text = "図面エクスポートファイル形式";
            this.ExportDocDataType.Enter += new System.EventHandler(this.ExportDocDataType_Enter);
            // 
            // ExportOptions
            // 
            this.ExportOptions.Controls.Add(this.ExportFolderBotton);
            this.ExportOptions.Controls.Add(this.MoveExportFile);
            this.ExportOptions.Controls.Add(this.NoMoveExportfile);
            this.ExportOptions.Controls.Add(this.ExportFolder);
            this.ExportOptions.Location = new System.Drawing.Point(255, 128);
            this.ExportOptions.Name = "ExportOptions";
            this.ExportOptions.Size = new System.Drawing.Size(365, 113);
            this.ExportOptions.TabIndex = 17;
            this.ExportOptions.TabStop = false;
            this.ExportOptions.Text = "エクスポートフォルダ";
            // 
            // ExportFolderBotton
            // 
            this.ExportFolderBotton.Enabled = false;
            this.ExportFolderBotton.Location = new System.Drawing.Point(293, 64);
            this.ExportFolderBotton.Name = "ExportFolderBotton";
            this.ExportFolderBotton.Size = new System.Drawing.Size(55, 19);
            this.ExportFolderBotton.TabIndex = 19;
            this.ExportFolderBotton.Text = "参照";
            this.ExportFolderBotton.UseVisualStyleBackColor = true;
            this.ExportFolderBotton.Click += new System.EventHandler(this.ExportFolderBotton_Click);
            // 
            // MoveExportFile
            // 
            this.MoveExportFile.AutoSize = true;
            this.MoveExportFile.Location = new System.Drawing.Point(6, 41);
            this.MoveExportFile.Name = "MoveExportFile";
            this.MoveExportFile.Size = new System.Drawing.Size(93, 16);
            this.MoveExportFile.TabIndex = 18;
            this.MoveExportFile.Text = "以下のフォルダ";
            this.MoveExportFile.UseVisualStyleBackColor = true;
            this.MoveExportFile.CheckedChanged += new System.EventHandler(this.MoveExportfile_CheckedChanged);
            // 
            // ExportFolder
            // 
            this.ExportFolder.Enabled = false;
            this.ExportFolder.FormattingEnabled = true;
            this.ExportFolder.HorizontalScrollbar = true;
            this.ExportFolder.ItemHeight = 12;
            this.ExportFolder.Location = new System.Drawing.Point(6, 64);
            this.ExportFolder.Name = "ExportFolder";
            this.ExportFolder.Size = new System.Drawing.Size(280, 40);
            this.ExportFolder.TabIndex = 16;
            this.ExportFolder.SelectedIndexChanged += new System.EventHandler(this.ExportFolder_SelectedIndexChanged);
            // 
            // ExportExtensionFolder
            // 
            this.ExportExtensionFolder.AutoSize = true;
            this.ExportExtensionFolder.Checked = true;
            this.ExportExtensionFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportExtensionFolder.Location = new System.Drawing.Point(6, 18);
            this.ExportExtensionFolder.Name = "ExportExtensionFolder";
            this.ExportExtensionFolder.Size = new System.Drawing.Size(183, 16);
            this.ExportExtensionFolder.TabIndex = 15;
            this.ExportExtensionFolder.Text = "ファイル形式ごとにフォルダを分ける";
            this.ExportExtensionFolder.UseVisualStyleBackColor = true;
            // 
            // CancelBotton
            // 
            this.CancelBotton.Location = new System.Drawing.Point(87, 18);
            this.CancelBotton.Name = "CancelBotton";
            this.CancelBotton.Size = new System.Drawing.Size(75, 23);
            this.CancelBotton.TabIndex = 19;
            this.CancelBotton.Text = "キャンセル";
            this.CancelBotton.UseVisualStyleBackColor = true;
            this.CancelBotton.Click += new System.EventHandler(this.CancelBotton_Click);
            // 
            // GoBotton
            // 
            this.GoBotton.Location = new System.Drawing.Point(6, 18);
            this.GoBotton.Name = "GoBotton";
            this.GoBotton.Size = new System.Drawing.Size(75, 23);
            this.GoBotton.TabIndex = 20;
            this.GoBotton.Text = "変換開始";
            this.GoBotton.UseVisualStyleBackColor = true;
            this.GoBotton.Click += new System.EventHandler(this.GoBotton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoBotton);
            this.groupBox1.Controls.Add(this.CancelBotton);
            this.groupBox1.Location = new System.Drawing.Point(448, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 53);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MakeZipFileBotton);
            this.groupBox2.Controls.Add(this.MakeZipFileFolder);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.ExportExtensionFolder);
            this.groupBox2.Location = new System.Drawing.Point(255, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "エクスポートオプション";
            // 
            // MakeZipFileBotton
            // 
            this.MakeZipFileBotton.Enabled = false;
            this.MakeZipFileBotton.Location = new System.Drawing.Point(293, 62);
            this.MakeZipFileBotton.Name = "MakeZipFileBotton";
            this.MakeZipFileBotton.Size = new System.Drawing.Size(55, 19);
            this.MakeZipFileBotton.TabIndex = 20;
            this.MakeZipFileBotton.Text = "参照";
            this.MakeZipFileBotton.UseVisualStyleBackColor = true;
            this.MakeZipFileBotton.Click += new System.EventHandler(this.MakeZipFileBotton_Click);
            // 
            // MakeZipFileFolder
            // 
            this.MakeZipFileFolder.Enabled = false;
            this.MakeZipFileFolder.FormattingEnabled = true;
            this.MakeZipFileFolder.HorizontalScrollbar = true;
            this.MakeZipFileFolder.ItemHeight = 12;
            this.MakeZipFileFolder.Location = new System.Drawing.Point(6, 62);
            this.MakeZipFileFolder.Name = "MakeZipFileFolder";
            this.MakeZipFileFolder.Size = new System.Drawing.Size(280, 40);
            this.MakeZipFileFolder.TabIndex = 20;
            this.MakeZipFileFolder.SelectedIndexChanged += new System.EventHandler(this.MakeZipFileFolder_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "以下のフォルダに部品ごとのZipファイルを生成する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FileSelect
            // 
            this.FileSelect.Controls.Add(this.listBox1);
            this.FileSelect.Controls.Add(this.GetFilePathBotton);
            this.FileSelect.Location = new System.Drawing.Point(12, 12);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(237, 408);
            this.FileSelect.TabIndex = 23;
            this.FileSelect.TabStop = false;
            this.FileSelect.Text = "ファイル選択";
            this.FileSelect.Enter += new System.EventHandler(this.FileSelect_Enter);
            // 
            // ExportFileDialog
            // 
            this.ExportFileDialog.FileName = "ExportFileDialog";
            this.ExportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportFileDialog_FileOk);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 385);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 23);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 431);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportOptions);
            this.Controls.Add(this.ExportDocDataType);
            this.Controls.Add(this.ExportModeDataType);
            this.Controls.Add(this.FileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ExportModeDataType.ResumeLayout(false);
            this.ExportModeDataType.PerformLayout();
            this.ExportDocDataType.ResumeLayout(false);
            this.ExportDocDataType.PerformLayout();
            this.ExportOptions.ResumeLayout(false);
            this.ExportOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FileSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetFilePathBotton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox ExportModeDataType;
        private System.Windows.Forms.GroupBox ExportDocDataType;
        private System.Windows.Forms.GroupBox ExportOptions;
        private System.Windows.Forms.Button CancelBotton;
        private System.Windows.Forms.Button GoBotton;
        private System.Windows.Forms.Button ExportFolderBotton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MakeZipFileBotton;
        private System.Windows.Forms.GroupBox FileSelect;
        private System.Windows.Forms.OpenFileDialog ExportFileDialog;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.CheckBox CheckDxf;
        public System.Windows.Forms.CheckBox CheckStep;
        public System.Windows.Forms.CheckBox CheckIges;
        public System.Windows.Forms.CheckBox CheckStl;
        public System.Windows.Forms.CheckBox CheckPdf;
        public System.Windows.Forms.CheckBox NoMoveExportfile;
        public System.Windows.Forms.CheckBox MoveExportFile;
        public System.Windows.Forms.ListBox ExportFolder;
        public System.Windows.Forms.CheckBox ExportExtensionFolder;
        public System.Windows.Forms.ListBox MakeZipFileFolder;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}

