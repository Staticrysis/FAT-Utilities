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
    }
}
