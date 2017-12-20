using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAT_Utility
{
    class Data
    {
        public DriveInfo DriveInfo { get; set; } = null;
        public String[] ExcludedDriveLetters { get; set; } = new String[] { "C", "D" };


        static public IEnumerable<DriveInfo> SelectedDriveInfo(string[] SelectedDrives) 
        {
            DriveInfo[] DI = DriveInfo.GetDrives();
            IEnumerable<DriveInfo> FilteredDI;
            FilteredDI = DI.Where(b => SelectedDrives.Any(y => b.Name.Contains(y.ToUpper())));
            return FilteredDI;
        }
    }
}
