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
        public MainForm()
        {
            InitializeComponent();
            toolStripButton_RefreshDrives_Click(null, null);
        }

        public void InitializeMainForm()
        {
            
        }

        private void toolStripButton_Options_Click(object sender, EventArgs e)
        {
            Data.Testing();
        }

        private void toolStripButton_RunAll_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_StressTest_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_MountImage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_BitLock_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_CreateImage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_RefreshDrives_Click(object sender, EventArgs e)
        {
            bindingSource_MultiDriveInfo.DataSource = Data.UpdateDriveInfo();
        }

        private void dataGridView_DriveInfo_Click(object sender, EventArgs e)
        {
            var view = (DataGridView)sender;
            if (view.CurrentRow != null)
                bindingSource_SelectedDriveInfo.DataSource = view.CurrentRow.DataBoundItem;
            
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
