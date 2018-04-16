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

namespace WolfWatch
{
    public static class Startup
    {

        public static void Start()
        {
            // Verification of the process
            String thisprocessname = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            if (System.Diagnostics.Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                MetroMessageBox.Show(Program.splashForm, "You can't open the application twice at the same time!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

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

            if (!Directory.Exists(References.MainPath))
            {
                Directory.CreateDirectory(References.MainPath);
            }
            if (!Directory.Exists(References.SettingsPath))
            {
                Directory.CreateDirectory(References.SettingsPath);
            }
            if (!Directory.Exists(References.PlaylistsPath))
            {
                Directory.CreateDirectory(References.PlaylistsPath);
            }

        }

        private static void Files()
        {
            if (!File.Exists(References.SettingsFile))
            {
                File.Create(References.SettingsFile).Dispose();
                File.WriteAllText(References.SettingsFile, Resources.settings);
            }
            if (!File.Exists(References.SettingsPath + "english.lang"))
            {
                File.Create(References.SettingsPath + "english.lang").Dispose();
            }
            if (!File.Exists(References.SettingsPath + "french.lang"))
            {
                File.Create(References.SettingsPath + "french.lang").Dispose();
            }
            if (!File.Exists(References.SettingsPath + "german.lang"))
            {
                File.Create(References.SettingsPath + "german.lang").Dispose();
            }
            if (!File.Exists(References.SettingsPath + "spanish.lang"))
            {
                File.Create(References.SettingsPath + "spanish.lang").Dispose();

            }

            File.WriteAllText(References.SettingsPath + "english.lang", Resources.english);
            File.WriteAllText(References.SettingsPath + "french.lang", Resources.french);
            File.WriteAllText(References.SettingsPath + "german.lang", Resources.german);
            File.WriteAllText(References.SettingsPath + "spanish.lang", Resources.spanish);
        }

    }
}
