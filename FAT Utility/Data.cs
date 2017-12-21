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
        static private DriveInfo[] AllDriveInfo { get; set; }
        static private DriveInfo[] FilteredDriveInfo { get; set; }
        static public String[] ExcludedDriveLetters { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveLetters.Split(','); } }
        static public String[] ExcludedDriveTypes { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveTypes.Split(','); } }
        static public String[] ExcludedDriveValumeLabels { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveVolumeLabel.Split(','); } }

        

        static public DriveInfo GetDriveInfo (Char DriveLetter)
        {
            return AllDriveInfo.First(drive => char.ToUpper(drive.Name[0]) == char.ToUpper(DriveLetter));
        }

        static public IEnumerable<DriveInfo> UpdateDriveInfo () 
        {
            FilteredDriveInfo = DriveInfo.GetDrives();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveLetters.Any(ExDrive => Char.ToUpper(drive.ToString()[0]) == Char.ToUpper(ExDrive[0]))).ToArray();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveTypes.Any(ExDrive => drive.DriveType.ToString().ToUpper() == ExDrive.ToUpper())).ToArray();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveValumeLabels.Any(ExDrive => ExDrive == "" ? false : drive.VolumeLabel.ToUpper() == ExDrive.ToUpper())).ToArray();
            return FilteredDriveInfo;
        }
    }
}
