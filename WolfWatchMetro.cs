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
using WolfLib;

namespace WolfWatch
{
    public partial class WolfWatchMetro : MetroFramework.Forms.MetroForm
    {
        public WolfWatchMetro()
        {
            InitializeComponent();

            startWolfWatch();
        }

        public async void startWolfWatch()
        {
            // Hide tab pages
            WWTabControl.TabPages.Remove(tabAddPlaylist);
            WWTabControl.TabPages.Remove(tabEditPlaylist);
            WWTabControl.TabPages.Remove(tabEditVideo);

            WWTabControl.SelectedTab = tabPlayer;

            this.WWTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(Settings.WWTabControl_Selected);

            await Task.Delay(1);

            // Set up players
            WMP.uiMode = "full";
            WMP.enableContextMenu = true;

            // Show front
            this.BringToFront();

            // Check for updates
            if (Reference.RSettings.Get("autoupdates").ToLower() == "true")
            {
                Updates.checkForUpdates(false);
            }
        }

        /**
          * 
          * 
          *  PLAYLISTS
          * 
          * 
          **/

        public static WatchFile wFile;

        private void inListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            wFile = (WatchFile)e.Item.Tag;
        }

        #region "Playlist menu"
        // Playlist context menu strip
        private void playlistsMenu_Click(object sender, EventArgs e)
        {
            playlistContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private async void inListView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                await Task.Delay(10);
                Boolean enabled = false;
                if (inListView.Items.Count > 0 && inListView.SelectedItems.Count > 0)
                {
                    if (!String.IsNullOrEmpty(inListView.SelectedItems[0].Text))
                    { enabled = true; }
                }
                playVideoToolStripMenuItem.Enabled = enabled;
                removeVideoToolStripMenuItem.Enabled = enabled;
                editVideoToolStripMenuItem.Enabled = enabled;
                exportVideoToolStripMenuItem.Enabled = enabled;
                if (e.Button == MouseButtons.Right)
                {
                    listContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
            catch { }
        }

        #endregion

        #region "Refresh lists"
        // Refresh left list
        public void refreshList()
        {
            try
            {
                inListView.Items.Clear(); // Clear list
                foreach (String path in Directory.GetFiles(Reference.PlaylistsPath + playlistsList.Text))
                {
                    String ext = Path.GetExtension(path);
                    if (ext != ".info" && ext != ".playinfo")
                    {
                        WatchFile file = new WatchFile(Path.GetFileNameWithoutExtension(path), Path.GetExtension(path));
                        ListViewItem item = new ListViewItem(file.ToString());
                        item.Tag = file;
                        item.SubItems.Add(file.Description);
                        item.SubItems.Add(file.Duration);
                        inListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Auto refresh left list
        private void playlistsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        // Refresh playlists list
        public void refreshPlaylistsList()
        {
            try
            {
                playlistsList.Items.Clear();
                foreach (String playlistName in Directory.GetDirectories(Reference.PlaylistsPath))
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
        #region "Add playlist"

        // Apply add
        private void addplaylist_addplaylistbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Reference.PlaylistsPath + addplaylist_playlistname.Text))
                {
                    // Create playlist
                    Directory.CreateDirectory(Reference.PlaylistsPath + addplaylist_playlistname.Text);
                    File.Create(Reference.PlaylistsPath + addplaylist_playlistname.Text + "\\playlist.playinfo").Dispose();
                    File.WriteAllText(Reference.PlaylistsPath + addplaylist_playlistname.Text + "\\playlist.playinfo", Resources.playlist);

                    // Exit
                    Settings.refreshTabs();
                    refreshPlaylistsList();
                }
                else
                {
                    MetroMessageBox.Show(this, Langs.playlistExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Settings.refreshTabs();
        }

        #endregion
        #region "Remove playlist"

        // Remove playlist
        private void removePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    if (MetroMessageBox.Show(this, Langs.deletePlaylist, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WMP.URL = "";
                        Directory.Delete(Reference.PlaylistsPath + playlistsList.Text, true);
                        refreshPlaylistsList();
                        refreshList();
                    }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (String path in Directory.GetFiles(Reference.PlaylistsPath + playlistsList.Text, "*.info", SearchOption.TopDirectoryOnly))
                        {
                            Rasu VideoInfo = new Rasu(path);
                            exportVideo(Path.GetFileNameWithoutExtension(path), folderBrowserDialog.SelectedPath + "\\" + Path.GetFileNameWithoutExtension(path) + VideoInfo.Get("video_extension"));
                        }
                    }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    WMP.URL = "";
                    WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabEditPlaylist);
                    WWTabControl.SelectTab(tabEditPlaylist);

                    // Load playlist informations
                    editplaylist_playlistname.Text = playlistsList.Text;
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel
        private void editplaylist_cancel_Click(object sender, EventArgs e)
        {
            Settings.refreshTabs();
        }

        // Apply edit
        private void editplaylist_editplaylistbutton_Click(object sender, EventArgs e)
        {
            if (editplaylist_playlistname.Text != playlistsList.Text && editplaylist_playlistname.Text != "")
            {
                if (Directory.Exists(Reference.PlaylistsPath + editplaylist_playlistname.Text))
                { MetroMessageBox.Show(this, Langs.playlistExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                Directory.Move(Reference.PlaylistsPath + playlistsList.Text, Reference.PlaylistsPath + editplaylist_playlistname.Text);
            }
            Settings.refreshTabs();
            refreshPlaylistsList();
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
                if (!String.IsNullOrEmpty(wFile.ToString()))
                {
                    WMP.URL = wFile.Path + wFile.Extension;
                }
                else
                {
                    MetroMessageBox.Show(this, Langs.selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Play video when double click on the name
        private void inListView_DoubleClick(object sender, EventArgs e)
        {
            playVideo(wFile.ToString());
        }

        // Play video with context menu button
        private void playVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playVideo(wFile.ToString());
        }

        #endregion
        #region "Add video"

        private void addVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    openFileDialog.Title = Langs.open + " - " + playlistsList.Text;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        String SelectedPlaylistPath = Reference.PlaylistsPath + playlistsList.Text + "\\";
                        String SelectedPlaylistInfo = SelectedPlaylistPath + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".info";

                        Rasu VideoInfo = new Rasu(SelectedPlaylistInfo);
                        if (!File.Exists(SelectedPlaylistPath + Path.GetFileName(openFileDialog.FileName)))
                        {
                            // Copy video
                            File.Copy(openFileDialog.FileName, SelectedPlaylistPath + Path.GetFileName(openFileDialog.FileName));
                            File.Create(SelectedPlaylistInfo).Dispose();

                            // Create info file
                            File.WriteAllText(SelectedPlaylistInfo, Resources.video);

                            // Set up video info file
                            VideoInfo.Set("video_extension", Path.GetExtension(openFileDialog.FileName));
                            VideoInfo.Set("video_file_version", Application.ProductVersion);
                            VideoInfo.SaveFile();

                            refreshList();
                        }
                        else { MetroMessageBox.Show(this, Langs.videoExist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    if (!String.IsNullOrEmpty(wFile.ToString()))
                    {
                        if (MetroMessageBox.Show(this, Langs.deleteVideo, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            WMP.URL = "";
                            File.Delete(wFile.Path + wFile.Extension);
                            File.Delete(wFile.Path + ".info");
                            refreshList();
                        }
                    }
                    else { MetroMessageBox.Show(this, Langs.selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    if (!String.IsNullOrEmpty(wFile.ToString()))
                    {
                        WMP.URL = "";
                        WWTabControl.TabPages.Insert(WWTabControl.TabCount, tabEditVideo);
                        WWTabControl.SelectTab(tabEditVideo);

                        // Load video informations
                        editvideo_videoname.Text = wFile.ToString();
                        editvideo_videodescription.Text = wFile.Description;
                    }
                    else { MetroMessageBox.Show(this, Langs.selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel
        private void editvideo_cancel_Click(object sender, EventArgs e)
        {
            Settings.refreshTabs();
        }

        // Apply edit
        private void editvideo_editvideobutton_Click(object sender, EventArgs e)
        {
            try
            {
                Rasu VideoInfo = new Rasu(wFile.Path + ".info");
                if (editvideo_videodescription.Text != wFile.Description && !String.IsNullOrEmpty(editvideo_videodescription.Text))
                {
                    VideoInfo.Set("video_description", editvideo_videodescription.Text);
                }
                if (editvideo_videoname.Text != wFile.ToString() && !String.IsNullOrEmpty(editvideo_videoname.Text))
                {
                    String VideoPath = wFile.Path + wFile.Extension;
                    File.Move(VideoPath, Reference.PlaylistsPath + playlistsList.Text + "\\" + editvideo_videoname.Text + wFile.Extension);
                    File.Move(VideoInfo.GetFilePath(), Reference.PlaylistsPath + playlistsList.Text + "\\" + editvideo_videoname.Text + ".info");
                }
                VideoInfo.SaveFile();
                Settings.refreshTabs();
                refreshList();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region "Export video"

        private void exportVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(playlistsList.Text))
                {
                    if (!String.IsNullOrEmpty(wFile.ToString()))
                    {
                        saveFileDialog.FileName = wFile.ToString() + wFile.Extension;
                        saveFileDialog.Filter = "File|*" + wFile.Extension;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) { exportVideo(wFile.ToString(), saveFileDialog.FileName); }
                    }
                    else { MetroMessageBox.Show(this, Langs.selectVideo, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MetroMessageBox.Show(this, Langs.selectPlaylist, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportVideo(String videoName, String outputFile)
        {
            File.Copy(Reference.PlaylistsPath + playlistsList.Text + "\\" + videoName + wFile.Extension, outputFile);
        }

        #endregion


        /**
          * 
          * 
          *  SETTINGS EVENTS
          * 
          * 
          **/


        // Lang
        private void settings_langcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetLangCombo();
        }
        // Theme
        private void settings_themecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetThemeCombo();
        }
        // Auto updates
        private void settings_autoupdates_CheckedChanged(object sender, EventArgs e)
        {
            Settings.GetUpdatesCheck();
        }

        // Sort lists
        private void settings_sortvideolist_CheckedChanged(object sender, EventArgs e)
        {
            Settings.GetSortVideoListCheck();
        }
        private void settings_sortvideolisttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.GetSortVideoListType();
        }

        // Stretch to fit
        private void settings_stretchtofit_CheckedChanged(object sender, EventArgs e)
        {
            Settings.GetStretchToFitCheck();
        }
        // Max dropdown playlists
        private void settings_maxdropdownplaylistsstrack_ValueChanged(object sender, EventArgs e)
        {
            Settings.GetMaxDropDownPlaylistsTrack();
        }

        // Show files
        private void settings_showfiles_Click(object sender, EventArgs e)
        {
            Settings.GetShowFilesButton();
        }
        // Reset files
        private void settings_resetfiles_Click(object sender, EventArgs e)
        {
            Settings.GetResetFilesButton();
        }

        // Manual update check
        private void settings_manualupdatecheck_Click(object sender, EventArgs e)
        {
            Updates.GetManualUpdateCheckButton();
        }

        /**
          * 
          * 
          *  COMPLETE CLOSE FORM
          * 
          * 
          **/ 
        private void WolfWatchMetro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reference.RSettings.SaveFile();
            Environment.Exit(0);
        }
    }
}
