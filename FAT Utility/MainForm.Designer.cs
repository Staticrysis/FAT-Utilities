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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DriveInfo.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView_DriveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DriveInfo.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView_DriveInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DriveInfo.Name = "dataGridView_DriveInfo";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
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
            this.toolStripButton_RefreshDrives.Click += new System.EventHandler(this.toolStripButton_RefreshDrives_Click);
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle17.NullValue = false;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_Selected.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column_Selected.HeaderText = "Selected";
            this.Column_Selected.Name = "Column_Selected";
            // 
            // Column_StressTest
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle18.NullValue = false;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_StressTest.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_StressTest.HeaderText = "Stress Test";
            this.Column_StressTest.Name = "Column_StressTest";
            // 
            // Column_MountImage
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle19.NullValue = false;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_MountImage.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column_MountImage.HeaderText = "Mount Image";
            this.Column_MountImage.Name = "Column_MountImage";
            this.Column_MountImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_MountImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_BitLocker
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle20.NullValue = false;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_BitLocker.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column_BitLocker.HeaderText = "Bit Locker";
            this.Column_BitLocker.Name = "Column_BitLocker";
            // 
            // Column_CreateImage
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle21.NullValue = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_CreateImage.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column_CreateImage.HeaderText = "Create Image";
            this.Column_CreateImage.Name = "Column_CreateImage";
            // 
            // rootDirectoryDataGridViewTextBoxColumn
            // 
            this.rootDirectoryDataGridViewTextBoxColumn.DataPropertyName = "RootDirectory";
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Lime;
            this.rootDirectoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.rootDirectoryDataGridViewTextBoxColumn.HeaderText = "RootDirectory";
            this.rootDirectoryDataGridViewTextBoxColumn.Name = "rootDirectoryDataGridViewTextBoxColumn";
            this.rootDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveTypeDataGridViewTextBoxColumn
            // 
            this.driveTypeDataGridViewTextBoxColumn.DataPropertyName = "DriveType";
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driveTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.driveTypeDataGridViewTextBoxColumn.HeaderText = "DriveType";
            this.driveTypeDataGridViewTextBoxColumn.Name = "driveTypeDataGridViewTextBoxColumn";
            this.driveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveFormatDataGridViewTextBoxColumn
            // 
            this.driveFormatDataGridViewTextBoxColumn.DataPropertyName = "DriveFormat";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Lime;
            this.driveFormatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.driveFormatDataGridViewTextBoxColumn.HeaderText = "DriveFormat";
            this.driveFormatDataGridViewTextBoxColumn.Name = "driveFormatDataGridViewTextBoxColumn";
            this.driveFormatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isReadyDataGridViewCheckBoxColumn
            // 
            this.isReadyDataGridViewCheckBoxColumn.DataPropertyName = "IsReady";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle25.NullValue = false;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Lime;
            this.isReadyDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.isReadyDataGridViewCheckBoxColumn.HeaderText = "IsReady";
            this.isReadyDataGridViewCheckBoxColumn.Name = "isReadyDataGridViewCheckBoxColumn";
            this.isReadyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // availableFreeSpaceDataGridViewTextBoxColumn
            // 
            this.availableFreeSpaceDataGridViewTextBoxColumn.DataPropertyName = "AvailableFreeSpace";
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Lime;
            this.availableFreeSpaceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.availableFreeSpaceDataGridViewTextBoxColumn.HeaderText = "AvailableFreeSpace";
            this.availableFreeSpaceDataGridViewTextBoxColumn.Name = "availableFreeSpaceDataGridViewTextBoxColumn";
            this.availableFreeSpaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSizeDataGridViewTextBoxColumn
            // 
            this.totalSizeDataGridViewTextBoxColumn.DataPropertyName = "TotalSize";
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Lime;
            this.totalSizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.totalSizeDataGridViewTextBoxColumn.HeaderText = "TotalSize";
            this.totalSizeDataGridViewTextBoxColumn.Name = "totalSizeDataGridViewTextBoxColumn";
            this.totalSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeLabelDataGridViewTextBoxColumn
            // 
            this.volumeLabelDataGridViewTextBoxColumn.DataPropertyName = "VolumeLabel";
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Lime;
            this.volumeLabelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle28;
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

