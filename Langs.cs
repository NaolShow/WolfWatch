using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfLib;

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

        public static String open;

        public static bool loadingLang = false;

        public static void refreshLang()
        {
            try
            {
                loadingLang = true;

                // Put langs into combo box
                Program.mainForm.settings_langcombo.Items.Clear();
                foreach (String langFile in Directory.GetFiles(Reference.SettingsPath, "*.lang", SearchOption.TopDirectoryOnly))
                {
                    Program.mainForm.settings_langcombo.Items.Add(Path.GetFileNameWithoutExtension(langFile));
                }

                if (!File.Exists(Reference.SettingsPath + Reference.RSettings.Get("lang") + ".lang"))
                {
                    Reference.RSettings.Set("lang", "english");
                }

                Program.mainForm.settings_langcombo.SelectedIndex = Program.mainForm.settings_langcombo.FindStringExact(Reference.RSettings.Get("lang"));
                Rasu Lang = new Rasu(Reference.SettingsPath + Reference.RSettings.Get("lang") + ".lang");

                // Label
                Program.mainForm.playlists_playlistslist.Text = Lang.Get("playlistslist") + ":";

                Program.mainForm.editplaylist_editplaylist.Text = Lang.Get("editplaylist") + ":";
                Program.mainForm.editvideo_editvideobutton.Text = Lang.Get("editvideo") + ":";

                Program.mainForm.addplaylist_addplaylist.Text = Lang.Get("addplaylist") + ":";

                Program.mainForm.addplaylist_playlistname.WaterMark = Lang.Get("playlistname");
                Program.mainForm.editplaylist_playlistname.WaterMark = Lang.Get("playlistname");
                Program.mainForm.editvideo_videoname.WaterMark = Lang.Get("videoname");
                Program.mainForm.editvideo_videodescription.WaterMark = Lang.Get("videodescription");

                // Settings
                Program.mainForm.settings_advancedsettings.Text = Lang.Get("advancedsettings");
                Program.mainForm.settings_generalsettings.Text = Lang.Get("generalsettings");
                Program.mainForm.settings_videoplayersettings.Text = Lang.Get("videoplayersettings");
                Program.mainForm.settings_informations.Text = Lang.Get("informations");

                Program.mainForm.settings_sortvideolisttype.Items.Clear();
                Program.mainForm.settings_sortvideolisttype.Items.Add(Lang.Get("ascending"));
                Program.mainForm.settings_sortvideolisttype.Items.Add(Lang.Get("descending"));
                Program.mainForm.settings_sortvideolisttype.SelectedIndex = Int32.Parse(Reference.RSettings.Get("sort_videos_list_type"));

                Program.mainForm.settings_lang.Text = Lang.Get("language");
                Program.mainForm.settings_autoupdates.Text = Lang.Get("autoupdates");
                Program.mainForm.settings_manualupdatecheck.Text = Lang.Get("manualupdatecheck");

                Program.mainForm.settings_stretchtofit.Text = Lang.Get("stretchtofit");
                Program.mainForm.settings_sortvideolist.Text = Lang.Get("sortvideoslist");
                maxDropDownPlaylists = Lang.Get("maxdropdownplaylists");
                Program.mainForm.settings_maxdropdownplaylists.Text = maxDropDownPlaylists + " (" + int.Parse(Reference.RSettings.Get("max_dropdown_playlists")) + ")";

                Program.mainForm.settings_showfiles.Text = Lang.Get("showfiles");
                Program.mainForm.settings_resetfiles.Text = Lang.Get("resetfiles");

                numberplaylists = Lang.Get("numberplaylists");
                Program.mainForm.settings_numberofplaylists.Text = numberplaylists + ": " + Directory.GetDirectories(Reference.PlaylistsPath).Count();
                weightplaylists = Lang.Get("weightplaylists");
                Program.mainForm.settings_weightofplaylists.Text = weightplaylists + ": " + Settings.GetPlaylistsSize();

                // Buttons
                Program.mainForm.addplaylist_addplaylistbutton.Text = Lang.Get("addplaylist");
                Program.mainForm.editplaylist_editplaylistbutton.Text = Lang.Get("editplaylist");
                Program.mainForm.editvideo_editvideobutton.Text = Lang.Get("editvideo");
                Program.mainForm.addplaylist_cancel.Text = Lang.Get("cancel");
                Program.mainForm.editplaylist_cancel.Text = Lang.Get("cancel");
                Program.mainForm.editvideo_cancel.Text = Lang.Get("cancel");

                // Tab pages
                Program.mainForm.tabAddPlaylist.Text = Lang.Get("addplaylist");
                Program.mainForm.tabEditPlaylist.Text = Lang.Get("editplaylist");
                Program.mainForm.tabPlaylists.Text = Lang.Get("playlists");
                Program.mainForm.tabSettings.Text = Lang.Get("settings");

                // Variables
                playlistExist = Lang.Get("playlistexist");
                videoExist = Lang.Get("videoexist");
                selectVideo = Lang.Get("selectvideo");
                selectPlaylist = Lang.Get("selectplaylist");
                deletePlaylist = Lang.Get("deleteplaylist");
                deleteVideo = Lang.Get("deletevideo");
                donation = Lang.Get("donation");
                newVersion = Lang.Get("newversion");
                noNewVersion = Lang.Get("nonewversion");
                errorConnection = Lang.Get("errorconnection");
                deletefiles = Lang.Get("deletefiles");
                restartsoftware = Lang.Get("restartsoftware");
                open = Lang.Get("open");

                // Playlist list view
                Program.mainForm.fileName.Text = Lang.Get("filename");
                Program.mainForm.fileDescription.Text = Lang.Get("filedescription");
                Program.mainForm.fileDuration.Text = Lang.Get("fileduration");

                // Context menu
                Program.mainForm.addPlaylistToolStripMenuItem.Text = Lang.Get("addplaylist");
                Program.mainForm.removePlaylistToolStripMenuItem.Text = Lang.Get("removeplaylist");
                Program.mainForm.editPlaylistToolStripMenuItem.Text = Lang.Get("editplaylist");
                Program.mainForm.exportPlaylistToolStripMenuItem.Text = Lang.Get("exportplaylist");

                Program.mainForm.playVideoToolStripMenuItem.Text = Lang.Get("playvideo");
                Program.mainForm.addVideoToolStripMenuItem.Text = Lang.Get("addvideo");
                Program.mainForm.removeVideoToolStripMenuItem.Text = Lang.Get("removevideo");
                Program.mainForm.editVideoToolStripMenuItem.Text = Lang.Get("editvideo");
                Program.mainForm.exportVideoToolStripMenuItem.Text = Lang.Get("exportvideo");

                loadingLang = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Program.mainForm, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
