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

            //listView_DriveInfo. = DriveInfo.GetDrives();
            bindingSource_DriveInfo.DataSource = DriveInfo.GetDrives();
            
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
            bindingSource_DriveInfo.DataSource = Data.SelectedDriveInfo(Data.ExcludedDriveLetters);
        }
    }
}
