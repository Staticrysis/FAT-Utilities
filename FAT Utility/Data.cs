using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscUtils;
using DiskClone;
using DiscUtils.Common;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace FAT_Utility
{
    static class Data
    {
        
        static private DriveInfo[] AllDriveInfo { get; set; }
        static private DriveInfo[] FilteredDriveInfo { get; set; }
        static private EnhancedDriveInfo[] EnhancedDriveInfo { get; set; }
        static public String[] ExcludedDriveLetters { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveLetters.Split(','); } }
        static public String[] ExcludedDriveTypes { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveTypes.Split(','); } }
        static public String[] ExcludedDriveValumeLabels { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveVolumeLabel.Split(','); } }
        static public String[] ExcludedDriveFormat { get { return FAT_Utility.Properties.Settings.Default.ExcludedDriveFormat.Split(','); } }

        static public void StressTest(List<DriveInfo> DIs)
        {
            
        }

        static public void MountImage(List<DriveInfo> DIs)
        {
            
            
        }

        static public void BitLock(List<DriveInfo> DIs)
        {

            foreach (DriveInfo DI in DIs)
            {
                string script =
                    "$SecureString = ConvertTo - SecureString " + FAT_Utility.Properties.Settings.Default.BitlockerPassword + " - AsPlainText - Force"
                    + "Enable - BitLocker - MountPoint " + DI.RootDirectory.ToString()[0] + ": - EncryptionMethod Aes256 –UsedSpaceOnly - Pin $SecureString - TPMandPinProtector";
            }


        }

        static public void CreateImage(List<DriveInfo> DIs)
        {
            // DiscUtils.Dmg.Disk.CreateDisk();
        }


        static public void PSScriptService(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Get-Process");
            var results = pipeline.Invoke();
            runspace.Close();

            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (PSObject obj in results)
            //{
            //    stringBuilder.AppendLine(obj.ToString());
            //}
            //
            //System.Windows.Forms.MessageBox.Show(stringBuilder.ToString());
        }

        static public DriveInfo GetDriveInfo (Char DriveLetter)
        {
            return AllDriveInfo.First(drive => char.ToUpper(drive.Name[0]) == char.ToUpper(DriveLetter));
        }

        static public IEnumerable<DriveInfo> UpdateDriveInfo () 
        {
            FilteredDriveInfo = DriveInfo.GetDrives();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveLetters.Any(ExDrive => ExDrive != "" ? Char.ToUpper(drive.ToString()[0]) == Char.ToUpper(ExDrive[0]) : false)).ToArray();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveTypes.Any(ExDrive => drive.DriveType.ToString().ToUpper() == ExDrive.ToUpper())).ToArray();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveFormat.Any(ExDrive => ExDrive.ToUpper() == drive.DriveFormat.ToUpper())).ToArray();
            FilteredDriveInfo = FilteredDriveInfo.Where(drive => !ExcludedDriveValumeLabels.Any(ExDrive => ExDrive == "" ? false : drive.VolumeLabel.ToUpper() == ExDrive.ToUpper())).ToArray();
            FilteredDriveInfo = FilteredDriveInfo;
            EnhancedDriveInfo = new EnhancedDriveInfo[FilteredDriveInfo.Count()];
            for (int i  = 0; i < EnhancedDriveInfo.Length; i++)
            {
                EnhancedDriveInfo[i] = new EnhancedDriveInfo(FilteredDriveInfo[i]);
            }
            return FilteredDriveInfo;
        }
    }

    class EnhancedDriveInfo
    {
        public EnhancedDriveInfo() { }

        public EnhancedDriveInfo(DriveInfo DI)
        {
            DriveInfo = DI;
            Letter = DI.RootDirectory.ToString()[0];
        }

        public DriveInfo DriveInfo;
        public char Letter;

        public string BitLockerMount = null;
        public string BitLockerPin = null;
    }

    class SettingsData
    {

        //Stress Test
        //Mount Drive
        //Bitlocker settings 
        public string MountPoint = "";
        public string PIN = "L.123";
        public string RecoveryKeyPath = "C://";
        //Create Image

        static public void Save()
        {

        }

        static public void Load()
        {

        }
    }
}
