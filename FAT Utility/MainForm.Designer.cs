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
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource_SelectedDriveInfo = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView_DriveInfo = new System.Windows.Forms.DataGridView();
            this.rootDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_StressTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_MountImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_BitLocker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_CreateImage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource_MultiDriveInfo = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_DriveName = new System.Windows.Forms.Label();
            this.label_DriveType = new System.Windows.Forms.Label();
            this.label_DriveTotalSize = new System.Windows.Forms.Label();
            this.label_DriveAvailableFreeSpace = new System.Windows.Forms.Label();
            this.label_IsReady = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_DiveFormat = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Options = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RefreshDrives = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_RunAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_StressTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MountImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_BitLock = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CreateImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            Label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SelectedDriveInfo)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_MultiDriveInfo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "Name", true));
            Label1.ForeColor = System.Drawing.Color.Lime;
            Label1.Location = new System.Drawing.Point(109, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(16, 13);
            Label1.TabIndex = 8;
            Label1.Text = "---";
            // 
            // bindingSource_SelectedDriveInfo
            // 
            this.bindingSource_SelectedDriveInfo.DataSource = typeof(System.IO.DriveInfo);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "DriveFormat", true));
            label2.ForeColor = System.Drawing.Color.Lime;
            label2.Location = new System.Drawing.Point(109, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(16, 13);
            label2.TabIndex = 10;
            label2.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "DriveType", true));
            label3.ForeColor = System.Drawing.Color.Lime;
            label3.Location = new System.Drawing.Point(109, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(16, 13);
            label3.TabIndex = 11;
            label3.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "VolumeLabel", true));
            label4.ForeColor = System.Drawing.Color.Lime;
            label4.Location = new System.Drawing.Point(109, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(16, 13);
            label4.TabIndex = 12;
            label4.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "IsReady", true));
            label5.ForeColor = System.Drawing.Color.Lime;
            label5.Location = new System.Drawing.Point(109, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(16, 13);
            label5.TabIndex = 13;
            label5.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "AvailableFreeSpace", true));
            label6.ForeColor = System.Drawing.Color.Lime;
            label6.Location = new System.Drawing.Point(109, 96);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(16, 13);
            label6.TabIndex = 14;
            label6.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_SelectedDriveInfo, "TotalSize", true));
            label7.ForeColor = System.Drawing.Color.Lime;
            label7.Location = new System.Drawing.Point(109, 117);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(16, 13);
            label7.TabIndex = 15;
            label7.Text = "---";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView_DriveInfo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(780, 271);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(882, 296);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // dataGridView_DriveInfo
            // 
            this.dataGridView_DriveInfo.AllowUserToOrderColumns = true;
            this.dataGridView_DriveInfo.AutoGenerateColumns = false;
            this.dataGridView_DriveInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DriveInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_DriveInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_DriveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DriveInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rootDirectoryDataGridViewTextBoxColumn,
            this.driveTypeDataGridViewTextBoxColumn,
            this.driveFormatDataGridViewTextBoxColumn,
            this.volumeLabelDataGridViewTextBoxColumn,
            this.Column_Selected,
            this.Column_StressTest,
            this.Column_MountImage,
            this.Column_BitLocker,
            this.Column_CreateImage});
            this.dataGridView_DriveInfo.DataSource = this.bindingSource_MultiDriveInfo;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DriveInfo.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView_DriveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DriveInfo.EnableHeadersVisualStyles = false;
            this.dataGridView_DriveInfo.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView_DriveInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DriveInfo.Name = "dataGridView_DriveInfo";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DriveInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView_DriveInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DriveInfo.Size = new System.Drawing.Size(570, 271);
            this.dataGridView_DriveInfo.TabIndex = 4;
            this.dataGridView_DriveInfo.Click += new System.EventHandler(this.dataGridView_DriveInfo_Click);
            // 
            // rootDirectoryDataGridViewTextBoxColumn
            // 
            this.rootDirectoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rootDirectoryDataGridViewTextBoxColumn.DataPropertyName = "RootDirectory";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Lime;
            this.rootDirectoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.rootDirectoryDataGridViewTextBoxColumn.HeaderText = "RootDirectory";
            this.rootDirectoryDataGridViewTextBoxColumn.Name = "rootDirectoryDataGridViewTextBoxColumn";
            this.rootDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveTypeDataGridViewTextBoxColumn
            // 
            this.driveTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driveTypeDataGridViewTextBoxColumn.DataPropertyName = "DriveType";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driveTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.driveTypeDataGridViewTextBoxColumn.HeaderText = "DriveType";
            this.driveTypeDataGridViewTextBoxColumn.Name = "driveTypeDataGridViewTextBoxColumn";
            this.driveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driveFormatDataGridViewTextBoxColumn
            // 
            this.driveFormatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.driveFormatDataGridViewTextBoxColumn.DataPropertyName = "DriveFormat";
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Lime;
            this.driveFormatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.driveFormatDataGridViewTextBoxColumn.HeaderText = "DriveFormat";
            this.driveFormatDataGridViewTextBoxColumn.Name = "driveFormatDataGridViewTextBoxColumn";
            this.driveFormatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeLabelDataGridViewTextBoxColumn
            // 
            this.volumeLabelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.volumeLabelDataGridViewTextBoxColumn.DataPropertyName = "VolumeLabel";
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Lime;
            this.volumeLabelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.volumeLabelDataGridViewTextBoxColumn.HeaderText = "VolumeLabel";
            this.volumeLabelDataGridViewTextBoxColumn.Name = "volumeLabelDataGridViewTextBoxColumn";
            this.volumeLabelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column_Selected
            // 
            this.Column_Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle18.NullValue = false;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_Selected.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_Selected.FillWeight = 75F;
            this.Column_Selected.HeaderText = "Selected";
            this.Column_Selected.Name = "Column_Selected";
            // 
            // Column_StressTest
            // 
            this.Column_StressTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle19.NullValue = false;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_StressTest.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column_StressTest.FillWeight = 50F;
            this.Column_StressTest.HeaderText = "Stress Test";
            this.Column_StressTest.Name = "Column_StressTest";
            // 
            // Column_MountImage
            // 
            this.Column_MountImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle20.NullValue = false;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_MountImage.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column_MountImage.FillWeight = 50F;
            this.Column_MountImage.HeaderText = "Mount Image";
            this.Column_MountImage.Name = "Column_MountImage";
            this.Column_MountImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_MountImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_BitLocker
            // 
            this.Column_BitLocker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle21.NullValue = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_BitLocker.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column_BitLocker.FillWeight = 50F;
            this.Column_BitLocker.HeaderText = "Bit Locker";
            this.Column_BitLocker.Name = "Column_BitLocker";
            // 
            // Column_CreateImage
            // 
            this.Column_CreateImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle22.NullValue = false;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Lime;
            this.Column_CreateImage.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column_CreateImage.FillWeight = 50F;
            this.Column_CreateImage.HeaderText = "Create Image";
            this.Column_CreateImage.Name = "Column_CreateImage";
            // 
            // bindingSource_MultiDriveInfo
            // 
            this.bindingSource_MultiDriveInfo.DataSource = typeof(System.IO.DriveInfo);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(570, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 271);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(580, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 271);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Lime;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Drive Info";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(186, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(Label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_DriveName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_DriveType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_DriveTotalSize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_DriveAvailableFreeSpace, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_IsReady, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_DiveFormat, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 141);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_DriveName
            // 
            this.label_DriveName.AutoSize = true;
            this.label_DriveName.ForeColor = System.Drawing.Color.Lime;
            this.label_DriveName.Location = new System.Drawing.Point(3, 0);
            this.label_DriveName.Name = "label_DriveName";
            this.label_DriveName.Size = new System.Drawing.Size(35, 13);
            this.label_DriveName.TabIndex = 0;
            this.label_DriveName.Text = "Name";
            // 
            // label_DriveType
            // 
            this.label_DriveType.AutoSize = true;
            this.label_DriveType.ForeColor = System.Drawing.Color.Lime;
            this.label_DriveType.Location = new System.Drawing.Point(3, 36);
            this.label_DriveType.Name = "label_DriveType";
            this.label_DriveType.Size = new System.Drawing.Size(59, 13);
            this.label_DriveType.TabIndex = 2;
            this.label_DriveType.Text = "Drive Type";
            // 
            // label_DriveTotalSize
            // 
            this.label_DriveTotalSize.AutoSize = true;
            this.label_DriveTotalSize.ForeColor = System.Drawing.Color.Lime;
            this.label_DriveTotalSize.Location = new System.Drawing.Point(3, 117);
            this.label_DriveTotalSize.Name = "label_DriveTotalSize";
            this.label_DriveTotalSize.Size = new System.Drawing.Size(54, 13);
            this.label_DriveTotalSize.TabIndex = 8;
            this.label_DriveTotalSize.Text = "Total Size";
            // 
            // label_DriveAvailableFreeSpace
            // 
            this.label_DriveAvailableFreeSpace.AutoSize = true;
            this.label_DriveAvailableFreeSpace.ForeColor = System.Drawing.Color.Lime;
            this.label_DriveAvailableFreeSpace.Location = new System.Drawing.Point(3, 96);
            this.label_DriveAvailableFreeSpace.Name = "label_DriveAvailableFreeSpace";
            this.label_DriveAvailableFreeSpace.Size = new System.Drawing.Size(84, 13);
            this.label_DriveAvailableFreeSpace.TabIndex = 6;
            this.label_DriveAvailableFreeSpace.Text = "Available Space";
            // 
            // label_IsReady
            // 
            this.label_IsReady.AutoSize = true;
            this.label_IsReady.ForeColor = System.Drawing.Color.Lime;
            this.label_IsReady.Location = new System.Drawing.Point(3, 76);
            this.label_IsReady.Name = "label_IsReady";
            this.label_IsReady.Size = new System.Drawing.Size(55, 13);
            this.label_IsReady.TabIndex = 4;
            this.label_IsReady.Text = "Is Ready?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(3, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Valume Label";
            // 
            // label_DiveFormat
            // 
            this.label_DiveFormat.ForeColor = System.Drawing.Color.Lime;
            this.label_DiveFormat.Location = new System.Drawing.Point(3, 13);
            this.label_DiveFormat.Name = "label_DiveFormat";
            this.label_DiveFormat.Size = new System.Drawing.Size(100, 23);
            this.label_DiveFormat.TabIndex = 9;
            this.label_DiveFormat.Text = "Drive Format";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(141, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.toolStripButton_StressTest,
            this.toolStripButton_MountImage,
            this.toolStripButton_BitLock,
            this.toolStripButton_CreateImage,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(102, 268);
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
            // toolStripButton_RefreshDrives
            // 
            this.toolStripButton_RefreshDrives.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripButton_RefreshDrives.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_RefreshDrives.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RefreshDrives.Image")));
            this.toolStripButton_RefreshDrives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton_RefreshDrives.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RefreshDrives.Name = "toolStripButton_RefreshDrives";
            this.toolStripButton_RefreshDrives.Size = new System.Drawing.Size(100, 20);
            this.toolStripButton_RefreshDrives.Text = "Refresh Drives";
            this.toolStripButton_RefreshDrives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_RefreshDrives.Click += new System.EventHandler(this.toolStripButton_RefreshDrives_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 296);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SelectedDriveInfo)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_MultiDriveInfo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Options;
        private System.Windows.Forms.ToolStripButton toolStripButton_RefreshDrives;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_RunAll;
        private System.Windows.Forms.ToolStripButton toolStripButton_StressTest;
        private System.Windows.Forms.ToolStripButton toolStripButton_MountImage;
        private System.Windows.Forms.ToolStripButton toolStripButton_BitLock;
        private System.Windows.Forms.ToolStripButton toolStripButton_CreateImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_DriveAvailableFreeSpace;
        private System.Windows.Forms.Label label_DriveName;
        private System.Windows.Forms.Label label_DriveType;
        private System.Windows.Forms.Label label_IsReady;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_DriveTotalSize;
        private System.Windows.Forms.Label label_DiveFormat;
        private System.Windows.Forms.BindingSource bindingSource_SelectedDriveInfo;
        private System.Windows.Forms.BindingSource bindingSource_MultiDriveInfo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView_DriveInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Selected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_StressTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_MountImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_BitLocker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_CreateImage;
    }
}

