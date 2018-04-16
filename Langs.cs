using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfWatch
{
    public static class Langs
    {

        // Lang variables
        public static String playlistExist;
        public static String videoExist;
        public static String selectVideo;
        public static String selectPlaylist;
        public static String deletePlaylist;
        public static String deleteVideo;
        public static String donation;
        public static String newVersion;
        public static String noNewVersion;
        public static String errorConnection;
        public static String deletefiles;
        public static String restartsoftware;
        public static String maxDropDownPlaylists;

        public static String numberplaylists;
        public static String weightplaylists;

        public static bool loadingLang = false;

        public static void refreshLang()
        {
            try
            {
                loadingLang = true;

                String lang;
                int index;

                // Search index
                if (!Int32.TryParse(WolfLib.Rasu.Get(References.SettingsFile, "lang"), out index))
                { WolfLib.Rasu.Set(References.SettingsFile, "lang", "1"); index = 1; }

                // Determine the language
                if (index == 0) { lang = "german"; }
                else if (index == 1) { lang = "english"; }
                else if (index == 2) { lang = "spanish"; }
                else if (index == 3) { lang = "french"; }
                else { lang = "1"; }

                String path = References.SettingsPath + lang + ".lang";

                // Label
                Program.mainForm.playlists_playlistslist.Text = WolfLib.Rasu.Get(path, "playlistslist") + ":";

                Program.mainForm.editplaylist_editplaylist.Text = WolfLib.Rasu.Get(path, "editplaylist") + ":";
                Program.mainForm.editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo") + ":";

                Program.mainForm.addplaylist_addplaylist.Text = WolfLib.Rasu.Get(path, "addplaylist") + ":";

                Program.mainForm.addplaylist_playlistname.WaterMark = WolfLib.Rasu.Get(path, "playlistname");
                Program.mainForm.editplaylist_playlistname.WaterMark = WolfLib.Rasu.Get(path, "playlistname");
                Program.mainForm.editvideo_videoname.WaterMark = WolfLib.Rasu.Get(path, "videoname");
                Program.mainForm.editvideo_videodescription.WaterMark = WolfLib.Rasu.Get(path, "videodescription");

                // Settings
                Program.mainForm.settings_advancedsettings.Text = WolfLib.Rasu.Get(path, "advancedsettings");
                Program.mainForm.settings_generalsettings.Text = WolfLib.Rasu.Get(path, "generalsettings");
                Program.mainForm.settings_videoplayersettings.Text = WolfLib.Rasu.Get(path, "videoplayersettings");
                Program.mainForm.settings_informations.Text = WolfLib.Rasu.Get(path, "informations");

                Program.mainForm.settings_langcombo.Items.Clear();
                Program.mainForm.settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "german"));
                Program.mainForm.settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "english"));
                Program.mainForm.settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "spanish"));
                Program.mainForm.settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "french"));
                Program.mainForm.settings_langcombo.SelectedIndex = index;

                Program.mainForm.settings_sortvideolisttype.Items.Clear();
                Program.mainForm.settings_sortvideolisttype.Items.Add(WolfLib.Rasu.Get(path, "ascending"));
                Program.mainForm.settings_sortvideolisttype.Items.Add(WolfLib.Rasu.Get(path, "descending"));
                Program.mainForm.settings_sortvideolisttype.SelectedIndex = Int32.Parse(WolfLib.Rasu.Get(References.SettingsFile, "sort_videos_list_type"));

                Program.mainForm.settings_lang.Text = WolfLib.Rasu.Get(path, "language");
                Program.mainForm.settings_autoupdates.Text = WolfLib.Rasu.Get(path, "autoupdates");
                Program.mainForm.settings_manualupdatecheck.Text = WolfLib.Rasu.Get(path, "manualupdatecheck");

                Program.mainForm.settings_stretchtofit.Text = WolfLib.Rasu.Get(path, "stretchtofit");
                Program.mainForm.settings_sortvideolist.Text = WolfLib.Rasu.Get(path, "sortvideoslist");
                maxDropDownPlaylists = WolfLib.Rasu.Get(path, "maxdropdownplaylists");
                Program.mainForm.settings_maxdropdownplaylists.Text = maxDropDownPlaylists + " (" + int.Parse(WolfLib.Rasu.Get(References.SettingsFile, "max_dropdown_playlists")) + ")";

                Program.mainForm.settings_showfiles.Text = WolfLib.Rasu.Get(path, "showfiles");
                Program.mainForm.settings_resetfiles.Text = WolfLib.Rasu.Get(path, "resetfiles");

                numberplaylists = WolfLib.Rasu.Get(path, "numberplaylists");
                Program.mainForm.settings_numberofplaylists.Text = numberplaylists + ": " + Directory.GetDirectories(References.PlaylistsPath).Count();
                weightplaylists = WolfLib.Rasu.Get(path, "weightplaylists");
                Program.mainForm.settings_weightofplaylists.Text = weightplaylists + ": " + Directory.GetFiles(References.PlaylistsPath, "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length) / 1024 / 1024) + "Mo";

                // Buttons
                Program.mainForm.addplaylist_addplaylistbutton.Text = WolfLib.Rasu.Get(path, "addplaylist");
                Program.mainForm.editplaylist_editplaylistbutton.Text = WolfLib.Rasu.Get(path, "editplaylist");
                Program.mainForm.editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo");
                Program.mainForm.addplaylist_cancel.Text = WolfLib.Rasu.Get(path, "cancel");
                Program.mainForm.editplaylist_cancel.Text = WolfLib.Rasu.Get(path, "cancel");
                Program.mainForm.editvideo_cancel.Text = WolfLib.Rasu.Get(path, "cancel");

                // Tab pages
                Program.mainForm.tabAddPlaylist.Text = WolfLib.Rasu.Get(path, "addplaylist");
                Program.mainForm.tabEditPlaylist.Text = WolfLib.Rasu.Get(path, "editplaylist");
                Program.mainForm.tabPlaylists.Text = WolfLib.Rasu.Get(path, "playlists");
                Program.mainForm.tabSettings.Text = WolfLib.Rasu.Get(path, "settings");

                // Variables
                playlistExist = WolfLib.Rasu.Get(path, "playlistexist");
                videoExist = WolfLib.Rasu.Get(path, "videoexist");
                selectVideo = WolfLib.Rasu.Get(path, "selectvideo");
                selectPlaylist = WolfLib.Rasu.Get(path, "selectplaylist");
                deletePlaylist = WolfLib.Rasu.Get(path, "deleteplaylist");
                deleteVideo = WolfLib.Rasu.Get(path, "deletevideo");
                donation = WolfLib.Rasu.Get(path, "donation");
                newVersion = WolfLib.Rasu.Get(path, "newversion");
                noNewVersion = WolfLib.Rasu.Get(path, "nonewversion");
                errorConnection = WolfLib.Rasu.Get(path, "errorconnection");
                deletefiles = WolfLib.Rasu.Get(path, "deletefiles");
                restartsoftware = WolfLib.Rasu.Get(path, "restartsoftware");

                // Playlist list view
                Program.mainForm.fileName.Text = WolfLib.Rasu.Get(path, "filename");
                Program.mainForm.fileDescription.Text = WolfLib.Rasu.Get(path, "filedescription");
                Program.mainForm.fileDuration.Text = WolfLib.Rasu.Get(path, "fileduration");

                // Context menu
                Program.mainForm.addPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "addplaylist");
                Program.mainForm.removePlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "removeplaylist");
                Program.mainForm.editPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "editplaylist");
                Program.mainForm.exportPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "exportplaylist");

                Program.mainForm.playVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "playvideo");
                Program.mainForm.addVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "addvideo");
                Program.mainForm.removeVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "removevideo");
                Program.mainForm.editVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "editvideo");
                Program.mainForm.exportVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "exportvideo");

                loadingLang = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Program.mainForm, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
