using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static String SettingsFile = SettingsPath + "settings.settings";

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

            // Informations
            informations.Text = "WolfWatch v" + WolfWatchVersion + "\n" +
                                "By Loan.J (ToWolf)";

            // Set up players
            WMP.uiMode = "full";
            WMP.enableContextMenu = true;

            // Show front
            this.BringToFront();

            // Check for updates
            if (WolfLib.Rasu.Get(SettingsFile, "autoupdates").ToLower() == "true")
            { checkForUpdates(false); }
        }

        /**
          * 
          * 
          *  CHECK FOR UPDATES AND UPDATES
          * 
          * 
          **/

        #region "Merge files"

        public void UpdateFiles()
        {
            // Settings file
            try
            {
                // Settings file
                String settingsVersion;
                try { settingsVersion = WolfLib.Rasu.Get(SettingsFile, "version"); }
                catch { settingsVersion = "1.0"; }
                if (settingsVersion != WolfWatchVersion)
                {
                    // Settings file
                    String newSettings = SettingsPath + "NewSettings" + WolfWatchVersion + ".settings";
                    File.WriteAllText(newSettings, Resources.settings);
                    WolfLib.Rasu.MergeFile(SettingsFile, newSettings);
                    File.Delete(SettingsFile);
                    File.Move(newSettings, SettingsFile);
                    WolfLib.Rasu.Set(SettingsFile, "version", WolfWatchVersion);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

#endregion

        #region "Check for updates"

        // Check for updates
        public async void checkForUpdates(bool boolean)
        {
            try
            {
                await Task.Delay(1);
                String version = WolfLib.Web.DownloadString("https://dl.dropboxusercontent.com/s/e9sqmj0k4gtgp4u/version.txt?dl=0");
                if (version != WolfWatchVersion)
                {
                    if (MetroMessageBox.Show(this, newVersion, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Application.StartupPath + "\\WolfUpdater.exe");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (boolean == true)
                    {
                        MetroMessageBox.Show(this, noNewVersion, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, errorConnection, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manual check
        private void settings_manualupdatecheck_Click(object sender, EventArgs e)
        {
            checkForUpdates(true);
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
        public static String noNewVersion;
        public static String errorConnection;
        public static String deletefiles;
        public static String restartsoftware;

        public static bool loadLang = false;

        public void refreshLang()
        {
            try
            {
                loadLang = true;

                // German: 0
                // English: 1
                // Spanish: 2
                // French: 3

                String lang;
                int index = 2;

                // Search index (null go to english)
                if (!Int32.TryParse(WolfLib.Rasu.Get(SettingsFile, "lang"), out index))
                { WolfLib.Rasu.Set(SettingsFile, "lang", "1"); index = 1; }

                // Determine the language
                if (index == 0) { lang = "german"; }
                else if (index == 1) { lang = "english"; }
                else if (index == 2) { lang = "spanish"; }
                else if (index == 3) { lang = "french"; }
                else { lang = ""; }

                String path = SettingsPath + lang + ".lang";

                // Label
                playlists_playlistslist.Text = WolfLib.Rasu.Get(path, "playlistslist") + ":";

                editplaylist_editplaylist.Text = WolfLib.Rasu.Get(path, "editplaylist") + ":";
                editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo") + ":";

                addplaylist_addplaylist.Text = WolfLib.Rasu.Get(path, "addplaylist") + ":";

                addplaylist_playlistname.WaterMark = WolfLib.Rasu.Get(path, "playlistname");
                editplaylist_playlistname.WaterMark = WolfLib.Rasu.Get(path, "playlistname");
                editvideo_videoname.WaterMark = WolfLib.Rasu.Get(path, "videoname");

                // Settings
                settings_advancedsettings.Text = WolfLib.Rasu.Get(path, "advancedsettings");
                settings_generalsettings.Text = WolfLib.Rasu.Get(path, "generalsettings");
                settings_videoplayersettings.Text = WolfLib.Rasu.Get(path, "videoplayersettings");

                settings_langcombo.Items.Clear();
                settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "german"));
                settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "english"));
                settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "spanish"));
                settings_langcombo.Items.Add(WolfLib.Rasu.Get(path, "french"));
                settings_langcombo.SelectedIndex = index;

                settings_lang.Text = WolfLib.Rasu.Get(path, "language");
                settings_autoupdates.Text = WolfLib.Rasu.Get(path, "autoupdates");
                settings_manualupdatecheck.Text = WolfLib.Rasu.Get(path, "manualupdatecheck");

                settings_stretchtofit.Text = WolfLib.Rasu.Get(path, "stretchtofit");
                settings_sortvideolist.Text = WolfLib.Rasu.Get(path, "sortvideoslist");

                settings_showfiles.Text = WolfLib.Rasu.Get(path, "showfiles");
                settings_resetfiles.Text = WolfLib.Rasu.Get(path, "resetfiles");

                // Buttons
                addplaylist_addplaylistbutton.Text = WolfLib.Rasu.Get(path, "addplaylist");
                editplaylist_editplaylistbutton.Text = WolfLib.Rasu.Get(path, "editplaylist");
                editvideo_editvideobutton.Text = WolfLib.Rasu.Get(path, "editvideo");
                
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
                noNewVersion = WolfLib.Rasu.Get(path, "nonewversion");
                errorConnection = WolfLib.Rasu.Get(path, "errorconnection");
                deletefiles = WolfLib.Rasu.Get(path, "deletefiles");
                restartsoftware = WolfLib.Rasu.Get(path, "restartsoftware");

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

                loadLang = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    refreshTabs();
                    setPlaylistsList();
                }
                else
                {
                    MetroMessageBox.Show(this, playlistExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add playlist
        private void addPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabAddPlaylist);
            WWTabControl.SelectTab(tabAddPlaylist);
        }

        // Cancel
        private void addplaylist_cancel_Click(object sender, EventArgs e)
        {
            refreshTabs();
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
                    if (MetroMessageBox.Show(this, deletePlaylist, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WMP.URL = "";
                        Directory.Delete(PlaylistPath + playlistsList.Text, true);
                        setPlaylistsList();
                        refreshVideoList();
                    }
                }
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel
        private void editplaylist_cancel_Click(object sender, EventArgs e)
        {
            refreshTabs();
        }

        // Apply edit
        private void editplaylist_editplaylistbutton_Click(object sender, EventArgs e)
        {
            if (editplaylist_playlistname.Text != playlistsList.Text&&editplaylist_playlistname.Text != "")
            {
                if (Directory.Exists(PlaylistPath + editplaylist_playlistname.Text))
                { MetroMessageBox.Show(this, playlistExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Directory.Move(PlaylistPath + playlistsList.Text, PlaylistPath + editplaylist_playlistname.Text);
            }
            refreshTabs();
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
                    MetroMessageBox.Show(this, selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        else { MetroMessageBox.Show(this, videoExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MetroMessageBox.Show(this, deleteVideo, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            WMP.URL = "";
                            String SelectedVideoPath = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem);
                            File.Delete(SelectedVideoPath + WolfLib.Rasu.Get(SelectedVideoPath + ".info", "video_extension"));
                            File.Delete(SelectedVideoPath + ".info");
                            refreshVideoList();
                        }
                    }
                    else { MetroMessageBox.Show(this, selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    else { MetroMessageBox.Show(this, selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel
        private void editvideo_cancel_Click(object sender, EventArgs e)
        {
            refreshTabs();
        }

        // Apply edit
        private void editvideo_editvideobutton_Click(object sender, EventArgs e)
        {
            String VideoInformations = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + ".info";
            String Video = PlaylistPath + playlistsList.Text + "\\" + inPlaylistList.GetItemText(inPlaylistList.SelectedItem) + WolfLib.Rasu.Get(VideoInformations, "video_extension");
            if (editvideo_videoname.Text != inPlaylistList.GetItemText(inPlaylistList.SelectedItem)&&editvideo_videoname.Text != "")
            {
                File.Move(Video, PlaylistPath + playlistsList.Text + "\\" + editvideo_videoname.Text + WolfLib.Rasu.Get(VideoInformations, "video_extension"));
                File.Move(VideoInformations, PlaylistPath + playlistsList.Text + "\\" + editvideo_videoname.Text + ".info");
            }
            refreshTabs();
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
                    else { MetroMessageBox.Show(this, selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void applySettings()
        {
            langApplySettings();
            themeApplySettings();
            stretchToFitApplySettings();
            sortVideosListFitApplySettings();
        }

        public void loadSettings()
        {
            setComboBoxTheme();
            setCheckBoxAutoUpdates();
            setCheckBoxStretchToFit();
            setCheckBoxSortVideoList();
        }

        #endregion

        #region "Lang"

        // Apply settings
        private void langApplySettings()
        {
            refreshLang();
        }

        // Change language
        private void settings_langcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadLang == false)
            {
                WolfLib.Rasu.Set(SettingsFile, "lang", settings_langcombo.SelectedIndex.ToString());
                applySettings();
            }
        }

        #endregion
        #region "Theme"

        // Set default checked
        private void setComboBoxTheme()
        {
            settings_themecombo.Text = WolfLib.Rasu.Get(SettingsFile, "theme");
        }

        // Apply settings
        private void themeApplySettings()
        {
            String theme = WolfLib.Rasu.Get(SettingsFile, "theme").ToLower();
            if (theme == "light")
            {
                WWTabControl.Theme = MetroFramework.MetroThemeStyle.Light;
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                inPlaylistList.BackColor = Color.White;
                inPlaylistList.ForeColor = Color.Black;
            }
            else if (theme == "dark")
            {
                WWTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                inPlaylistList.BackColor = Color.FromArgb(64, 64, 64);
                inPlaylistList.ForeColor = Color.White;
            }
            else { WolfLib.Rasu.Set(SettingsFile, "theme", "Light"); themeApplySettings(); }
        }

        // Change theme
        private void settings_themecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingsFile, "theme", settings_themecombo.Text);
            applySettings();
        }

        #endregion
        #region "Auto updates"

        // Set default checked
        private void setCheckBoxAutoUpdates()
        {
            if (WolfLib.Rasu.Get(SettingsFile, "autoupdates").ToLower() == "true") { settings_autoupdates.Checked = true; }
            else { settings_autoupdates.Checked = false; }
        }

        private void settings_autoupdates_CheckedChanged(object sender, EventArgs e)
        {
            WolfLib.Rasu.Set(SettingsFile, "autoupdates", settings_autoupdates.Checked.ToString());
            applySettings();
        }

        #endregion

        #region "Informations"

        // Donations
        private void settings_bitcoin_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, donation.Replace("{type}", "Bitcoin"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText("19NSXHZN19FnTArLKydzV2acwzBqpk6nNL");
        }

        private void settings_ether_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, donation.Replace("{type}", "Ether"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText("0x5A24cF7a980165642abD9f65D9411DdA0bdb52db");
        }

        #endregion
        #region "Advanced settings"

        // Show files
        private void settings_showfiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(WWPath);
        }

        // Reset software (files)
        private void settings_resetfiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, deletefiles, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    WMP.URL = "";
                    Directory.Delete(PlaylistPath, true);
                    Directory.Delete(SettingsPath, true);
                    MetroMessageBox.Show(this, restartsoftware, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Sort videos list"

        // Set default checked
        private void setCheckBoxSortVideoList()
        {
            if (WolfLib.Rasu.Get(SettingsFile, "sort_videos_list").ToLower() == "true") { settings_sortvideolist.Checked = true; }
            else { settings_sortvideolist.Checked = false; }
        }

        // Apply settings
        private void sortVideosListFitApplySettings()
        {
            if (WolfLib.Rasu.Get(SettingsFile, "sort_videos_list").ToLower() == "true")
            { inPlaylistList.Sorted = true; playlistsList.Sorted = true; }
            else { inPlaylistList.Sorted = false; }
        }

        private void settings_sortvideolist_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_sortvideolist.Checked == true)
            { WolfLib.Rasu.Set(SettingsFile, "sort_videos_list", "True"); }
            else { WolfLib.Rasu.Set(SettingsFile, "sort_videos_list", "False"); }
            applySettings();
        }

        #endregion
        #region "Stretch to fit"

        // Set default checked
        private void setCheckBoxStretchToFit()
        {
            if (WolfLib.Rasu.Get(SettingsFile, "stretch_to_fit").ToLower() == "true") { settings_stretchtofit.Checked = true; }
            else { settings_stretchtofit.Checked = false; }
        }

        // Apply settings
        private void stretchToFitApplySettings()
        {
            if (WolfLib.Rasu.Get(SettingsFile, "stretch_to_fit").ToLower() == "true")
            { WMP.stretchToFit = true; }
            else { WMP.stretchToFit = false; }
        }

        private void settings_stretchtofit_CheckedChanged(object sender, EventArgs e)
        {
            if (settings_stretchtofit.Checked == true)
            { WolfLib.Rasu.Set(SettingsFile, "stretch_to_fit", "True"); }
            else { WolfLib.Rasu.Set(SettingsFile, "stretch_to_fit", "False"); }
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
            TabPage tab = WWTabControl.SelectedTab;
            if (tab == tabPlayer || tab == tabPlaylists || tab == tabSettings) { }
            else
            {
                WWTabControl.TabPages.Remove(tabPlayer);
                WWTabControl.TabPages.Remove(tabPlaylists);
                WWTabControl.TabPages.Remove(tabSettings);
            }
        }

        private void refreshTabs()
        {
            WWTabControl.TabPages.Remove(WWTabControl.SelectedTab);
            WWTabControl.TabPages.Insert(0, tabPlayer);
            WWTabControl.TabPages.Insert(1, tabPlaylists);
            WWTabControl.TabPages.Insert(2, tabSettings);
            WWTabControl.SelectedTab = tabPlaylists;
        }

        #endregion

        // Close form
        private void WolfWatchMetro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void informations_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://towolf.livehost.fr/");
        }
    }
}
