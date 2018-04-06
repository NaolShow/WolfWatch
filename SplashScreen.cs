using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfWatch
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        public SplashScreen()
        {
            InitializeComponent();

            SplashScreenStart();
        }

        private async void SplashScreenStart()
        {
            await Task.Delay(500);
            Form WW = new WolfWatchMetro();

            // Directory
            if (!Directory.Exists(WolfWatchMetro.WWPath))
            {
                Directory.CreateDirectory(WolfWatchMetro.WWPath);
            }
            if (!Directory.Exists(WolfWatchMetro.SettingsPath))
            {
                Directory.CreateDirectory(WolfWatchMetro.SettingsPath);
            }
            if (!Directory.Exists(WolfWatchMetro.PlaylistPath))
            {
                Directory.CreateDirectory(WolfWatchMetro.PlaylistPath);
            }

            // Files
            if (!File.Exists(WolfWatchMetro.SettingFile))
            {
                File.Create(WolfWatchMetro.SettingFile).Dispose();
                File.WriteAllText(WolfWatchMetro.SettingFile, WolfWatchMetro.settingsResources);
            }

            // Files
            #region "Languages files"
            File.Delete(WolfWatchMetro.SettingsPath + "english.lang");
            File.Delete(WolfWatchMetro.SettingsPath + "french.lang");
            File.Delete(WolfWatchMetro.SettingsPath + "german.lang");
            File.Delete(WolfWatchMetro.SettingsPath + "spanish.lang");
            if (!File.Exists(WolfWatchMetro.SettingsPath + "english.lang"))
            {
                File.Create(WolfWatchMetro.SettingsPath + "english.lang").Dispose();
                File.WriteAllText(WolfWatchMetro.SettingsPath + "english.lang", WolfWatchMetro.englishResources);
            }
            if (!File.Exists(WolfWatchMetro.SettingsPath + "french.lang"))
            {
                File.Create(WolfWatchMetro.SettingsPath + "french.lang").Dispose();
                File.WriteAllText(WolfWatchMetro.SettingsPath + "french.lang", WolfWatchMetro.frenchResources);
            }
            if (!File.Exists(WolfWatchMetro.SettingsPath + "german.lang"))
            {
                File.Create(WolfWatchMetro.SettingsPath + "german.lang").Dispose();
                File.WriteAllText(WolfWatchMetro.SettingsPath + "german.lang", WolfWatchMetro.germanResources);
            }
            if (!File.Exists(WolfWatchMetro.SettingsPath + "spanish.lang"))
            {
                File.Create(WolfWatchMetro.SettingsPath + "spanish.lang").Dispose();
                File.WriteAllText(WolfWatchMetro.SettingsPath + "spanish.lang", WolfWatchMetro.spanishResources);
            }

            #endregion

            // Start software
            this.Hide();
            WW.Show();
        }
    }
}
