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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource_DriveInfo = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView_DriveInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Options = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RunAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_StressTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MountImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_BitLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CreateImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RefreshDrives = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Column_Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_StressTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_MountImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_BitLocker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_CreateImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rootDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReadyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.availableFreeSpaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DriveInfo)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource_DriveInfo
            // 
            this.bindingSource_DriveInfo.DataSource = typeof(System.IO.DriveInfo);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView_DriveInfo);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(703, 281);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(805, 281);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // dataGridView_DriveInfo
            // 
            this.dataGridView_DriveInfo.AutoGenerateColumns = false;
            this.dataGridView_DriveInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DriveInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_DriveInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DriveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DriveInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Selected,
            this.Column_StressTest,
            this.Column_MountImage,
            this.Column_BitLocker,
            this.Column_CreateImage,
            this.rootDirectoryDataGridViewTextBoxColumn,
            this.driveTypeDataGridViewTextBoxColumn,
            this.driveFormatDataGridViewTextBoxColumn,
            this.isReadyDataGridViewCheckBoxColumn,
            this.availableFreeSpaceDataGridViewTextBoxColumn,
            this.totalSizeDataGridViewTextBoxColumn,
            this.volumeLabelDataGridViewTextBoxColumn});
            this.dataGridView_DriveInfo.DataSource = this.bindingSource_DriveInfo;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DriveInfo.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_DriveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DriveInfo.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView_DriveInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DriveInfo.Name = "dataGridView_DriveInfo";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_DriveInfo.Size = new System.Drawing.Size(703, 281);
            this.dataGridView_DriveInfo.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Options,
            this.toolStripButton_RefreshDrives,
            this.toolStripSeparator1,
            this.toolStripButton_RunAll,
            this.toolStripSeparator2,
            this.toolStripButton_StressTest,
            this.toolStripButton_MountImage,
            this.toolStripButton_BitLock,
            this.toolStripButton_CreateImage,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(102, 278);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_Options
            // 
            this.toolStripButton_Options.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_Options.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_Options.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Options.Image")));
            this.toolStripButton_Options.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_Options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Options.Name = "toolStripButton_Options";
            this.toolStripButton_Options.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_Options.Text = "Options";
            this.toolStripButton_Options.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_Options.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton_Options.Click += new System.EventHandler(this.toolStripButton_Options_Click);
            // 
            // toolStripButton_RunAll
            // 
            this.toolStripButton_RunAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_RunAll.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_RunAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RunAll.Image")));
            this.toolStripButton_RunAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_RunAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RunAll.Name = "toolStripButton_RunAll";
            this.toolStripButton_RunAll.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_RunAll.Text = "Run All";
            this.toolStripButton_RunAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_RunAll.Click += new System.EventHandler(this.toolStripButton_RunAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripButton_StressTest
            // 
            this.toolStripButton_StressTest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_StressTest.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_StressTest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_StressTest.Image")));
            this.toolStripButton_StressTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_StressTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_StressTest.Name = "toolStripButton_StressTest";
            this.toolStripButton_StressTest.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_StressTest.Text = "Stress Test";
            this.toolStripButton_StressTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_StressTest.Click += new System.EventHandler(this.toolStripButton_StressTest_Click);
            // 
            // toolStripButton_MountImage
            // 
            this.toolStripButton_MountImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_MountImage.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_MountImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_MountImage.Image")));
            this.toolStripButton_MountImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MountImage.Name = "toolStripButton_MountImage";
            this.toolStripButton_MountImage.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_MountImage.Text = "Mount Image";
            this.toolStripButton_MountImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_MountImage.Click += new System.EventHandler(this.toolStripButton_MountImage_Click);
            // 
            // toolStripButton_BitLock
            // 
            this.toolStripButton_BitLock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_BitLock.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_BitLock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_BitLock.Image")));
            this.toolStripButton_BitLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_BitLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_BitLock.Name = "toolStripButton_BitLock";
            this.toolStripButton_BitLock.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_BitLock.Text = "Bit lock";
            this.toolStripButton_BitLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_BitLock.Click += new System.EventHandler(this.toolStripButton_BitLock_Click);
            // 
            // toolStripButton_CreateImage
            // 
            this.toolStripButton_CreateImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_CreateImage.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_CreateImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CreateImage.Image")));
            this.toolStripButton_CreateImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_CreateImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CreateImage.Name = "toolStripButton_CreateImage";
            this.toolStripButton_CreateImage.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_CreateImage.Text = "Create Image";
            this.toolStripButton_CreateImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_CreateImage.Click += new System.EventHandler(this.toolStripButton_CreateImage_Click);
            // 
            // toolStripButton_RefreshDrives
            // 
            this.toolStripButton_RefreshDrives.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_RefreshDrives.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_RefreshDrives.Image = global::FAT_Utility.Properties.Resources.repeat_1;
            this.toolStripButton_RefreshDrives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_RefreshDrives.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RefreshDrives.Name = "toolStripButton_RefreshDrives";
            this.toolStripButton_RefreshDrives.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_RefreshDrives.Text = "Refresh Drives";
            this.toolStripButton_RefreshDrives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // Column_Selected
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_Selected.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Selected.HeaderText = "Selected";
            this.Column_Selected.Name = "Column_Selected";
            // 
            // Column_StressTest
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_StressTest.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_StressTest.HeaderText = "Stress Test";
            this.Column_StressTest.Name = "Column_StressTest";
            // 
            // Column_MountImage
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_MountImage.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_MountImage.HeaderText = "Mount Image";
            this.Column_MountImage.Name = "Column_MountImage";
            this.Column_MountImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_MountImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_BitLocker
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_BitLocker.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_BitLocker.HeaderText = "Bit Locker";
            this.Column_BitLocker.Name = "Column_BitLocker";
            // 
            // Column_CreateImage
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_CreateImage.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_CreateImage.HeaderText = "Create Image";
            this.Column_CreateImage.Name = "Column_CreateImage";
            // 
            // rootDirectoryDataGridViewTextBoxColumn
            // 
            this.rootDirectoryDataGridViewTextBoxColumn.DataPropertyName = "RootDirectory";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Lime;
            this.rootDirectoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.rootDirectoryDataGridViewTextBoxColumn.HeaderText = "RootDirectory";
            this.rootDirectoryDataGridViewTextBoxColumn.Name = "rootDirectoryDataGridViewTextBoxColumn";
            this.rootDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveTypeDataGridViewTextBoxColumn
            // 
            this.driveTypeDataGridViewTextBoxColumn.DataPropertyName = "DriveType";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driveTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.driveTypeDataGridViewTextBoxColumn.HeaderText = "DriveType";
            this.driveTypeDataGridViewTextBoxColumn.Name = "driveTypeDataGridViewTextBoxColumn";
            this.driveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveFormatDataGridViewTextBoxColumn
            // 
            this.driveFormatDataGridViewTextBoxColumn.DataPropertyName = "DriveFormat";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Lime;
            this.driveFormatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.driveFormatDataGridViewTextBoxColumn.HeaderText = "DriveFormat";
            this.driveFormatDataGridViewTextBoxColumn.Name = "driveFormatDataGridViewTextBoxColumn";
            this.driveFormatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isReadyDataGridViewCheckBoxColumn
            // 
            this.isReadyDataGridViewCheckBoxColumn.DataPropertyName = "IsReady";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.NullValue = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Lime;
            this.isReadyDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.isReadyDataGridViewCheckBoxColumn.HeaderText = "IsReady";
            this.isReadyDataGridViewCheckBoxColumn.Name = "isReadyDataGridViewCheckBoxColumn";
            this.isReadyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // availableFreeSpaceDataGridViewTextBoxColumn
            // 
            this.availableFreeSpaceDataGridViewTextBoxColumn.DataPropertyName = "AvailableFreeSpace";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Lime;
            this.availableFreeSpaceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.availableFreeSpaceDataGridViewTextBoxColumn.HeaderText = "AvailableFreeSpace";
            this.availableFreeSpaceDataGridViewTextBoxColumn.Name = "availableFreeSpaceDataGridViewTextBoxColumn";
            this.availableFreeSpaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSizeDataGridViewTextBoxColumn
            // 
            this.totalSizeDataGridViewTextBoxColumn.DataPropertyName = "TotalSize";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Lime;
            this.totalSizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.totalSizeDataGridViewTextBoxColumn.HeaderText = "TotalSize";
            this.totalSizeDataGridViewTextBoxColumn.Name = "totalSizeDataGridViewTextBoxColumn";
            this.totalSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeLabelDataGridViewTextBoxColumn
            // 
            this.volumeLabelDataGridViewTextBoxColumn.DataPropertyName = "VolumeLabel";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Lime;
            this.volumeLabelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.volumeLabelDataGridViewTextBoxColumn.HeaderText = "VolumeLabel";
            this.volumeLabelDataGridViewTextBoxColumn.Name = "volumeLabelDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 281);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_DriveInfo)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_DriveInfo;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView_DriveInfo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Options;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_StressTest;
        private System.Windows.Forms.ToolStripButton toolStripButton_MountImage;
        private System.Windows.Forms.ToolStripButton toolStripButton_BitLock;
        private System.Windows.Forms.ToolStripButton toolStripButton_CreateImage;
        private System.Windows.Forms.ToolStripButton toolStripButton_RunAll;
        private System.Windows.Forms.ToolStripButton toolStripButton_RefreshDrives;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Selected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_StressTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_MountImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_BitLocker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_CreateImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReadyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableFreeSpaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeLabelDataGridViewTextBoxColumn;
    }
}

