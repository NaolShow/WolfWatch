using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfWatch.Properties;

namespace WolfWatch
{
    public static class Updates
    {

        // Updates files (settings)
        public static void UpdateFiles()
        {
            try
            {
                // Update files
                String ActualSettings = File.ReadAllText(References.SettingsFile);
                File.WriteAllText(References.SettingsFile, Resources.settings);
                WolfLib.Rasu.MergeFile(ActualSettings, References.SettingsFile);

                // Update version
                WolfLib.Rasu.Set(References.SettingsFile, "version", Application.ProductVersion);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Program.mainForm, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check for updates
        public static async void checkForUpdates(bool boolean)
        {
            try
            {
                await Task.Delay(1);
                String version = WolfLib.Web.DownloadString("https://dl.dropboxusercontent.com/s/e9sqmj0k4gtgp4u/version.txt?dl=0");
                if (version != Application.ProductVersion)
                {
                    if (MetroMessageBox.Show(Program.mainForm, Langs.newVersion, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Application.StartupPath + "\\Updater\\Updater.exe");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (boolean == true)
                    {
                        MetroMessageBox.Show(Program.mainForm, Langs.noNewVersion, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(Program.mainForm, Langs.errorConnection, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manual check
        public static void GetManualUpdateCheckButton()
        {
            Updates.checkForUpdates(true);
        }

    }
}
