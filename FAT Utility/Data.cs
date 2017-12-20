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
        static private DriveInfo AllDriveInfo { get; set; }
        static private DriveInfo FilteredDriveInfo { get; set; }
        static public String[]  ExcludedDriveLetters { get; set; } = new String[] { "C", "D" };


        static public IEnumerable<DriveInfo> SelectedDriveInfo(string[] SelectedDrives) 
        {
            DriveInfo[] DI = DriveInfo.GetDrives();
            IEnumerable<DriveInfo> FilteredDI;
            FilteredDI = DI.Where(b => SelectedDrives.Any(y => b.Name.Contains(y.ToUpper())));
            return FilteredDI;
        }
    }
}
