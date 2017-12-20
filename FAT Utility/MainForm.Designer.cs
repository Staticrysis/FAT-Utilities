namespace FAT_Utility
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView_DriveInfo = new System.Windows.Forms.DataGridView();
            this.Column_Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_BitLocker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_CreateImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_StressTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_MountImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.driveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rootDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.availableFreeSpaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_DriveInfo = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DriveInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_DriveInfo
            // 
            this.dataGridView_DriveInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DriveInfo.AutoGenerateColumns = false;
            this.dataGridView_DriveInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DriveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DriveInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Selected,
            this.Column_BitLocker,
            this.Column_CreateImage,
            this.Column_StressTest,
            this.Column_MountImage,
            this.driveTypeDataGridViewTextBoxColumn,
            this.rootDirectoryDataGridViewTextBoxColumn,
            this.driveFormatDataGridViewTextBoxColumn,
            this.isReadyDataGridViewCheckBoxColumn,
            this.availableFreeSpaceDataGridViewTextBoxColumn,
            this.totalSizeDataGridViewTextBoxColumn,
            this.volumeLabelDataGridViewTextBoxColumn});
            this.dataGridView_DriveInfo.DataSource = this.bindingSource_DriveInfo;
            this.dataGridView_DriveInfo.Location = new System.Drawing.Point(126, 0);
            this.dataGridView_DriveInfo.Name = "dataGridView_DriveInfo";
            this.dataGridView_DriveInfo.Size = new System.Drawing.Size(679, 371);
            this.dataGridView_DriveInfo.TabIndex = 1;
            // 
            // Column_Selected
            // 
            this.Column_Selected.HeaderText = "Selected";
            this.Column_Selected.Name = "Column_Selected";
            // 
            // Column_BitLocker
            // 
            this.Column_BitLocker.HeaderText = "Bit Locker";
            this.Column_BitLocker.Name = "Column_BitLocker";
            // 
            // Column_CreateImage
            // 
            this.Column_CreateImage.HeaderText = "Create Image";
            this.Column_CreateImage.Name = "Column_CreateImage";
            // 
            // Column_StressTest
            // 
            this.Column_StressTest.HeaderText = "Stress Test";
            this.Column_StressTest.Name = "Column_StressTest";
            // 
            // Column_MountImage
            // 
            this.Column_MountImage.HeaderText = "Mount Image";
            this.Column_MountImage.Name = "Column_MountImage";
            this.Column_MountImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_MountImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // driveTypeDataGridViewTextBoxColumn
            // 
            this.driveTypeDataGridViewTextBoxColumn.DataPropertyName = "DriveType";
            this.driveTypeDataGridViewTextBoxColumn.HeaderText = "DriveType";
            this.driveTypeDataGridViewTextBoxColumn.Name = "driveTypeDataGridViewTextBoxColumn";
            this.driveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rootDirectoryDataGridViewTextBoxColumn
            // 
            this.rootDirectoryDataGridViewTextBoxColumn.DataPropertyName = "RootDirectory";
            this.rootDirectoryDataGridViewTextBoxColumn.HeaderText = "RootDirectory";
            this.rootDirectoryDataGridViewTextBoxColumn.Name = "rootDirectoryDataGridViewTextBoxColumn";
            this.rootDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveFormatDataGridViewTextBoxColumn
            // 
            this.driveFormatDataGridViewTextBoxColumn.DataPropertyName = "DriveFormat";
            this.driveFormatDataGridViewTextBoxColumn.HeaderText = "DriveFormat";
            this.driveFormatDataGridViewTextBoxColumn.Name = "driveFormatDataGridViewTextBoxColumn";
            this.driveFormatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isReadyDataGridViewCheckBoxColumn
            // 
            this.isReadyDataGridViewCheckBoxColumn.DataPropertyName = "IsReady";
            this.isReadyDataGridViewCheckBoxColumn.HeaderText = "IsReady";
            this.isReadyDataGridViewCheckBoxColumn.Name = "isReadyDataGridViewCheckBoxColumn";
            this.isReadyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // availableFreeSpaceDataGridViewTextBoxColumn
            // 
            this.availableFreeSpaceDataGridViewTextBoxColumn.DataPropertyName = "AvailableFreeSpace";
            this.availableFreeSpaceDataGridViewTextBoxColumn.HeaderText = "AvailableFreeSpace";
            this.availableFreeSpaceDataGridViewTextBoxColumn.Name = "availableFreeSpaceDataGridViewTextBoxColumn";
            this.availableFreeSpaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSizeDataGridViewTextBoxColumn
            // 
            this.totalSizeDataGridViewTextBoxColumn.DataPropertyName = "TotalSize";
            this.totalSizeDataGridViewTextBoxColumn.HeaderText = "TotalSize";
            this.totalSizeDataGridViewTextBoxColumn.Name = "totalSizeDataGridViewTextBoxColumn";
            this.totalSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeLabelDataGridViewTextBoxColumn
            // 
            this.volumeLabelDataGridViewTextBoxColumn.DataPropertyName = "VolumeLabel";
            this.volumeLabelDataGridViewTextBoxColumn.HeaderText = "VolumeLabel";
            this.volumeLabelDataGridViewTextBoxColumn.Name = "volumeLabelDataGridViewTextBoxColumn";
            // 
            // bindingSource_DriveInfo
            // 
            this.bindingSource_DriveInfo.DataSource = typeof(System.IO.DriveInfo);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(114, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Location = new System.Drawing.Point(3, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drive Info";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(114, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_DriveInfo);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DriveInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_DriveInfo;
        private System.Windows.Forms.DataGridView dataGridView_DriveInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Selected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_BitLocker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_CreateImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_StressTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_MountImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableFreeSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

