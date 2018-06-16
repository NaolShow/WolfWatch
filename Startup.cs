using System.IO;
using WolfWatch.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;

namespace WolfWatch
{
    public static class Startup
    {

        public static void Setup()
        {
            // Verification of the process
            String thisprocessname = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            if (System.Diagnostics.Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                MetroMessageBox.Show(Program.splashForm, "You can't open the application twice at the same time!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            // Initialize RSettings
            Reference.RSettings = new WolfLib.Rasu(Reference.SettingsFile);

            // Initialize folders
            Folders();
            // Iniatilize files
            Files();

            // Update files
            Updates.UpdateFiles();

            // Set WolfWatchMetro
            Program.mainForm = new WolfWatchMetro();

            // Style manager
            Program.mainForm.StyleManager = Program.mainForm.metroStyleManager;

            // Load/Set settings
            Settings.LoadSettings();
            Settings.SetSettings();
            Program.mainForm.refreshPlaylistsList();

            // Show mainForm
            Program.mainForm.Show();
            Program.splashForm.Hide();
            
        }

        private static void Folders()
        {

            if (!Directory.Exists(Reference.MainPath))
            {
                Directory.CreateDirectory(Reference.MainPath);
            }
            if (!Directory.Exists(Reference.SettingsPath))
            {
                Directory.CreateDirectory(Reference.SettingsPath);
            }
            if (!Directory.Exists(Reference.PlaylistsPath))
            {
                Directory.CreateDirectory(Reference.PlaylistsPath);
            }

        }

        private static void Files()
        {
            if (!File.Exists(Reference.SettingsFile))
            {
                File.Create(Reference.SettingsFile).Dispose();
                File.WriteAllText(Reference.SettingsFile, Resources.settings);
            }

            // Delete previous lang files
            if (File.Exists(Reference.SettingsPath + "english.lang")) { File.Delete(Reference.SettingsPath + "english.lang"); }
            if (File.Exists(Reference.SettingsPath + "french.lang")) { File.Delete(Reference.SettingsPath + "french.lang"); }
            if (File.Exists(Reference.SettingsPath + "german.lang")) { File.Delete(Reference.SettingsPath + "german.lang"); }
            if (File.Exists(Reference.SettingsPath + "spanish.lang")) { File.Delete(Reference.SettingsPath + "spanish.lang"); }

            File.WriteAllText(Reference.SettingsPath + "English.lang", Resources.english);
            File.WriteAllText(Reference.SettingsPath + "Français.lang", Resources.french);
            File.WriteAllText(Reference.SettingsPath + "Deutsch.lang", Resources.german);
            File.WriteAllText(Reference.SettingsPath + "Español.lang", Resources.spanish);
            File.WriteAllText(Reference.SettingsPath + "Italiano.lang", Resources.italian);
        }

    }
}
