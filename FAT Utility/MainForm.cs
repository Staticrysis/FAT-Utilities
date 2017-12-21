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

        private void toolStripButton_Options_Click(object sender, EventArgs e)
        {

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
            var v = (DataGridView)sender;
            if (v.CurrentRow.DataBoundItem != null)
                bindingSource_SelectedDriveInfo.DataSource = v.CurrentRow.DataBoundItem;
            //Maybe place a progress bar update in this event later. 
        }
    }
}
