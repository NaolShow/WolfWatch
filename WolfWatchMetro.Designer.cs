namespace WolfWatch
{
    partial class WolfWatchMetro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WolfWatchMetro));
            this.WWTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPlayer = new MetroFramework.Controls.MetroTabPage();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPlaylists = new MetroFramework.Controls.MetroTabPage();
            this.inListView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playlistsMenu = new MetroFramework.Controls.MetroButton();
            this.playlistsList = new MetroFramework.Controls.MetroComboBox();
            this.playlists_playlistslist = new MetroFramework.Controls.MetroLabel();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.settings_generalsettingsflowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settings_generalsettings = new MetroFramework.Controls.MetroLabel();
            this.settings_lang = new MetroFramework.Controls.MetroLabel();
            this.settings_langcombo = new MetroFramework.Controls.MetroComboBox();
            this.settings_theme = new MetroFramework.Controls.MetroLabel();
            this.settings_themecombo = new MetroFramework.Controls.MetroComboBox();
            this.settings_autoupdates = new MetroFramework.Controls.MetroCheckBox();
            this.settings_manualupdatecheck = new MetroFramework.Controls.MetroButton();
            this.settings_videoplayersettings = new MetroFramework.Controls.MetroLabel();
            this.settings_stretchtofit = new MetroFramework.Controls.MetroCheckBox();
            this.settings_sortvideolist = new MetroFramework.Controls.MetroCheckBox();
            this.settings_sortvideolisttype = new MetroFramework.Controls.MetroComboBox();
            this.settings_maxdropdownplaylists = new MetroFramework.Controls.MetroLabel();
            this.settings_maxdropdownplaylistsstrack = new MetroFramework.Controls.MetroTrackBar();
            this.settings_advancedsettings = new MetroFramework.Controls.MetroLabel();
            this.settings_showfiles = new MetroFramework.Controls.MetroButton();
            this.settings_resetfiles = new MetroFramework.Controls.MetroButton();
            this.settings_informations = new MetroFramework.Controls.MetroLabel();
            this.settings_numberofplaylists = new MetroFramework.Controls.MetroLabel();
            this.settings_weightofplaylists = new MetroFramework.Controls.MetroLabel();
            this.WolfWatchInformations = new MetroFramework.Controls.MetroLabel();
            this.tabAddPlaylist = new MetroFramework.Controls.MetroTabPage();
            this.addplaylist_cancel = new MetroFramework.Controls.MetroButton();
            this.addplaylist_addplaylistbutton = new MetroFramework.Controls.MetroButton();
            this.addplaylist_playlistname = new MetroFramework.Controls.MetroTextBox();
            this.addplaylist_addplaylist = new MetroFramework.Controls.MetroLabel();
            this.tabEditPlaylist = new MetroFramework.Controls.MetroTabPage();
            this.editplaylist_cancel = new MetroFramework.Controls.MetroButton();
            this.editplaylist_editplaylistbutton = new MetroFramework.Controls.MetroButton();
            this.editplaylist_playlistname = new MetroFramework.Controls.MetroTextBox();
            this.editplaylist_editplaylist = new MetroFramework.Controls.MetroLabel();
            this.tabEditVideo = new MetroFramework.Controls.MetroTabPage();
            this.editvideo_videodescription = new MetroFramework.Controls.MetroTextBox();
            this.editvideo_cancel = new MetroFramework.Controls.MetroButton();
            this.editvideo_editvideobutton = new MetroFramework.Controls.MetroButton();
            this.editvideo_videoname = new MetroFramework.Controls.MetroTextBox();
            this.editvideo_editvideo = new MetroFramework.Controls.MetroLabel();
            this.listContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.playVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.WWTabControl.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.tabPlaylists.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.settings_generalsettingsflowlayoutpanel.SuspendLayout();
            this.tabAddPlaylist.SuspendLayout();
            this.tabEditPlaylist.SuspendLayout();
            this.tabEditVideo.SuspendLayout();
            this.listContextMenu.SuspendLayout();
            this.playlistContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // WWTabControl
            // 
            this.WWTabControl.Controls.Add(this.tabPlayer);
            this.WWTabControl.Controls.Add(this.tabPlaylists);
            this.WWTabControl.Controls.Add(this.tabSettings);
            this.WWTabControl.Controls.Add(this.tabAddPlaylist);
            this.WWTabControl.Controls.Add(this.tabEditPlaylist);
            this.WWTabControl.Controls.Add(this.tabEditVideo);
            this.WWTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WWTabControl.Location = new System.Drawing.Point(20, 60);
            this.WWTabControl.Name = "WWTabControl";
            this.WWTabControl.SelectedIndex = 1;
            this.WWTabControl.Size = new System.Drawing.Size(680, 400);
            this.WWTabControl.TabIndex = 0;
            this.WWTabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WWTabControl.UseSelectable = true;
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.WMP);
            this.tabPlayer.HorizontalScrollbarBarColor = false;
            this.tabPlayer.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPlayer.HorizontalScrollbarSize = 0;
            this.tabPlayer.Location = new System.Drawing.Point(4, 38);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Size = new System.Drawing.Size(672, 358);
            this.tabPlayer.TabIndex = 0;
            this.tabPlayer.Text = "Player";
            this.tabPlayer.VerticalScrollbarBarColor = false;
            this.tabPlayer.VerticalScrollbarHighlightOnWheel = false;
            this.tabPlayer.VerticalScrollbarSize = 0;
            // 
            // WMP
            // 
            this.WMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(672, 358);
            this.WMP.TabIndex = 2;
            // 
            // tabPlaylists
            // 
            this.tabPlaylists.Controls.Add(this.inListView);
            this.tabPlaylists.Controls.Add(this.playlistsMenu);
            this.tabPlaylists.Controls.Add(this.playlistsList);
            this.tabPlaylists.Controls.Add(this.playlists_playlistslist);
            this.tabPlaylists.HorizontalScrollbarBarColor = true;
            this.tabPlaylists.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPlaylists.HorizontalScrollbarSize = 10;
            this.tabPlaylists.Location = new System.Drawing.Point(4, 38);
            this.tabPlaylists.Name = "tabPlaylists";
            this.tabPlaylists.Size = new System.Drawing.Size(672, 358);
            this.tabPlaylists.TabIndex = 1;
            this.tabPlaylists.Text = "Playlists";
            this.tabPlaylists.VerticalScrollbarBarColor = true;
            this.tabPlaylists.VerticalScrollbarHighlightOnWheel = false;
            this.tabPlaylists.VerticalScrollbarSize = 10;
            // 
            // inListView
            // 
            this.inListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileDescription,
            this.fileDuration});
            this.inListView.FullRowSelect = true;
            this.inListView.Location = new System.Drawing.Point(3, 3);
            this.inListView.MultiSelect = false;
            this.inListView.Name = "inListView";
            this.inListView.Size = new System.Drawing.Size(669, 292);
            this.inListView.TabIndex = 6;
            this.inListView.UseCompatibleStateImageBehavior = false;
            this.inListView.View = System.Windows.Forms.View.Details;
            this.inListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.inListView_ItemSelectionChanged);
            this.inListView.DoubleClick += new System.EventHandler(this.inListView_DoubleClick);
            this.inListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inListView_MouseDown);
            // 
            // fileName
            // 
            this.fileName.Text = "File name";
            this.fileName.Width = 186;
            // 
            // fileDescription
            // 
            this.fileDescription.Text = "File description";
            this.fileDescription.Width = 150;
            // 
            // fileDuration
            // 
            this.fileDuration.Text = "File duration";
            this.fileDuration.Width = 137;
            // 
            // playlistsMenu
            // 
            this.playlistsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistsMenu.Location = new System.Drawing.Point(465, 326);
            this.playlistsMenu.Name = "playlistsMenu";
            this.playlistsMenu.Size = new System.Drawing.Size(204, 29);
            this.playlistsMenu.TabIndex = 5;
            this.playlistsMenu.Text = ". . .";
            this.playlistsMenu.UseSelectable = true;
            this.playlistsMenu.Click += new System.EventHandler(this.playlistsMenu_Click);
            // 
            // playlistsList
            // 
            this.playlistsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistsList.DropDownHeight = 50;
            this.playlistsList.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.playlistsList.FormattingEnabled = true;
            this.playlistsList.IntegralHeight = false;
            this.playlistsList.ItemHeight = 23;
            this.playlistsList.Location = new System.Drawing.Point(3, 326);
            this.playlistsList.Name = "playlistsList";
            this.playlistsList.Size = new System.Drawing.Size(456, 29);
            this.playlistsList.TabIndex = 4;
            this.playlistsList.UseSelectable = true;
            this.playlistsList.SelectedIndexChanged += new System.EventHandler(this.playlistsList_SelectedIndexChanged);
            // 
            // playlists_playlistslist
            // 
            this.playlists_playlistslist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playlists_playlistslist.AutoSize = true;
            this.playlists_playlistslist.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.playlists_playlistslist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playlists_playlistslist.Location = new System.Drawing.Point(3, 298);
            this.playlists_playlistslist.Name = "playlists_playlistslist";
            this.playlists_playlistslist.Size = new System.Drawing.Size(99, 25);
            this.playlists_playlistslist.Style = MetroFramework.MetroColorStyle.Black;
            this.playlists_playlistslist.TabIndex = 3;
            this.playlists_playlistslist.Text = "Playlists list:";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.settings_generalsettingsflowlayoutpanel);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(672, 358);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // settings_generalsettingsflowlayoutpanel
            // 
            this.settings_generalsettingsflowlayoutpanel.AutoScroll = true;
            this.settings_generalsettingsflowlayoutpanel.BackColor = System.Drawing.Color.Transparent;
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_generalsettings);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_lang);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_langcombo);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_theme);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_themecombo);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_autoupdates);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_manualupdatecheck);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_videoplayersettings);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_stretchtofit);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_sortvideolist);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_sortvideolisttype);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_maxdropdownplaylists);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_maxdropdownplaylistsstrack);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_advancedsettings);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_showfiles);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_resetfiles);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_informations);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_numberofplaylists);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_weightofplaylists);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.WolfWatchInformations);
            this.settings_generalsettingsflowlayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_generalsettingsflowlayoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.settings_generalsettingsflowlayoutpanel.Location = new System.Drawing.Point(0, 0);
            this.settings_generalsettingsflowlayoutpanel.Name = "settings_generalsettingsflowlayoutpanel";
            this.settings_generalsettingsflowlayoutpanel.Size = new System.Drawing.Size(672, 358);
            this.settings_generalsettingsflowlayoutpanel.TabIndex = 4;
            this.settings_generalsettingsflowlayoutpanel.WrapContents = false;
            // 
            // settings_generalsettings
            // 
            this.settings_generalsettings.AutoSize = true;
            this.settings_generalsettings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_generalsettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_generalsettings.Location = new System.Drawing.Point(3, 0);
            this.settings_generalsettings.Name = "settings_generalsettings";
            this.settings_generalsettings.Size = new System.Drawing.Size(133, 25);
            this.settings_generalsettings.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_generalsettings.TabIndex = 5;
            this.settings_generalsettings.Text = "General settings";
            // 
            // settings_lang
            // 
            this.settings_lang.AutoSize = true;
            this.settings_lang.Location = new System.Drawing.Point(3, 25);
            this.settings_lang.Name = "settings_lang";
            this.settings_lang.Size = new System.Drawing.Size(66, 19);
            this.settings_lang.TabIndex = 2;
            this.settings_lang.Text = "Language";
            // 
            // settings_langcombo
            // 
            this.settings_langcombo.DropDownHeight = 100;
            this.settings_langcombo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.settings_langcombo.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.settings_langcombo.FormattingEnabled = true;
            this.settings_langcombo.IntegralHeight = false;
            this.settings_langcombo.ItemHeight = 19;
            this.settings_langcombo.Items.AddRange(new object[] {
            "English",
            "French",
            "German",
            "Spanish"});
            this.settings_langcombo.Location = new System.Drawing.Point(3, 47);
            this.settings_langcombo.Name = "settings_langcombo";
            this.settings_langcombo.Size = new System.Drawing.Size(647, 25);
            this.settings_langcombo.TabIndex = 11;
            this.settings_langcombo.UseSelectable = true;
            this.settings_langcombo.SelectedIndexChanged += new System.EventHandler(this.settings_langcombo_SelectedIndexChanged);
            // 
            // settings_theme
            // 
            this.settings_theme.AllowDrop = true;
            this.settings_theme.AutoSize = true;
            this.settings_theme.Location = new System.Drawing.Point(3, 75);
            this.settings_theme.Name = "settings_theme";
            this.settings_theme.Size = new System.Drawing.Size(49, 19);
            this.settings_theme.TabIndex = 16;
            this.settings_theme.Text = "Theme";
            // 
            // settings_themecombo
            // 
            this.settings_themecombo.DropDownHeight = 100;
            this.settings_themecombo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.settings_themecombo.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.settings_themecombo.FormattingEnabled = true;
            this.settings_themecombo.IntegralHeight = false;
            this.settings_themecombo.ItemHeight = 19;
            this.settings_themecombo.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.settings_themecombo.Location = new System.Drawing.Point(3, 97);
            this.settings_themecombo.Name = "settings_themecombo";
            this.settings_themecombo.Size = new System.Drawing.Size(647, 25);
            this.settings_themecombo.Sorted = true;
            this.settings_themecombo.TabIndex = 17;
            this.settings_themecombo.UseSelectable = true;
            this.settings_themecombo.SelectedIndexChanged += new System.EventHandler(this.settings_themecombo_SelectedIndexChanged);
            // 
            // settings_autoupdates
            // 
            this.settings_autoupdates.AutoSize = true;
            this.settings_autoupdates.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings_autoupdates.Location = new System.Drawing.Point(3, 128);
            this.settings_autoupdates.Name = "settings_autoupdates";
            this.settings_autoupdates.Size = new System.Drawing.Size(262, 15);
            this.settings_autoupdates.TabIndex = 10;
            this.settings_autoupdates.Text = "Check at each launch if an update is available";
            this.settings_autoupdates.UseSelectable = true;
            this.settings_autoupdates.CheckedChanged += new System.EventHandler(this.settings_autoupdates_CheckedChanged);
            // 
            // settings_manualupdatecheck
            // 
            this.settings_manualupdatecheck.Location = new System.Drawing.Point(3, 149);
            this.settings_manualupdatecheck.Name = "settings_manualupdatecheck";
            this.settings_manualupdatecheck.Size = new System.Drawing.Size(235, 20);
            this.settings_manualupdatecheck.TabIndex = 19;
            this.settings_manualupdatecheck.Text = "Manual update check";
            this.settings_manualupdatecheck.UseSelectable = true;
            this.settings_manualupdatecheck.Click += new System.EventHandler(this.settings_manualupdatecheck_Click);
            // 
            // settings_videoplayersettings
            // 
            this.settings_videoplayersettings.AutoSize = true;
            this.settings_videoplayersettings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_videoplayersettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_videoplayersettings.Location = new System.Drawing.Point(3, 172);
            this.settings_videoplayersettings.Name = "settings_videoplayersettings";
            this.settings_videoplayersettings.Size = new System.Drawing.Size(266, 25);
            this.settings_videoplayersettings.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_videoplayersettings.TabIndex = 6;
            this.settings_videoplayersettings.Text = "Video player and playlists settings";
            // 
            // settings_stretchtofit
            // 
            this.settings_stretchtofit.AutoSize = true;
            this.settings_stretchtofit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings_stretchtofit.Location = new System.Drawing.Point(3, 200);
            this.settings_stretchtofit.Name = "settings_stretchtofit";
            this.settings_stretchtofit.Size = new System.Drawing.Size(197, 15);
            this.settings_stretchtofit.TabIndex = 13;
            this.settings_stretchtofit.Text = "Stretch the video to fit the screen";
            this.settings_stretchtofit.UseSelectable = true;
            this.settings_stretchtofit.CheckedChanged += new System.EventHandler(this.settings_stretchtofit_CheckedChanged);
            // 
            // settings_sortvideolist
            // 
            this.settings_sortvideolist.AutoSize = true;
            this.settings_sortvideolist.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings_sortvideolist.Location = new System.Drawing.Point(3, 221);
            this.settings_sortvideolist.Name = "settings_sortvideolist";
            this.settings_sortvideolist.Size = new System.Drawing.Size(201, 15);
            this.settings_sortvideolist.TabIndex = 12;
            this.settings_sortvideolist.Text = "Sort the list of videos and playlists";
            this.settings_sortvideolist.UseSelectable = true;
            this.settings_sortvideolist.CheckedChanged += new System.EventHandler(this.settings_sortvideolist_CheckedChanged);
            // 
            // settings_sortvideolisttype
            // 
            this.settings_sortvideolisttype.DropDownHeight = 100;
            this.settings_sortvideolisttype.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.settings_sortvideolisttype.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.settings_sortvideolisttype.FormattingEnabled = true;
            this.settings_sortvideolisttype.IntegralHeight = false;
            this.settings_sortvideolisttype.ItemHeight = 19;
            this.settings_sortvideolisttype.Items.AddRange(new object[] {
            "English",
            "French",
            "German",
            "Spanish"});
            this.settings_sortvideolisttype.Location = new System.Drawing.Point(3, 242);
            this.settings_sortvideolisttype.Name = "settings_sortvideolisttype";
            this.settings_sortvideolisttype.Size = new System.Drawing.Size(647, 25);
            this.settings_sortvideolisttype.TabIndex = 25;
            this.settings_sortvideolisttype.UseSelectable = true;
            this.settings_sortvideolisttype.Visible = false;
            this.settings_sortvideolisttype.SelectedIndexChanged += new System.EventHandler(this.settings_sortvideolisttype_SelectedIndexChanged);
            // 
            // settings_maxdropdownplaylists
            // 
            this.settings_maxdropdownplaylists.AllowDrop = true;
            this.settings_maxdropdownplaylists.AutoSize = true;
            this.settings_maxdropdownplaylists.Location = new System.Drawing.Point(3, 270);
            this.settings_maxdropdownplaylists.Name = "settings_maxdropdownplaylists";
            this.settings_maxdropdownplaylists.Size = new System.Drawing.Size(398, 19);
            this.settings_maxdropdownplaylists.TabIndex = 21;
            this.settings_maxdropdownplaylists.Text = "Maximum number of playlists displayed at the same time in the list";
            // 
            // settings_maxdropdownplaylistsstrack
            // 
            this.settings_maxdropdownplaylistsstrack.BackColor = System.Drawing.Color.Transparent;
            this.settings_maxdropdownplaylistsstrack.LargeChange = 1;
            this.settings_maxdropdownplaylistsstrack.Location = new System.Drawing.Point(3, 292);
            this.settings_maxdropdownplaylistsstrack.Maximum = 20;
            this.settings_maxdropdownplaylistsstrack.Minimum = 1;
            this.settings_maxdropdownplaylistsstrack.MouseWheelBarPartitions = 1;
            this.settings_maxdropdownplaylistsstrack.Name = "settings_maxdropdownplaylistsstrack";
            this.settings_maxdropdownplaylistsstrack.Size = new System.Drawing.Size(647, 23);
            this.settings_maxdropdownplaylistsstrack.TabIndex = 20;
            this.settings_maxdropdownplaylistsstrack.Text = "Track";
            this.settings_maxdropdownplaylistsstrack.Value = 10;
            this.settings_maxdropdownplaylistsstrack.ValueChanged += new System.EventHandler(this.settings_maxdropdownplaylistsstrack_ValueChanged);
            // 
            // settings_advancedsettings
            // 
            this.settings_advancedsettings.AutoSize = true;
            this.settings_advancedsettings.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_advancedsettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_advancedsettings.Location = new System.Drawing.Point(3, 318);
            this.settings_advancedsettings.Name = "settings_advancedsettings";
            this.settings_advancedsettings.Size = new System.Drawing.Size(149, 25);
            this.settings_advancedsettings.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_advancedsettings.TabIndex = 14;
            this.settings_advancedsettings.Text = "Advanced settings";
            // 
            // settings_showfiles
            // 
            this.settings_showfiles.Location = new System.Drawing.Point(3, 346);
            this.settings_showfiles.Name = "settings_showfiles";
            this.settings_showfiles.Size = new System.Drawing.Size(130, 20);
            this.settings_showfiles.TabIndex = 2;
            this.settings_showfiles.Text = "Show files";
            this.settings_showfiles.UseSelectable = true;
            this.settings_showfiles.Click += new System.EventHandler(this.settings_showfiles_Click);
            // 
            // settings_resetfiles
            // 
            this.settings_resetfiles.Location = new System.Drawing.Point(3, 372);
            this.settings_resetfiles.Name = "settings_resetfiles";
            this.settings_resetfiles.Size = new System.Drawing.Size(130, 20);
            this.settings_resetfiles.TabIndex = 15;
            this.settings_resetfiles.Text = "Reset files";
            this.settings_resetfiles.UseSelectable = true;
            this.settings_resetfiles.Click += new System.EventHandler(this.settings_resetfiles_Click);
            // 
            // settings_informations
            // 
            this.settings_informations.AutoSize = true;
            this.settings_informations.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_informations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_informations.Location = new System.Drawing.Point(3, 395);
            this.settings_informations.Name = "settings_informations";
            this.settings_informations.Size = new System.Drawing.Size(107, 25);
            this.settings_informations.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_informations.TabIndex = 22;
            this.settings_informations.Text = "Informations";
            // 
            // settings_numberofplaylists
            // 
            this.settings_numberofplaylists.AllowDrop = true;
            this.settings_numberofplaylists.AutoSize = true;
            this.settings_numberofplaylists.Location = new System.Drawing.Point(3, 420);
            this.settings_numberofplaylists.Name = "settings_numberofplaylists";
            this.settings_numberofplaylists.Size = new System.Drawing.Size(136, 19);
            this.settings_numberofplaylists.TabIndex = 23;
            this.settings_numberofplaylists.Text = "Number of playlists: 0";
            // 
            // settings_weightofplaylists
            // 
            this.settings_weightofplaylists.AllowDrop = true;
            this.settings_weightofplaylists.AutoSize = true;
            this.settings_weightofplaylists.Location = new System.Drawing.Point(3, 439);
            this.settings_weightofplaylists.Name = "settings_weightofplaylists";
            this.settings_weightofplaylists.Size = new System.Drawing.Size(128, 19);
            this.settings_weightofplaylists.TabIndex = 24;
            this.settings_weightofplaylists.Text = "Weight of playlists: 0";
            // 
            // WolfWatchInformations
            // 
            this.WolfWatchInformations.AllowDrop = true;
            this.WolfWatchInformations.AutoSize = true;
            this.WolfWatchInformations.Location = new System.Drawing.Point(3, 458);
            this.WolfWatchInformations.Name = "WolfWatchInformations";
            this.WolfWatchInformations.Size = new System.Drawing.Size(160, 133);
            this.WolfWatchInformations.TabIndex = 26;
            this.WolfWatchInformations.Text = "\r\n\r\nWolfWatch v1.5\nVideo player, open source\r\nCreated by ToWolf\r\n\r\nhttp://towolf." +
    "livehost.fr/";
            // 
            // tabAddPlaylist
            // 
            this.tabAddPlaylist.Controls.Add(this.addplaylist_cancel);
            this.tabAddPlaylist.Controls.Add(this.addplaylist_addplaylistbutton);
            this.tabAddPlaylist.Controls.Add(this.addplaylist_playlistname);
            this.tabAddPlaylist.Controls.Add(this.addplaylist_addplaylist);
            this.tabAddPlaylist.HorizontalScrollbarBarColor = true;
            this.tabAddPlaylist.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddPlaylist.HorizontalScrollbarSize = 10;
            this.tabAddPlaylist.Location = new System.Drawing.Point(4, 38);
            this.tabAddPlaylist.Name = "tabAddPlaylist";
            this.tabAddPlaylist.Size = new System.Drawing.Size(672, 358);
            this.tabAddPlaylist.TabIndex = 3;
            this.tabAddPlaylist.Text = "Add playlist";
            this.tabAddPlaylist.VerticalScrollbarBarColor = true;
            this.tabAddPlaylist.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddPlaylist.VerticalScrollbarSize = 10;
            // 
            // addplaylist_cancel
            // 
            this.addplaylist_cancel.Location = new System.Drawing.Point(139, 57);
            this.addplaylist_cancel.Name = "addplaylist_cancel";
            this.addplaylist_cancel.Size = new System.Drawing.Size(125, 23);
            this.addplaylist_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.addplaylist_cancel.TabIndex = 10;
            this.addplaylist_cancel.Text = "Cancel";
            this.addplaylist_cancel.UseSelectable = true;
            this.addplaylist_cancel.Click += new System.EventHandler(this.addplaylist_cancel_Click);
            // 
            // addplaylist_addplaylistbutton
            // 
            this.addplaylist_addplaylistbutton.Location = new System.Drawing.Point(3, 57);
            this.addplaylist_addplaylistbutton.Name = "addplaylist_addplaylistbutton";
            this.addplaylist_addplaylistbutton.Size = new System.Drawing.Size(125, 23);
            this.addplaylist_addplaylistbutton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addplaylist_addplaylistbutton.TabIndex = 9;
            this.addplaylist_addplaylistbutton.Text = "Add playlist";
            this.addplaylist_addplaylistbutton.UseSelectable = true;
            this.addplaylist_addplaylistbutton.Click += new System.EventHandler(this.addplaylist_addplaylistbutton_Click);
            // 
            // addplaylist_playlistname
            // 
            // 
            // 
            // 
            this.addplaylist_playlistname.CustomButton.Image = null;
            this.addplaylist_playlistname.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.addplaylist_playlistname.CustomButton.Name = "";
            this.addplaylist_playlistname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addplaylist_playlistname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addplaylist_playlistname.CustomButton.TabIndex = 1;
            this.addplaylist_playlistname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addplaylist_playlistname.CustomButton.UseSelectable = true;
            this.addplaylist_playlistname.CustomButton.Visible = false;
            this.addplaylist_playlistname.Lines = new string[0];
            this.addplaylist_playlistname.Location = new System.Drawing.Point(3, 28);
            this.addplaylist_playlistname.MaxLength = 32767;
            this.addplaylist_playlistname.Name = "addplaylist_playlistname";
            this.addplaylist_playlistname.PasswordChar = '\0';
            this.addplaylist_playlistname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addplaylist_playlistname.SelectedText = "";
            this.addplaylist_playlistname.SelectionLength = 0;
            this.addplaylist_playlistname.SelectionStart = 0;
            this.addplaylist_playlistname.ShortcutsEnabled = true;
            this.addplaylist_playlistname.Size = new System.Drawing.Size(261, 23);
            this.addplaylist_playlistname.TabIndex = 8;
            this.addplaylist_playlistname.UseSelectable = true;
            this.addplaylist_playlistname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addplaylist_playlistname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addplaylist_addplaylist
            // 
            this.addplaylist_addplaylist.AutoSize = true;
            this.addplaylist_addplaylist.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.addplaylist_addplaylist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addplaylist_addplaylist.Location = new System.Drawing.Point(3, 0);
            this.addplaylist_addplaylist.Name = "addplaylist_addplaylist";
            this.addplaylist_addplaylist.Size = new System.Drawing.Size(103, 25);
            this.addplaylist_addplaylist.Style = MetroFramework.MetroColorStyle.Black;
            this.addplaylist_addplaylist.TabIndex = 7;
            this.addplaylist_addplaylist.Text = "Add playlist:";
            // 
            // tabEditPlaylist
            // 
            this.tabEditPlaylist.Controls.Add(this.editplaylist_cancel);
            this.tabEditPlaylist.Controls.Add(this.editplaylist_editplaylistbutton);
            this.tabEditPlaylist.Controls.Add(this.editplaylist_playlistname);
            this.tabEditPlaylist.Controls.Add(this.editplaylist_editplaylist);
            this.tabEditPlaylist.HorizontalScrollbarBarColor = true;
            this.tabEditPlaylist.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEditPlaylist.HorizontalScrollbarSize = 10;
            this.tabEditPlaylist.Location = new System.Drawing.Point(4, 38);
            this.tabEditPlaylist.Name = "tabEditPlaylist";
            this.tabEditPlaylist.Size = new System.Drawing.Size(672, 358);
            this.tabEditPlaylist.TabIndex = 4;
            this.tabEditPlaylist.Text = "Edit playlist";
            this.tabEditPlaylist.VerticalScrollbarBarColor = true;
            this.tabEditPlaylist.VerticalScrollbarHighlightOnWheel = false;
            this.tabEditPlaylist.VerticalScrollbarSize = 10;
            // 
            // editplaylist_cancel
            // 
            this.editplaylist_cancel.Location = new System.Drawing.Point(139, 57);
            this.editplaylist_cancel.Name = "editplaylist_cancel";
            this.editplaylist_cancel.Size = new System.Drawing.Size(125, 23);
            this.editplaylist_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.editplaylist_cancel.TabIndex = 13;
            this.editplaylist_cancel.Text = "Cancel";
            this.editplaylist_cancel.UseSelectable = true;
            this.editplaylist_cancel.Click += new System.EventHandler(this.editplaylist_cancel_Click);
            // 
            // editplaylist_editplaylistbutton
            // 
            this.editplaylist_editplaylistbutton.Location = new System.Drawing.Point(3, 57);
            this.editplaylist_editplaylistbutton.Name = "editplaylist_editplaylistbutton";
            this.editplaylist_editplaylistbutton.Size = new System.Drawing.Size(125, 23);
            this.editplaylist_editplaylistbutton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editplaylist_editplaylistbutton.TabIndex = 12;
            this.editplaylist_editplaylistbutton.Text = "Edit playlist";
            this.editplaylist_editplaylistbutton.UseSelectable = true;
            this.editplaylist_editplaylistbutton.Click += new System.EventHandler(this.editplaylist_editplaylistbutton_Click);
            // 
            // editplaylist_playlistname
            // 
            // 
            // 
            // 
            this.editplaylist_playlistname.CustomButton.Image = null;
            this.editplaylist_playlistname.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.editplaylist_playlistname.CustomButton.Name = "";
            this.editplaylist_playlistname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.editplaylist_playlistname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editplaylist_playlistname.CustomButton.TabIndex = 1;
            this.editplaylist_playlistname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editplaylist_playlistname.CustomButton.UseSelectable = true;
            this.editplaylist_playlistname.CustomButton.Visible = false;
            this.editplaylist_playlistname.Lines = new string[0];
            this.editplaylist_playlistname.Location = new System.Drawing.Point(3, 28);
            this.editplaylist_playlistname.MaxLength = 32767;
            this.editplaylist_playlistname.Name = "editplaylist_playlistname";
            this.editplaylist_playlistname.PasswordChar = '\0';
            this.editplaylist_playlistname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editplaylist_playlistname.SelectedText = "";
            this.editplaylist_playlistname.SelectionLength = 0;
            this.editplaylist_playlistname.SelectionStart = 0;
            this.editplaylist_playlistname.ShortcutsEnabled = true;
            this.editplaylist_playlistname.Size = new System.Drawing.Size(261, 23);
            this.editplaylist_playlistname.TabIndex = 11;
            this.editplaylist_playlistname.UseSelectable = true;
            this.editplaylist_playlistname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editplaylist_playlistname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // editplaylist_editplaylist
            // 
            this.editplaylist_editplaylist.AutoSize = true;
            this.editplaylist_editplaylist.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.editplaylist_editplaylist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editplaylist_editplaylist.Location = new System.Drawing.Point(3, 0);
            this.editplaylist_editplaylist.Name = "editplaylist_editplaylist";
            this.editplaylist_editplaylist.Size = new System.Drawing.Size(100, 25);
            this.editplaylist_editplaylist.Style = MetroFramework.MetroColorStyle.Black;
            this.editplaylist_editplaylist.TabIndex = 7;
            this.editplaylist_editplaylist.Text = "Edit playlist:";
            // 
            // tabEditVideo
            // 
            this.tabEditVideo.Controls.Add(this.editvideo_videodescription);
            this.tabEditVideo.Controls.Add(this.editvideo_cancel);
            this.tabEditVideo.Controls.Add(this.editvideo_editvideobutton);
            this.tabEditVideo.Controls.Add(this.editvideo_videoname);
            this.tabEditVideo.Controls.Add(this.editvideo_editvideo);
            this.tabEditVideo.HorizontalScrollbarBarColor = true;
            this.tabEditVideo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEditVideo.HorizontalScrollbarSize = 10;
            this.tabEditVideo.Location = new System.Drawing.Point(4, 38);
            this.tabEditVideo.Name = "tabEditVideo";
            this.tabEditVideo.Size = new System.Drawing.Size(672, 358);
            this.tabEditVideo.TabIndex = 5;
            this.tabEditVideo.Text = "Edit video";
            this.tabEditVideo.VerticalScrollbarBarColor = true;
            this.tabEditVideo.VerticalScrollbarHighlightOnWheel = false;
            this.tabEditVideo.VerticalScrollbarSize = 10;
            // 
            // editvideo_videodescription
            // 
            // 
            // 
            // 
            this.editvideo_videodescription.CustomButton.Image = null;
            this.editvideo_videodescription.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.editvideo_videodescription.CustomButton.Name = "";
            this.editvideo_videodescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.editvideo_videodescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editvideo_videodescription.CustomButton.TabIndex = 1;
            this.editvideo_videodescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editvideo_videodescription.CustomButton.UseSelectable = true;
            this.editvideo_videodescription.CustomButton.Visible = false;
            this.editvideo_videodescription.Lines = new string[0];
            this.editvideo_videodescription.Location = new System.Drawing.Point(3, 57);
            this.editvideo_videodescription.MaxLength = 32767;
            this.editvideo_videodescription.Name = "editvideo_videodescription";
            this.editvideo_videodescription.PasswordChar = '\0';
            this.editvideo_videodescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editvideo_videodescription.SelectedText = "";
            this.editvideo_videodescription.SelectionLength = 0;
            this.editvideo_videodescription.SelectionStart = 0;
            this.editvideo_videodescription.ShortcutsEnabled = true;
            this.editvideo_videodescription.Size = new System.Drawing.Size(261, 23);
            this.editvideo_videodescription.TabIndex = 14;
            this.editvideo_videodescription.UseSelectable = true;
            this.editvideo_videodescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editvideo_videodescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // editvideo_cancel
            // 
            this.editvideo_cancel.Location = new System.Drawing.Point(139, 86);
            this.editvideo_cancel.Name = "editvideo_cancel";
            this.editvideo_cancel.Size = new System.Drawing.Size(125, 23);
            this.editvideo_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.editvideo_cancel.TabIndex = 13;
            this.editvideo_cancel.Text = "Cancel";
            this.editvideo_cancel.UseSelectable = true;
            this.editvideo_cancel.Click += new System.EventHandler(this.editvideo_cancel_Click);
            // 
            // editvideo_editvideobutton
            // 
            this.editvideo_editvideobutton.Location = new System.Drawing.Point(3, 86);
            this.editvideo_editvideobutton.Name = "editvideo_editvideobutton";
            this.editvideo_editvideobutton.Size = new System.Drawing.Size(125, 23);
            this.editvideo_editvideobutton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editvideo_editvideobutton.TabIndex = 12;
            this.editvideo_editvideobutton.Text = "Edit video";
            this.editvideo_editvideobutton.UseSelectable = true;
            this.editvideo_editvideobutton.Click += new System.EventHandler(this.editvideo_editvideobutton_Click);
            // 
            // editvideo_videoname
            // 
            // 
            // 
            // 
            this.editvideo_videoname.CustomButton.Image = null;
            this.editvideo_videoname.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.editvideo_videoname.CustomButton.Name = "";
            this.editvideo_videoname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.editvideo_videoname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.editvideo_videoname.CustomButton.TabIndex = 1;
            this.editvideo_videoname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.editvideo_videoname.CustomButton.UseSelectable = true;
            this.editvideo_videoname.CustomButton.Visible = false;
            this.editvideo_videoname.Lines = new string[0];
            this.editvideo_videoname.Location = new System.Drawing.Point(3, 28);
            this.editvideo_videoname.MaxLength = 32767;
            this.editvideo_videoname.Name = "editvideo_videoname";
            this.editvideo_videoname.PasswordChar = '\0';
            this.editvideo_videoname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.editvideo_videoname.SelectedText = "";
            this.editvideo_videoname.SelectionLength = 0;
            this.editvideo_videoname.SelectionStart = 0;
            this.editvideo_videoname.ShortcutsEnabled = true;
            this.editvideo_videoname.Size = new System.Drawing.Size(261, 23);
            this.editvideo_videoname.TabIndex = 11;
            this.editvideo_videoname.UseSelectable = true;
            this.editvideo_videoname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.editvideo_videoname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // editvideo_editvideo
            // 
            this.editvideo_editvideo.AutoSize = true;
            this.editvideo_editvideo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.editvideo_editvideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editvideo_editvideo.Location = new System.Drawing.Point(3, 0);
            this.editvideo_editvideo.Name = "editvideo_editvideo";
            this.editvideo_editvideo.Size = new System.Drawing.Size(90, 25);
            this.editvideo_editvideo.Style = MetroFramework.MetroColorStyle.Black;
            this.editvideo_editvideo.TabIndex = 7;
            this.editvideo_editvideo.Text = "Edit video:";
            // 
            // listContextMenu
            // 
            this.listContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playVideoToolStripMenuItem,
            this.addVideoToolStripMenuItem,
            this.removeVideoToolStripMenuItem,
            this.editVideoToolStripMenuItem,
            this.exportVideoToolStripMenuItem});
            this.listContextMenu.Name = "listContextMenu";
            this.listContextMenu.Size = new System.Drawing.Size(150, 114);
            // 
            // playVideoToolStripMenuItem
            // 
            this.playVideoToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.play;
            this.playVideoToolStripMenuItem.Name = "playVideoToolStripMenuItem";
            this.playVideoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playVideoToolStripMenuItem.Text = "Play video";
            this.playVideoToolStripMenuItem.Click += new System.EventHandler(this.playVideoToolStripMenuItem_Click);
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.add;
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addVideoToolStripMenuItem.Text = "Add video";
            this.addVideoToolStripMenuItem.Click += new System.EventHandler(this.addVideoToolStripMenuItem_Click);
            // 
            // removeVideoToolStripMenuItem
            // 
            this.removeVideoToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.remove;
            this.removeVideoToolStripMenuItem.Name = "removeVideoToolStripMenuItem";
            this.removeVideoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeVideoToolStripMenuItem.Text = "Remove video";
            this.removeVideoToolStripMenuItem.Click += new System.EventHandler(this.removeVideoToolStripMenuItem_Click);
            // 
            // editVideoToolStripMenuItem
            // 
            this.editVideoToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.edit;
            this.editVideoToolStripMenuItem.Name = "editVideoToolStripMenuItem";
            this.editVideoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editVideoToolStripMenuItem.Text = "Edit video";
            this.editVideoToolStripMenuItem.Click += new System.EventHandler(this.editVideoToolStripMenuItem_Click);
            // 
            // exportVideoToolStripMenuItem
            // 
            this.exportVideoToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.export;
            this.exportVideoToolStripMenuItem.Name = "exportVideoToolStripMenuItem";
            this.exportVideoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportVideoToolStripMenuItem.Text = "Export video";
            this.exportVideoToolStripMenuItem.Click += new System.EventHandler(this.exportVideoToolStripMenuItem_Click);
            // 
            // playlistContextMenu
            // 
            this.playlistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlaylistToolStripMenuItem,
            this.removePlaylistToolStripMenuItem,
            this.editPlaylistToolStripMenuItem,
            this.exportPlaylistToolStripMenuItem});
            this.playlistContextMenu.Name = "playlistContextMenu";
            this.playlistContextMenu.Size = new System.Drawing.Size(158, 92);
            // 
            // addPlaylistToolStripMenuItem
            // 
            this.addPlaylistToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.add;
            this.addPlaylistToolStripMenuItem.Name = "addPlaylistToolStripMenuItem";
            this.addPlaylistToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addPlaylistToolStripMenuItem.Text = "Add playlist";
            this.addPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addPlaylistToolStripMenuItem_Click);
            // 
            // removePlaylistToolStripMenuItem
            // 
            this.removePlaylistToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.remove;
            this.removePlaylistToolStripMenuItem.Name = "removePlaylistToolStripMenuItem";
            this.removePlaylistToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removePlaylistToolStripMenuItem.Text = "Remove playlist";
            this.removePlaylistToolStripMenuItem.Click += new System.EventHandler(this.removePlaylistToolStripMenuItem_Click);
            // 
            // editPlaylistToolStripMenuItem
            // 
            this.editPlaylistToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.edit;
            this.editPlaylistToolStripMenuItem.Name = "editPlaylistToolStripMenuItem";
            this.editPlaylistToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editPlaylistToolStripMenuItem.Text = "Edit playlist";
            this.editPlaylistToolStripMenuItem.Click += new System.EventHandler(this.editPlaylistToolStripMenuItem_Click);
            // 
            // exportPlaylistToolStripMenuItem
            // 
            this.exportPlaylistToolStripMenuItem.Image = global::WolfWatch.Properties.Resources.export;
            this.exportPlaylistToolStripMenuItem.Name = "exportPlaylistToolStripMenuItem";
            this.exportPlaylistToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportPlaylistToolStripMenuItem.Text = "Export playlist";
            this.exportPlaylistToolStripMenuItem.Click += new System.EventHandler(this.exportPlaylistToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Files|*.mp3; *.mp4; *.wav; *.mov; *.webm; *.mkv";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // WolfWatchMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.WWTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "WolfWatchMetro";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "WolfWatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WolfWatchMetro_FormClosing);
            this.WWTabControl.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.tabPlaylists.ResumeLayout(false);
            this.tabPlaylists.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.settings_generalsettingsflowlayoutpanel.ResumeLayout(false);
            this.settings_generalsettingsflowlayoutpanel.PerformLayout();
            this.tabAddPlaylist.ResumeLayout(false);
            this.tabAddPlaylist.PerformLayout();
            this.tabEditPlaylist.ResumeLayout(false);
            this.tabEditPlaylist.PerformLayout();
            this.tabEditVideo.ResumeLayout(false);
            this.tabEditVideo.PerformLayout();
            this.listContextMenu.ResumeLayout(false);
            this.playlistContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl WWTabControl;
        public MetroFramework.Controls.MetroTabPage tabPlayer;
        public MetroFramework.Controls.MetroTabPage tabPlaylists;
        public MetroFramework.Controls.MetroTabPage tabSettings;
        public MetroFramework.Controls.MetroLabel playlists_playlistslist;
        public MetroFramework.Controls.MetroComboBox playlistsList;
        public MetroFramework.Controls.MetroButton playlistsMenu;
        public MetroFramework.Controls.MetroLabel settings_lang;
        public System.Windows.Forms.FlowLayoutPanel settings_generalsettingsflowlayoutpanel;
        public MetroFramework.Controls.MetroLabel settings_generalsettings;
        public MetroFramework.Controls.MetroLabel settings_videoplayersettings;
        public MetroFramework.Controls.MetroTabPage tabAddPlaylist;
        public MetroFramework.Controls.MetroTabPage tabEditPlaylist;
        public MetroFramework.Controls.MetroTabPage tabEditVideo;
        public MetroFramework.Controls.MetroLabel addplaylist_addplaylist;
        public MetroFramework.Controls.MetroLabel editplaylist_editplaylist;
        public MetroFramework.Controls.MetroLabel editvideo_editvideo;
        public MetroFramework.Controls.MetroTextBox addplaylist_playlistname;
        public MetroFramework.Controls.MetroButton addplaylist_addplaylistbutton;
        public MetroFramework.Controls.MetroButton addplaylist_cancel;
        public MetroFramework.Controls.MetroButton editplaylist_cancel;
        public MetroFramework.Controls.MetroButton editplaylist_editplaylistbutton;
        public MetroFramework.Controls.MetroTextBox editplaylist_playlistname;
        public MetroFramework.Controls.MetroButton editvideo_cancel;
        public MetroFramework.Controls.MetroButton editvideo_editvideobutton;
        public MetroFramework.Controls.MetroTextBox editvideo_videoname;
        public MetroFramework.Controls.MetroContextMenu playlistContextMenu;
        public MetroFramework.Controls.MetroContextMenu listContextMenu;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removePlaylistToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editPlaylistToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exportPlaylistToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem playVideoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addVideoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeVideoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editVideoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exportVideoToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialog;
        public MetroFramework.Controls.MetroButton settings_showfiles;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        public MetroFramework.Controls.MetroCheckBox settings_autoupdates;
        public MetroFramework.Controls.MetroComboBox settings_langcombo;
        public MetroFramework.Controls.MetroCheckBox settings_stretchtofit;
        public MetroFramework.Controls.MetroCheckBox settings_sortvideolist;
        public MetroFramework.Controls.MetroLabel settings_advancedsettings;
        public MetroFramework.Controls.MetroButton settings_resetfiles;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        public MetroFramework.Controls.MetroLabel settings_theme;
        public MetroFramework.Controls.MetroComboBox settings_themecombo;
        public AxWMPLib.AxWindowsMediaPlayer WMP;
        public MetroFramework.Controls.MetroButton settings_manualupdatecheck;
        public MetroFramework.Controls.MetroTrackBar settings_maxdropdownplaylistsstrack;
        public MetroFramework.Controls.MetroLabel settings_maxdropdownplaylists;
        public MetroFramework.Controls.MetroLabel settings_informations;
        public MetroFramework.Controls.MetroLabel settings_numberofplaylists;
        public MetroFramework.Controls.MetroLabel settings_weightofplaylists;
        public System.Windows.Forms.ListView inListView;
        public System.Windows.Forms.ColumnHeader fileName;
        public System.Windows.Forms.ColumnHeader fileDescription;
        public System.Windows.Forms.ColumnHeader fileDuration;
        public MetroFramework.Controls.MetroComboBox settings_sortvideolisttype;
        public MetroFramework.Controls.MetroTextBox editvideo_videodescription;
        public MetroFramework.Controls.MetroLabel WolfWatchInformations;
    }
}