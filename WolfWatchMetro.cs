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
using WolfWatch.Properties;

namespace WolfWatch
{
    public partial class WolfWatchMetro : MetroFramework.Forms.MetroForm
    {
        public WolfWatchMetro()
        {
            InitializeComponent();

            startWolfWatch();
        }

        // Variables
        public static String WWPath = Application.StartupPath + "\\";
        public static String PlaylistPath = WWPath + "Playlists\\";
        public static String SettingsPath = WWPath + "Settings\\";
        public static String SettingFile = SettingsPath + "settings.settings";

        public static String WolfWatchVersion = Application.ProductVersion;

        // Resources
        public static String settingsResources = Resources.settings;
        public static String englishResources = Resources.english;
        public static String frenchResources = Resources.french;
        public static String germanResources = Resources.german;
        public static String spanishResources = Resources.spanish;

        public async void startWolfWatch()
        {
            // Hide tab pages
            WWTabControl.TabPages.Remove(tabAddPlaylist);
            WWTabControl.TabPages.Remove(tabEditPlaylist);
            WWTabControl.TabPages.Remove(tabEditVideo);

            WWTabControl.SelectedTab = tabPlayer;

            await Task.Delay(1);

            // Set window
            this.Text = "WolfWatch v" + WolfWatchVersion;
            // Set up players
            WMP.uiMode = "full";
            WMP.enableContextMenu = true;

            // Playlists
            setPlaylistsList();

            // Load settings to software
            applySettings();

            // Check for updates
            checkForUpdates();

            // Show front
            this.BringToFront();
        }

        /**
          * 
          * 
          *  CHECK FOR UPDATES
          * 
          * 
          **/

        #region "Check for updates"

        // Check for updates
        public async static void checkForUpdates()
        {
            await Task.Delay(1);
            if (WolfLib.Rasu.Get(SettingFile, "autoupdates") == "true")
            {
                String version = WolfLib.Web.DownloadString("https://dl.dropboxusercontent.com/s/e9sqmj0k4gtgp4u/version.txt?dl=0");
                if (version != WolfWatchVersion)
                {
                    MessageBox.Show(newVersion, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("http://towolf.livehost.fr/");
                }
            }
        }

        #endregion

        /**
          * 
          * 
          *  SET UP LANGUAGE
          * 
          * 
          **/
        #region "Set up language"

        // Lang variables
        public static String playlistExist;
        public static String videoExist;
        public static String selectVideo;
        public static String selectPlaylist;
        public static String deletePlaylist;
        public static String deleteVideo;
        public static String donation;
        public static String newVersion;

        public void setLang(String lang)
        {
            try
            {
                String path = SettingsPath + lang + ".lang";

                // Label
                playlists_playlistslist.Text = WolfLib.Rasu.Get(path, "playlistslist") + ":";
                //settings_weightofplaylists.Text = WolfLib.Rasu.Get(path, "weightofplaylists") + ":";

                editplaylist_editplaylist.Text = WolfLib.Rasu.Get(path, "editplaylist") + ":";
                editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo") + ":";

                addplaylist_addplaylist.Text = WolfLib.Rasu.Get(path, "addplaylist") + ":";
                addplaylist_playlistname.Text = WolfLib.Rasu.Get(path, "playlistname");

                // Group box
                settings_generalsettingsgroupbox.Text = WolfLib.Rasu.Get(path, "generalsettings");
                settings_langgroupbox.Text = WolfLib.Rasu.Get(path, "language");
                settings_autoupdatesgroupbox.Text = WolfLib.Rasu.Get(path, "autoupdates");
                settings_videoplayersettingsgroupbox.Text = WolfLib.Rasu.Get(path, "videoplayersettings");
                settings_stretchtofitgroupbox.Text = WolfLib.Rasu.Get(path, "stretchtofit");
                settings_sortvideoslistgroupbox.Text = WolfLib.Rasu.Get(path, "sortvideoslist");
                //settings_informations.Text = WolfLib.Rasu.Get(path, "informations");

                // Buttons
                addplaylist_addplaylistbutton.Text = WolfLib.Rasu.Get(path, "addplaylist");
                editplaylist_editplaylistbutton.Text = WolfLib.Rasu.Get(path, "editplaylist");
                editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo");
                settings_showfiles.Text = WolfLib.Rasu.Get(path, "showfiles");

                // Tab pages
                tabAddPlaylist.Text = WolfLib.Rasu.Get(path, "addplaylist");
                tabEditPlaylist.Text = WolfLib.Rasu.Get(path, "editplaylist");
                tabPlaylists.Text = WolfLib.Rasu.Get(path, "playlists");
                tabSettings.Text = WolfLib.Rasu.Get(path, "settings");

                // Variables
                playlistExist = WolfLib.Rasu.Get(path, "playlistexist");
                videoExist = WolfLib.Rasu.Get(path, "videoexist");
                selectVideo = WolfLib.Rasu.Get(path, "selectvideo");
                selectPlaylist = WolfLib.Rasu.Get(path, "selectplaylist");
                deletePlaylist = WolfLib.Rasu.Get(path, "deleteplaylist");
                deleteVideo = WolfLib.Rasu.Get(path, "deletevideo");
                donation = WolfLib.Rasu.Get(path, "donation");
                newVersion = WolfLib.Rasu.Get(path, "newversion");

                // Context menu
                addPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "addplaylist");
                removePlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "removeplaylist");
                editPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "editplaylist");
                exportPlaylistToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "exportplaylist");

                playVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "playvideo");
                addVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "addvideo");
                removeVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "removevideo");
                editVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "editvideo");
                exportVideoToolStripMenuItem.Text = WolfLib.Rasu.Get(path, "exportvideo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        #endregion

        /**
          * 
          * 
          *  SET UP PLAYLIST/LIST
          * 
          * 
          **/

        #region "Set up playlist/list"
        // Set playlists name into the combo box
        public void setPlaylistsList()
        {
            try
            {
                playlistsList.Items.Clear();
                foreach (String playlistName in Directory.GetDirectories(PlaylistPath))
                {
                    playlistsList.Items.Add(Path.GetFileName(playlistName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        #endregion

        /**
          * 
          * 
          *  CONTEXT MENU STRIP
          * 
          * 
          **/

        #region "SHOW context menu strip"
        // Playlist context menu strip
        private void playlistsMenu_Click(object sender, EventArgs e)
        {
            playlistContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        public void inPlaylistList_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                inPlaylistList.SelectedIndex = inPlaylistList.IndexFromPoint(e.Location);
                if (e.Button == MouseButtons.Right)
                {
                    listContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        #endregion

        /**
          * 
          * 
          *  PLAYLISTS
          * 
          * 
          **/

        #region "Select playlist (Video loading list)"
        private void refreshVideoList()
        {
            try
            {
                inPlaylistList.Items.Clear();

                foreach (String path in Directory.GetFiles(PlaylistPath + playlistsList.Text))
                {
                    String ext = Path.GetExtension(path);
                    if (Path.GetExtension(path) != ".info" && (Path.GetExtension(path) != ".playinfo"))
                    {
                        inPlaylistList.Items.Add(Path.GetFileNameWithoutExtension(path));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void playlistsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshVideoList();
        }

        #endregion
        #region "Add playlist"

        // Apply add
        private void addplaylist_addplaylistbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(PlaylistPath + addplaylist_playlistname.Text))
                {
                    // Create playlist
                    Directory.CreateDirectory(PlaylistPath + addplaylist_playlistname.Text);
                    File.Create(PlaylistPath + addplaylist_playlistname.Text + "\\playlist.playinfo").Dispose();
                    File.WriteAllText(PlaylistPath + addplaylist_playlistname.Text + "\\playlist.playinfo", Resources.playlist);

                    // Exit
                    WWTabControl.TabPages.Remove(tabAddPlaylist);
                    setPlaylistsList();
                }
                else
                {
                    MessageBox.Show(playlistExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        // Add playlist
        private void addPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabAddPlaylist);
            WWTabControl.SelectTab(tabAddPlaylist);
        }

        #endregion
        #region "Remove playlist"

        // Remove playlist
        private void removePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (MessageBox.Show(deletePlaylist, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WMP.URL = "";
                        Directory.Delete(PlaylistPath + playlistsList.Text, true);
                        setPlaylistsList();
                        refreshVideoList();
                    }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        #endregion
        #region "Export playlist"

        private void exportPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (String path in Directory.GetFiles(PlaylistPath + playlistsList.Text, "*.info", SearchOption.TopDirectoryOnly))
                        {
                            exportVideo(Path.GetFileNameWithoutExtension(path), folderBrowserDialog.SelectedPath + "\\" + Path.GetFileNameWithoutExtension(path) + WolfLib.Rasu.Get(path, "video_extension"));
                        }
                    }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        #endregion
        #region "Edit playlist"

        // Edit playlist
        private void editPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabEditPlaylist);
                    WWTabControl.SelectTab(tabEditPlaylist);
                    WMP.URL = "";
                    editplaylist_playlistname.Text = playlistsList.Text;
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        // Apply edit
        private void editplaylist_editplaylistbutton_Click(object sender, EventArgs e)
        {
            if (editplaylist_playlistname.Text != playlistsList.Text) { Directory.Move(PlaylistPath + playlistsList.Text, PlaylistPath + editplaylist_playlistname.Text); }
            WWTabControl.TabPages.Remove(tabEditPlaylist);
            setPlaylistsList();
        }

        #endregion

        /**
          * 
          * 
          *  VIDEOS
          * 
          * 
          **/

        #region "Play video"

        // Play video function
        public void playVideo(String videoName)
        {
            try
            {
                if (inPlaylistList.GetItemText(inPlaylistList.SelectedItem) != "")
                {
                    WMP.URL = PlaylistPath + playlistsList.Text + "\\" + videoName + WolfLib.Rasu.Get(PlaylistPath + playlistsList.Text + "\\" + videoName + ".info", "video_extension");
                }
                else
                {
                    MessageBox.Show(selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        // Play video when double click on the name
        private void inPlaylistList_DoubleClick(object sender, EventArgs e)
        {
            playVideo(inPlaylistList.GetItemText(inPlaylistList.SelectedItem));
        }

        // Play video with context menu button
        private void playVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playVideo(inPlaylistList.GetItemText(inPlaylistList.SelectedItem));
        }

        #endregion
        #region "Add video"

        private void addVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        String SelectedPlaylistPath = PlaylistPath + playlistsList.Text + "\\";
                        if (!File.Exists(SelectedPlaylistPath + Path.GetFileName(openFileDialog.FileName)))
                        {
                            // Copy video
                            File.Copy(openFileDialog.FileName, SelectedPlaylistPath + Path.GetFileName(openFileDialog.FileName));
                            File.Create(SelectedPlaylistPath + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".info").Dispose();

                            // Create info file
                            File.WriteAllText(SelectedPlaylistPath + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".info", Resources.video);

                            // Set up video info file
                            WolfLib.Rasu.Set(SelectedPlaylistPath + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".info", "video_extension", Path.GetExtension(openFileDialog.FileName));
                            WolfLib.Rasu.Set(SelectedPlaylistPath + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".info", "video_file_version", WolfWatchVersion);

                            refreshVideoList();
                        }
                        else { MessageBox.Show(videoExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        #endregion        
        #region "Remove video"

        private void removeVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (inPlaylistList.GetItemText(inPlaylistList.SelectedItem) != "")
                    {
                        if (MessageBox.Show(deleteVideo, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            WMP.URL = "";
                            String SelectedVideoPath = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem);
                            File.Delete(SelectedVideoPath + WolfLib.Rasu.Get(SelectedVideoPath + ".info", "video_extension"));
                            File.Delete(SelectedVideoPath + ".info");
                            refreshVideoList();
                        }
                    }
                    else { MessageBox.Show(selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        #endregion
        #region "Edit video"

        private void editVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (inPlaylistList.GetItemText(inPlaylistList.SelectedItem) != "")
                    {
                        WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabEditVideo);
                        WWTabControl.SelectTab(tabEditVideo);
                        WMP.URL = "";
                        editvideo_videoname.Text = inPlaylistList.GetItemText(inPlaylistList.SelectedItem);
                    }
                    else { MessageBox.Show(selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        // Apply edit
        private void editvideo_editvideobutton_Click(object sender, EventArgs e)
        {
            String VideoInformations = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + ".info";
            String Video = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + WolfLib.Rasu.Get(VideoInformations, "video_extension");
            if (editvideo_videoname.Text != inPlaylistList.GetItemText(inPlaylistList.SelectedItem))
            {
                File.Move(Video, PlaylistPath + playlistsList.Text + "\\" + editvideo_videoname.Text + WolfLib.Rasu.Get(VideoInformations, "video_extension"));
                File.Move(VideoInformations, PlaylistPath + playlistsList.Text + "\\" + editvideo_videoname.Text + ".info");
            }
            WWTabControl.TabPages.Remove(tabEditVideo);
            refreshVideoList();
        }

        #endregion
        #region "Export video"

        private void exportVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (playlistsList.Text != "")
                {
                    if (inPlaylistList.GetItemText(inPlaylistList.SelectedItem) != "")
                    {
                        String VideoExtension = WolfLib.Rasu.Get(PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + ".info", "video_extension");
                        saveFileDialog.FileName = inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + VideoExtension;
                        saveFileDialog.Filter = "File|*" + VideoExtension;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) { exportVideo(inPlaylistList.GetItemText(inPlaylistList.SelectedItem), saveFileDialog.FileName); }
                    }
                    else { MessageBox.Show(selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show(selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void exportVideo(String videoName, String outputFile)
        {
            String VideoExtension = WolfLib.Rasu.Get(PlaylistPath + playlistsList.Text + "\\" + videoName + ".info", "video_extension");
            File.Copy(PlaylistPath + playlistsList.Text + "\\" + videoName + VideoExtension, outputFile);
        }

        #endregion

        /**
          * 
          * 
          *  SETTINGS
          * 
          * 
          **/

        #region "Set settings"

        private void applySettings()
        {
            langApplySettings();
            stretchToFitApplySettings();
            sortVideosListFitApplySettings();
        }

        private void loadSettings()
        {
            setRadioButtonLang();
            setRadioButtonAutoUpdates();
            setRadioButtonStretchToFit();
            setRadioButtonSortVideosList();
        }

        #endregion

        #region "Lang"

        // Set default checked
        private void setRadioButtonLang()
        {
            String lang = WolfLib.Rasu.Get(SettingFile, "lang");
            if (lang == "english") { settings_english.Checked = true; }
            else if (lang == "french") { settings_french.Checked = true; }
            else if (lang == "german") { settings_german.Checked = true; }
            else if (lang == "spanish") { settings_spanish.Checked = true; }
        }

        // Apply settings
        private void langApplySettings()
        {
            setLang(WolfLib.Rasu.Get(SettingFile, "lang"));
        }

        // Change language
        private void settings_english_CheckedChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingFile, "lang", "english");
            applySettings();
        }

        private void settings_french_CheckedChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingFile, "lang", "french");
            applySettings();
        }

        private void settings_german_CheckedChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingFile, "lang", "german");
            applySettings();
        }

        private void settings_spanish_CheckedChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingFile, "lang", "spanish");
            applySettings();
        }

        #endregion
        #region "Auto updates"

        // Set default checked
        private void setRadioButtonAutoUpdates()
        {
            if (WolfLib.Rasu.Get(SettingFile, "autoupdates") == "true") { settings_autoupdates_switch.Checked = true; }
            else { settings_autoupdates_switch.Checked = false; }
        }

        private void settings_autoupdates_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_autoupdates_switch.Checked == true)
            { WolfLib.Rasu.Set(SettingFile, "autoupdates", "true"); }
            else { WolfLib.Rasu.Set(SettingFile, "autoupdates", "false"); }
            applySettings();
        }

        #endregion

        #region "Informations"

        // Donations
        private void settings_bitcoin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(donation.Replace("{type}", "Bitcoin"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText("19NSXHZN19FnTArLKydzV2acwzBqpk6nNL");
        }

        private void settings_ether_Click(object sender, EventArgs e)
        {
            MessageBox.Show(donation.Replace("{type}", "Ether"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText("0x5A24cF7a980165642abD9f65D9411DdA0bdb52db");
        }

        #endregion
        #region "Advanced buttons"

        private void settings_showfiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(WWPath);
        }

        #endregion

        #region "Sort videos list"

        // Set default checked
        private void setRadioButtonSortVideosList()
        {
            if (WolfLib.Rasu.Get(SettingFile, "sort_videos_list") == "true") { settings_sortvideoslist_switch.Checked = true; }
            else { settings_sortvideoslist_switch.Checked = false; }
        }

        // Apply settings
        private void sortVideosListFitApplySettings()
        {
            if (WolfLib.Rasu.Get(SettingFile, "sort_videos_list") == "true")
            { inPlaylistList.Sorted = true; }
            else { inPlaylistList.Sorted = false; }
        }

        private void settings_sortvideoslist_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_sortvideoslist_switch.Checked == true)
            { WolfLib.Rasu.Set(SettingFile, "sort_videos_list", "true"); }
            else { WolfLib.Rasu.Set(SettingFile, "sort_videos_list", "false"); }
            applySettings();
        }

        #endregion
        #region "Stretch to fit"

        // Set default checked
        private void setRadioButtonStretchToFit()
        {
            if (WolfLib.Rasu.Get(SettingFile, "stretch_to_fit") == "true") { settings_stretchtofit_switch.Checked = true; }
            else { settings_stretchtofit_switch.Checked = false; }
        }

        // Apply settings
        private void stretchToFitApplySettings()
        {
            if (WolfLib.Rasu.Get(SettingFile, "stretch_to_fit") == "true")
            { WMP.stretchToFit = true; }
            else { WMP.stretchToFit = false; }
        }

        private void settings_stretchtofit_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_stretchtofit_switch.Checked == true)
            { WolfLib.Rasu.Set(SettingFile, "stretch_to_fit", "true"); }
            else { WolfLib.Rasu.Set(SettingFile, "stretch_to_fit", "false"); }
            applySettings();
        }

        #endregion

        /**
          * 
          * 
          *  TAB CONTROL NAVIGATION
          * 
          * 
          **/

        #region "Tab control navigation"

        private void WWTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean refresh = true;
            if (WWTabControl.SelectedTab == tabAddPlaylist) { refresh = false; }
            else if (WWTabControl.SelectedTab == tabEditVideo) { refresh = false; }
            else if (WWTabControl.SelectedTab == tabEditPlaylist) { refresh = false; }
            else if (WWTabControl.SelectedTab == tabSettings) { loadSettings(); }
            else if (WWTabControl.SelectedTab == tabPlaylists) { refreshVideoList(); }
            if (refresh == true)
            {
                WWTabControl.TabPages.Remove(tabAddPlaylist);
                WWTabControl.TabPages.Remove(tabEditPlaylist);
            }
        }



        #endregion


        // Close form
        private void WolfWatchMetro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
