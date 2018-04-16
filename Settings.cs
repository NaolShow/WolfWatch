using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfWatch
{
    public static class Settings
    {

        // Load/Set settings
        public static void LoadSettings()
        {
            LoadLang();
            LoadTheme();
            LoadSortLists();
            LoadStretchToFit();
            LoadMaxDropDownPlaylists();
        }

        public static void SetSettings()
        {
            SetTheme();
            SetAutoUpdates();
            SetLoadSortLists();
            SetStretchToFit();
            SetMaxDropDownPlaylists();
        }

        // General settings
        #region "Lang"

        private static void LoadLang()
        {
            Langs.refreshLang();
        }

        // Combo box
        public static void GetLangCombo()
        {
            if (Langs.loadingLang == false)
            {
                WolfLib.Rasu.Set(References.SettingsFile, "lang", Program.mainForm.settings_langcombo.SelectedIndex.ToString());
                LoadLang();
            }
        }

        #endregion
        #region "Theme"

        private static void SetTheme()
        {
            Program.mainForm.settings_themecombo.Text = WolfLib.Rasu.Get(References.SettingsFile, "theme");
        }

        private static void LoadTheme()
        {
            String theme = WolfLib.Rasu.Get(References.SettingsFile, "theme").ToLower();
            if (theme == "light")
            {
                Program.mainForm.WWTabControl.Theme = MetroFramework.MetroThemeStyle.Light;
                Program.mainForm.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                Program.mainForm.inListView.BackColor = Color.White;
                Program.mainForm.inListView.ForeColor = Color.Black;
            }
            else if (theme == "dark")
            {
                Program.mainForm.WWTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
                Program.mainForm.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                Program.mainForm.inListView.BackColor = Color.FromArgb(64, 64, 64);
                Program.mainForm.inListView.ForeColor = Color.White;
            }
            else
            {
                WolfLib.Rasu.Set(References.SettingsFile, "theme", "Light");
                LoadTheme();
            }
        }

        // Combo box
        public static void GetThemeCombo()
        {
            WolfLib.Rasu.Set(References.SettingsFile, "theme", Program.mainForm.settings_themecombo.Text);
            LoadTheme();

        }

        #endregion
        #region "Auto updates"

        private static void SetAutoUpdates()
        {
            if (WolfLib.Rasu.Get(References.SettingsFile, "autoupdates").ToLower() == "true")
            {
                Program.mainForm.settings_autoupdates.Checked = true;
            }
            else
            {
                Program.mainForm.settings_autoupdates.Checked = false;
            }
        }

        // Check box
        public static void GetUpdatesCheck()
        {
            WolfLib.Rasu.Set(References.SettingsFile, "autoupdates", Program.mainForm.settings_autoupdates.Checked.ToString());
        }

        #endregion

        #region "Sort videos list"

        // Set default checked
        private static void SetLoadSortLists()
        {
            if (WolfLib.Rasu.Get(References.SettingsFile, "sort_videos_list").ToLower() == "true")
            {
                Program.mainForm.settings_sortvideolist.Checked = true;
            }
            else
            {
                Program.mainForm.settings_sortvideolist.Checked = false;
            }
        }

        // Apply settings
        private static void LoadSortLists()
        {
            int index;
            Int32.TryParse(WolfLib.Rasu.Get(References.SettingsFile, "sort_videos_list_type"), out index);
            if (WolfLib.Rasu.Get(References.SettingsFile, "sort_videos_list").ToLower() == "true")
            {
                if (index == 0)
                { Program.mainForm.inListView.Sorting = SortOrder.Ascending; }
                else { Program.mainForm.inListView.Sorting = SortOrder.Descending; }
                Program.mainForm.playlistsList.Sorted = true;
                Program.mainForm.settings_sortvideolisttype.Visible = true;
            }
            else
            {
                Program.mainForm.inListView.Sorting = SortOrder.None;
                Program.mainForm.playlistsList.Sorted = false;
                Program.mainForm.settings_sortvideolisttype.Visible = false;
            }
            Program.mainForm.refreshPlaylistsList();
            Program.mainForm.refreshList();
        }

        // Check box
        public static void GetSortVideoListCheck()
        {
            if (Program.mainForm.settings_sortvideolist.Checked == true)
            {
                WolfLib.Rasu.Set(References.SettingsFile, "sort_videos_list", "True");
            }
            else
            {
                WolfLib.Rasu.Set(References.SettingsFile, "sort_videos_list", "False");
            }
            LoadSortLists();
        }

        // Combo box
        public static void GetSortVideoListType()
        {
            WolfLib.Rasu.Set(References.SettingsFile, "sort_videos_list_type", Program.mainForm.settings_sortvideolisttype.SelectedIndex.ToString());
            LoadSortLists();
        }

        #endregion
        #region "Stretch to fit"

        // Set default checked
        private static void SetStretchToFit()
        {
            if (WolfLib.Rasu.Get(References.SettingsFile, "stretch_to_fit").ToLower() == "true")
            {
                Program.mainForm.settings_stretchtofit.Checked = true;
            }
            else
            {
                Program.mainForm.settings_stretchtofit.Checked = false;
            }
        }

        // Apply settings
        private static void LoadStretchToFit()
        {
            if (WolfLib.Rasu.Get(References.SettingsFile, "stretch_to_fit").ToLower() == "true")
            {
                Program.mainForm.WMP.stretchToFit = true;
            }
            else
            {
                Program.mainForm.WMP.stretchToFit = false;
            }
        }

        // Check box
        public static void GetStretchToFitCheck()
        {
            if (Program.mainForm.settings_stretchtofit.Checked == true)
            {
                WolfLib.Rasu.Set(References.SettingsFile, "stretch_to_fit", "True");
            }
            else
            {
                WolfLib.Rasu.Set(References.SettingsFile, "stretch_to_fit", "False");
            }
            LoadStretchToFit();
        }

        #endregion
        #region "Max drop down playlists"

        private static void SetMaxDropDownPlaylists()
        {
            Program.mainForm.settings_maxdropdownplaylistsstrack.Value = int.Parse(WolfLib.Rasu.Get(References.SettingsFile, "max_dropdown_playlists"));
        }

        private static void LoadMaxDropDownPlaylists()
        {
            Program.mainForm.playlistsList.DropDownHeight = int.Parse(WolfLib.Rasu.Get(References.SettingsFile, "max_dropdown_playlists")) * 25;
            Program.mainForm.settings_maxdropdownplaylists.Text = Langs.maxDropDownPlaylists + " (" + int.Parse(WolfLib.Rasu.Get(References.SettingsFile, "max_dropdown_playlists")) + ")";
        }

        // Track bar
        public static void GetMaxDropDownPlaylistsTrack()
        {
            WolfLib.Rasu.Set(References.SettingsFile, "max_dropdown_playlists", Program.mainForm.settings_maxdropdownplaylistsstrack.Value.ToString());
            LoadMaxDropDownPlaylists();
        }

        #endregion

        #region "Advanced settings"

        // Button
        public static void GetShowFilesButton()
        {
            System.Diagnostics.Process.Start(References.MainPath);
        }

        // Button
        public static void GetResetFilesButton()
        {
            try
            {
                if (MetroMessageBox.Show(Program.mainForm, Langs.deletefiles, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Program.mainForm.WMP.URL = "";
                    Directory.Delete(References.PlaylistsPath, true);
                    Directory.Delete(References.SettingsPath, true);
                    MetroMessageBox.Show(Program.mainForm, Langs.restartsoftware, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(Program.mainForm, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Informations"

        // Refresh
        private static void RefreshInformations()
        {
            Program.mainForm.settings_numberofplaylists.Text = Langs.numberplaylists + ": " + Directory.GetDirectories(References.PlaylistsPath).Count();
            Program.mainForm.settings_weightofplaylists.Text = Langs.weightplaylists + ": " + Directory.GetFiles(References.PlaylistsPath, "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length) / 1024 / 1024) + "Mo";
        }

        #endregion

        /**
          * 
          * 
          *  TAB CONTROL NAVIGATION
          * 
          * 
          **/

        public static void WWTabControl_Selected(object sender, EventArgs e)
        {
            TabPage tab = Program.mainForm.WWTabControl.SelectedTab;
            if (tab == Program.mainForm.tabSettings)
            {
                Settings.RefreshInformations();
            }
            else if (tab == Program.mainForm.tabPlayer || tab == Program.mainForm.tabPlaylists) { }
            else
            {
                Program.mainForm.WWTabControl.TabPages.Remove(Program.mainForm.tabPlayer);
                Program.mainForm.WWTabControl.TabPages.Remove(Program.mainForm.tabPlaylists);
                Program.mainForm.WWTabControl.TabPages.Remove(Program.mainForm.tabSettings);
            }
        }

        public static void refreshTabs()
        {
            Program.mainForm.WWTabControl.TabPages.Remove(Program.mainForm.WWTabControl.SelectedTab);
            Program.mainForm.WWTabControl.TabPages.Insert(0, Program.mainForm.tabPlayer);
            Program.mainForm.WWTabControl.TabPages.Insert(1, Program.mainForm.tabPlaylists);
            Program.mainForm.WWTabControl.TabPages.Insert(2, Program.mainForm.tabSettings);
            Program.mainForm.WWTabControl.SelectedTab = Program.mainForm.tabPlaylists;
        }

    }
}
