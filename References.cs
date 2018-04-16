using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfWatch.Properties;

namespace WolfWatch
{
    public static class References
    {
        public static String MainPath = Application.StartupPath + "\\";
        public static String PlaylistsPath = MainPath + "Playlists\\";
        public static String SettingsPath = MainPath + "Settings\\";
        public static String SettingsFile = SettingsPath + "settings.settings";
    }
}
