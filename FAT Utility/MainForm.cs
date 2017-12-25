using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FAT_Utility
{
    public partial class MainForm : Form
    {
        //private Timer timer = new Timer() { Enabled = true, Interval = 3000};
        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        public void InitializeMainForm()
        {
            toolStripButton_RefreshDrives_Click(null, null);
            //timer.Tick += toolStripButton_RefreshDrives_Click;
        }

        private void toolStripButton_Options_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton_RunAll_Click(object sender, EventArgs e)
        {
            //toolStripButton_StressTest_Click(null, null);
            //toolStripButton_MountImage_Click(null, null);
            //toolStripButton_BitLock_Click(null, null);
            //toolStripButton_CreateImage_Click(null, null);
        }

        private void toolStripButton_StressTest_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_MountImage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_BitLock_Click(object sender, EventArgs e)
        {
            Data.BitLock(FetchColumnDriveInfo("Column_BitLocker"));
        }

        private void toolStripButton_CreateImage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_RefreshDrives_Click(object sender, EventArgs e)
        {
            bindingSource_MultiDriveInfo.DataSource = Data.UpdateDriveInfo();
        }

        private List<DriveInfo> FetchColumnDriveInfo(string column)
        {
            List<DriveInfo> RunnableDI = new List<DriveInfo>();

            for (int r = 0; r < dataGridView_DriveInfo.Rows.Count; r++)
                if (dataGridView_DriveInfo.Rows[r].Cells[column].Value == null ? false : true == true &&
                    dataGridView_DriveInfo.Rows[r].Cells["Column_Run"].Value == null ? false : true)
                {
                    RunnableDI.Add((DriveInfo)dataGridView_DriveInfo.Rows[r].DataBoundItem);
                };

            return RunnableDI;
        }

        private void dataGridView_DriveInfo_Click(object sender, EventArgs e)
        {
            if (sender == null) return;

            var view = (DataGridView)sender;
            var CurrentInfo = (DriveInfo)view.CurrentRow.DataBoundItem;
            if (view.CurrentRow != null)
            {
                bindingSource_SelectedDriveInfo.DataSource = CurrentInfo;
                label_LastWrite.Text = CurrentInfo.RootDirectory.LastWriteTime.ToLocalTime().ToString();
                label_LastAccessed.Text = CurrentInfo.RootDirectory.LastAccessTime.ToLocalTime().ToString();
            }
            //Maybe place a progress bar update in this event later. 
        }

        private void dataGridView_DriveInfo_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var view = (DataGridView)sender;
            for (int i = 0; i < view.Rows.Count; i++)
               if (dataGridView_DriveInfo[e.ColumnIndex, i].ReadOnly == false)
                   dataGridView_DriveInfo[e.ColumnIndex, i].Value = true;
        }

        private void dataGridView_DriveInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var view = (DataGridView)sender;
            for (int i = 0; i < view.Rows.Count; i++)
                if (dataGridView_DriveInfo[e.ColumnIndex, i].ReadOnly == false)
                    dataGridView_DriveInfo[e.ColumnIndex, i].Value = false;
        }
    }
}
