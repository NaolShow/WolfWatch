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
            this.playlistsMenu = new MetroFramework.Controls.MetroButton();
            this.playlistsList = new MetroFramework.Controls.MetroComboBox();
            this.playlists_playlistslist = new MetroFramework.Controls.MetroLabel();
            this.inPlaylistList = new System.Windows.Forms.ListBox();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.settings_showfiles = new MetroFramework.Controls.MetroButton();
            this.settings_videoplayersettingsgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_generalsettingsgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settings_stretchtofitpanel = new MetroFramework.Controls.MetroPanel();
            this.settings_stretchtofitgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_stretchtofit_switch = new MetroFramework.Controls.MetroToggle();
            this.settings_sortvideoslistpanel = new MetroFramework.Controls.MetroPanel();
            this.settings_sortvideoslistgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_sortvideoslist_switch = new MetroFramework.Controls.MetroToggle();
            this.settings_generalsettingsflowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settings_languagepanel = new MetroFramework.Controls.MetroPanel();
            this.settings_spanish = new MetroFramework.Controls.MetroRadioButton();
            this.settings_german = new MetroFramework.Controls.MetroRadioButton();
            this.settings_french = new MetroFramework.Controls.MetroRadioButton();
            this.settings_english = new MetroFramework.Controls.MetroRadioButton();
            this.settings_langgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_autoupdatespanel = new MetroFramework.Controls.MetroPanel();
            this.settings_autoupdatesgroupbox = new MetroFramework.Controls.MetroLabel();
            this.settings_autoupdates_switch = new MetroFramework.Controls.MetroToggle();
            this.tabAddPlaylist = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.addplaylist_addplaylistbutton = new MetroFramework.Controls.MetroButton();
            this.addplaylist_playlistname = new MetroFramework.Controls.MetroTextBox();
            this.addplaylist_addplaylist = new MetroFramework.Controls.MetroLabel();
            this.tabEditPlaylist = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.editplaylist_editplaylistbutton = new MetroFramework.Controls.MetroButton();
            this.editplaylist_playlistname = new MetroFramework.Controls.MetroTextBox();
            this.editplaylist_editplaylist = new MetroFramework.Controls.MetroLabel();
            this.tabEditVideo = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
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
            this.WWTabControl.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.tabPlaylists.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.SuspendLayout();
            this.settings_stretchtofitpanel.SuspendLayout();
            this.settings_sortvideoslistpanel.SuspendLayout();
            this.settings_generalsettingsflowlayoutpanel.SuspendLayout();
            this.settings_languagepanel.SuspendLayout();
            this.settings_autoupdatespanel.SuspendLayout();
            this.tabAddPlaylist.SuspendLayout();
            this.tabEditPlaylist.SuspendLayout();
            this.tabEditVideo.SuspendLayout();
            this.listContextMenu.SuspendLayout();
            this.playlistContextMenu.SuspendLayout();
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
            this.WWTabControl.SelectedIndex = 2;
            this.WWTabControl.Size = new System.Drawing.Size(680, 400);
            this.WWTabControl.TabIndex = 0;
            this.WWTabControl.UseSelectable = true;
            this.WWTabControl.SelectedIndexChanged += new System.EventHandler(this.WWTabControl_SelectedIndexChanged);
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
            this.tabPlaylists.Controls.Add(this.playlistsMenu);
            this.tabPlaylists.Controls.Add(this.playlistsList);
            this.tabPlaylists.Controls.Add(this.playlists_playlistslist);
            this.tabPlaylists.Controls.Add(this.inPlaylistList);
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
            // playlistsMenu
            // 
            this.playlistsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistsMenu.Location = new System.Drawing.Point(605, 31);
            this.playlistsMenu.Name = "playlistsMenu";
            this.playlistsMenu.Size = new System.Drawing.Size(64, 29);
            this.playlistsMenu.TabIndex = 5;
            this.playlistsMenu.Text = ". . .";
            this.playlistsMenu.UseSelectable = true;
            this.playlistsMenu.Click += new System.EventHandler(this.playlistsMenu_Click);
            // 
            // playlistsList
            // 
            this.playlistsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistsList.FormattingEnabled = true;
            this.playlistsList.ItemHeight = 23;
            this.playlistsList.Location = new System.Drawing.Point(389, 31);
            this.playlistsList.Name = "playlistsList";
            this.playlistsList.Size = new System.Drawing.Size(210, 29);
            this.playlistsList.TabIndex = 4;
            this.playlistsList.UseSelectable = true;
            this.playlistsList.SelectedIndexChanged += new System.EventHandler(this.playlistsList_SelectedIndexChanged);
            // 
            // playlists_playlistslist
            // 
            this.playlists_playlistslist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlists_playlistslist.AutoSize = true;
            this.playlists_playlistslist.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.playlists_playlistslist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playlists_playlistslist.Location = new System.Drawing.Point(389, 3);
            this.playlists_playlistslist.Name = "playlists_playlistslist";
            this.playlists_playlistslist.Size = new System.Drawing.Size(99, 25);
            this.playlists_playlistslist.Style = MetroFramework.MetroColorStyle.Black;
            this.playlists_playlistslist.TabIndex = 3;
            this.playlists_playlistslist.Text = "Playlists list:";
            // 
            // inPlaylistList
            // 
            this.inPlaylistList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inPlaylistList.FormattingEnabled = true;
            this.inPlaylistList.Location = new System.Drawing.Point(3, 3);
            this.inPlaylistList.Name = "inPlaylistList";
            this.inPlaylistList.Size = new System.Drawing.Size(380, 355);
            this.inPlaylistList.TabIndex = 2;
            this.inPlaylistList.DoubleClick += new System.EventHandler(this.inPlaylistList_DoubleClick);
            this.inPlaylistList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inPlaylistList_MouseDown);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.settings_showfiles);
            this.tabSettings.Controls.Add(this.settings_videoplayersettingsgroupbox);
            this.tabSettings.Controls.Add(this.settings_generalsettingsgroupbox);
            this.tabSettings.Controls.Add(this.settings_videoplayerandplaylistssettingsflowlayoutpanel);
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
            // settings_showfiles
            // 
            this.settings_showfiles.Location = new System.Drawing.Point(3, 332);
            this.settings_showfiles.Name = "settings_showfiles";
            this.settings_showfiles.Size = new System.Drawing.Size(130, 23);
            this.settings_showfiles.TabIndex = 2;
            this.settings_showfiles.Text = "Show files";
            this.settings_showfiles.UseSelectable = true;
            this.settings_showfiles.Click += new System.EventHandler(this.settings_showfiles_Click);
            // 
            // settings_videoplayersettingsgroupbox
            // 
            this.settings_videoplayersettingsgroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_videoplayersettingsgroupbox.AutoSize = true;
            this.settings_videoplayersettingsgroupbox.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_videoplayersettingsgroupbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_videoplayersettingsgroupbox.Location = new System.Drawing.Point(349, 8);
            this.settings_videoplayersettingsgroupbox.Name = "settings_videoplayersettingsgroupbox";
            this.settings_videoplayersettingsgroupbox.Size = new System.Drawing.Size(266, 25);
            this.settings_videoplayersettingsgroupbox.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_videoplayersettingsgroupbox.TabIndex = 6;
            this.settings_videoplayersettingsgroupbox.Text = "Video player and playlists settings";
            // 
            // settings_generalsettingsgroupbox
            // 
            this.settings_generalsettingsgroupbox.AutoSize = true;
            this.settings_generalsettingsgroupbox.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settings_generalsettingsgroupbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings_generalsettingsgroupbox.Location = new System.Drawing.Point(0, 8);
            this.settings_generalsettingsgroupbox.Name = "settings_generalsettingsgroupbox";
            this.settings_generalsettingsgroupbox.Size = new System.Drawing.Size(133, 25);
            this.settings_generalsettingsgroupbox.Style = MetroFramework.MetroColorStyle.Black;
            this.settings_generalsettingsgroupbox.TabIndex = 5;
            this.settings_generalsettingsgroupbox.Text = "General settings";
            // 
            // settings_videoplayerandplaylistssettingsflowlayoutpanel
            // 
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.BackColor = System.Drawing.Color.Transparent;
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Controls.Add(this.settings_stretchtofitpanel);
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Controls.Add(this.settings_sortvideoslistpanel);
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Location = new System.Drawing.Point(349, 36);
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Name = "settings_videoplayerandplaylistssettingsflowlayoutpanel";
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.Size = new System.Drawing.Size(320, 319);
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.TabIndex = 5;
            // 
            // settings_stretchtofitpanel
            // 
            this.settings_stretchtofitpanel.Controls.Add(this.settings_stretchtofitgroupbox);
            this.settings_stretchtofitpanel.Controls.Add(this.settings_stretchtofit_switch);
            this.settings_stretchtofitpanel.HorizontalScrollbarBarColor = true;
            this.settings_stretchtofitpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.settings_stretchtofitpanel.HorizontalScrollbarSize = 10;
            this.settings_stretchtofitpanel.Location = new System.Drawing.Point(3, 3);
            this.settings_stretchtofitpanel.Name = "settings_stretchtofitpanel";
            this.settings_stretchtofitpanel.Size = new System.Drawing.Size(148, 67);
            this.settings_stretchtofitpanel.TabIndex = 8;
            this.settings_stretchtofitpanel.VerticalScrollbarBarColor = true;
            this.settings_stretchtofitpanel.VerticalScrollbarHighlightOnWheel = false;
            this.settings_stretchtofitpanel.VerticalScrollbarSize = 10;
            // 
            // settings_stretchtofitgroupbox
            // 
            this.settings_stretchtofitgroupbox.AutoSize = true;
            this.settings_stretchtofitgroupbox.Location = new System.Drawing.Point(3, 9);
            this.settings_stretchtofitgroupbox.Name = "settings_stretchtofitgroupbox";
            this.settings_stretchtofitgroupbox.Size = new System.Drawing.Size(80, 19);
            this.settings_stretchtofitgroupbox.TabIndex = 7;
            this.settings_stretchtofitgroupbox.Text = "Stretch to fit";
            // 
            // settings_stretchtofit_switch
            // 
            this.settings_stretchtofit_switch.AutoSize = true;
            this.settings_stretchtofit_switch.Location = new System.Drawing.Point(3, 31);
            this.settings_stretchtofit_switch.Name = "settings_stretchtofit_switch";
            this.settings_stretchtofit_switch.Size = new System.Drawing.Size(80, 17);
            this.settings_stretchtofit_switch.TabIndex = 2;
            this.settings_stretchtofit_switch.Text = "Off";
            this.settings_stretchtofit_switch.UseSelectable = true;
            this.settings_stretchtofit_switch.CheckedChanged += new System.EventHandler(this.settings_stretchtofit_switch_CheckedChanged);
            // 
            // settings_sortvideoslistpanel
            // 
            this.settings_sortvideoslistpanel.Controls.Add(this.settings_sortvideoslistgroupbox);
            this.settings_sortvideoslistpanel.Controls.Add(this.settings_sortvideoslist_switch);
            this.settings_sortvideoslistpanel.HorizontalScrollbarBarColor = true;
            this.settings_sortvideoslistpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.settings_sortvideoslistpanel.HorizontalScrollbarSize = 10;
            this.settings_sortvideoslistpanel.Location = new System.Drawing.Point(157, 3);
            this.settings_sortvideoslistpanel.Name = "settings_sortvideoslistpanel";
            this.settings_sortvideoslistpanel.Size = new System.Drawing.Size(143, 67);
            this.settings_sortvideoslistpanel.TabIndex = 8;
            this.settings_sortvideoslistpanel.VerticalScrollbarBarColor = true;
            this.settings_sortvideoslistpanel.VerticalScrollbarHighlightOnWheel = false;
            this.settings_sortvideoslistpanel.VerticalScrollbarSize = 10;
            // 
            // settings_sortvideoslistgroupbox
            // 
            this.settings_sortvideoslistgroupbox.AutoSize = true;
            this.settings_sortvideoslistgroupbox.Location = new System.Drawing.Point(3, 9);
            this.settings_sortvideoslistgroupbox.Name = "settings_sortvideoslistgroupbox";
            this.settings_sortvideoslistgroupbox.Size = new System.Drawing.Size(94, 19);
            this.settings_sortvideoslistgroupbox.TabIndex = 7;
            this.settings_sortvideoslistgroupbox.Text = "Sort videos list";
            // 
            // settings_sortvideoslist_switch
            // 
            this.settings_sortvideoslist_switch.AutoSize = true;
            this.settings_sortvideoslist_switch.Location = new System.Drawing.Point(3, 31);
            this.settings_sortvideoslist_switch.Name = "settings_sortvideoslist_switch";
            this.settings_sortvideoslist_switch.Size = new System.Drawing.Size(80, 17);
            this.settings_sortvideoslist_switch.TabIndex = 2;
            this.settings_sortvideoslist_switch.Text = "Off";
            this.settings_sortvideoslist_switch.UseSelectable = true;
            this.settings_sortvideoslist_switch.CheckedChanged += new System.EventHandler(this.settings_sortvideoslist_switch_CheckedChanged);
            // 
            // settings_generalsettingsflowlayoutpanel
            // 
            this.settings_generalsettingsflowlayoutpanel.BackColor = System.Drawing.Color.Transparent;
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_languagepanel);
            this.settings_generalsettingsflowlayoutpanel.Controls.Add(this.settings_autoupdatespanel);
            this.settings_generalsettingsflowlayoutpanel.Location = new System.Drawing.Point(3, 36);
            this.settings_generalsettingsflowlayoutpanel.Name = "settings_generalsettingsflowlayoutpanel";
            this.settings_generalsettingsflowlayoutpanel.Size = new System.Drawing.Size(324, 290);
            this.settings_generalsettingsflowlayoutpanel.TabIndex = 4;
            // 
            // settings_languagepanel
            // 
            this.settings_languagepanel.Controls.Add(this.settings_spanish);
            this.settings_languagepanel.Controls.Add(this.settings_german);
            this.settings_languagepanel.Controls.Add(this.settings_french);
            this.settings_languagepanel.Controls.Add(this.settings_english);
            this.settings_languagepanel.Controls.Add(this.settings_langgroupbox);
            this.settings_languagepanel.HorizontalScrollbarBarColor = true;
            this.settings_languagepanel.HorizontalScrollbarHighlightOnWheel = false;
            this.settings_languagepanel.HorizontalScrollbarSize = 10;
            this.settings_languagepanel.Location = new System.Drawing.Point(3, 3);
            this.settings_languagepanel.Name = "settings_languagepanel";
            this.settings_languagepanel.Size = new System.Drawing.Size(84, 117);
            this.settings_languagepanel.TabIndex = 3;
            this.settings_languagepanel.VerticalScrollbarBarColor = true;
            this.settings_languagepanel.VerticalScrollbarHighlightOnWheel = false;
            this.settings_languagepanel.VerticalScrollbarSize = 10;
            // 
            // settings_spanish
            // 
            this.settings_spanish.AutoSize = true;
            this.settings_spanish.Location = new System.Drawing.Point(3, 94);
            this.settings_spanish.Name = "settings_spanish";
            this.settings_spanish.Size = new System.Drawing.Size(64, 15);
            this.settings_spanish.TabIndex = 6;
            this.settings_spanish.Text = "Spanish";
            this.settings_spanish.UseSelectable = true;
            this.settings_spanish.CheckedChanged += new System.EventHandler(this.settings_spanish_CheckedChanged);
            // 
            // settings_german
            // 
            this.settings_german.AutoSize = true;
            this.settings_german.Location = new System.Drawing.Point(3, 73);
            this.settings_german.Name = "settings_german";
            this.settings_german.Size = new System.Drawing.Size(65, 15);
            this.settings_german.TabIndex = 5;
            this.settings_german.Text = "German";
            this.settings_german.UseSelectable = true;
            this.settings_german.CheckedChanged += new System.EventHandler(this.settings_german_CheckedChanged);
            // 
            // settings_french
            // 
            this.settings_french.AutoSize = true;
            this.settings_french.Location = new System.Drawing.Point(3, 52);
            this.settings_french.Name = "settings_french";
            this.settings_french.Size = new System.Drawing.Size(59, 15);
            this.settings_french.TabIndex = 4;
            this.settings_french.Text = "French";
            this.settings_french.UseSelectable = true;
            this.settings_french.CheckedChanged += new System.EventHandler(this.settings_french_CheckedChanged);
            // 
            // settings_english
            // 
            this.settings_english.AutoSize = true;
            this.settings_english.Checked = true;
            this.settings_english.Location = new System.Drawing.Point(3, 31);
            this.settings_english.Name = "settings_english";
            this.settings_english.Size = new System.Drawing.Size(61, 15);
            this.settings_english.TabIndex = 3;
            this.settings_english.TabStop = true;
            this.settings_english.Text = "English";
            this.settings_english.UseSelectable = true;
            this.settings_english.CheckedChanged += new System.EventHandler(this.settings_english_CheckedChanged);
            // 
            // settings_langgroupbox
            // 
            this.settings_langgroupbox.AutoSize = true;
            this.settings_langgroupbox.Location = new System.Drawing.Point(3, 9);
            this.settings_langgroupbox.Name = "settings_langgroupbox";
            this.settings_langgroupbox.Size = new System.Drawing.Size(66, 19);
            this.settings_langgroupbox.TabIndex = 2;
            this.settings_langgroupbox.Text = "Language";
            // 
            // settings_autoupdatespanel
            // 
            this.settings_autoupdatespanel.Controls.Add(this.settings_autoupdatesgroupbox);
            this.settings_autoupdatespanel.Controls.Add(this.settings_autoupdates_switch);
            this.settings_autoupdatespanel.HorizontalScrollbarBarColor = true;
            this.settings_autoupdatespanel.HorizontalScrollbarHighlightOnWheel = false;
            this.settings_autoupdatespanel.HorizontalScrollbarSize = 10;
            this.settings_autoupdatespanel.Location = new System.Drawing.Point(93, 3);
            this.settings_autoupdatespanel.Name = "settings_autoupdatespanel";
            this.settings_autoupdatespanel.Size = new System.Drawing.Size(165, 67);
            this.settings_autoupdatespanel.TabIndex = 4;
            this.settings_autoupdatespanel.VerticalScrollbarBarColor = true;
            this.settings_autoupdatespanel.VerticalScrollbarHighlightOnWheel = false;
            this.settings_autoupdatespanel.VerticalScrollbarSize = 10;
            // 
            // settings_autoupdatesgroupbox
            // 
            this.settings_autoupdatesgroupbox.AutoSize = true;
            this.settings_autoupdatesgroupbox.Location = new System.Drawing.Point(3, 9);
            this.settings_autoupdatesgroupbox.Name = "settings_autoupdatesgroupbox";
            this.settings_autoupdatesgroupbox.Size = new System.Drawing.Size(87, 19);
            this.settings_autoupdatesgroupbox.TabIndex = 7;
            this.settings_autoupdatesgroupbox.Text = "Auto updates";
            // 
            // settings_autoupdates_switch
            // 
            this.settings_autoupdates_switch.AutoSize = true;
            this.settings_autoupdates_switch.Location = new System.Drawing.Point(3, 31);
            this.settings_autoupdates_switch.Name = "settings_autoupdates_switch";
            this.settings_autoupdates_switch.Size = new System.Drawing.Size(80, 17);
            this.settings_autoupdates_switch.TabIndex = 2;
            this.settings_autoupdates_switch.Text = "Off";
            this.settings_autoupdates_switch.UseSelectable = true;
            this.settings_autoupdates_switch.CheckedChanged += new System.EventHandler(this.settings_autoupdates_switch_CheckedChanged);
            // 
            // tabAddPlaylist
            // 
            this.tabAddPlaylist.Controls.Add(this.metroButton2);
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
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(139, 57);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(125, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
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
            this.addplaylist_playlistname.Lines = new string[] {
        "Playlist name"};
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
            this.addplaylist_playlistname.Text = "Playlist name";
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
            this.tabEditPlaylist.Controls.Add(this.metroButton3);
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
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(139, 57);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(125, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.UseSelectable = true;
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
            this.editplaylist_playlistname.Lines = new string[] {
        "Playlist name"};
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
            this.editplaylist_playlistname.Text = "Playlist name";
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
            this.tabEditVideo.Controls.Add(this.metroButton5);
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
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(139, 57);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(125, 23);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Cancel";
            this.metroButton5.UseSelectable = true;
            // 
            // editvideo_editvideobutton
            // 
            this.editvideo_editvideobutton.Location = new System.Drawing.Point(3, 57);
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
            this.editvideo_videoname.Lines = new string[] {
        "Video name"};
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
            this.editvideo_videoname.Text = "Video name";
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
            this.playlistContextMenu.Size = new System.Drawing.Size(158, 114);
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
            this.openFileDialog.Filter = "File|*.mp3; *.mp4; *.wav; *.mov; *.webm; *..mkv";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
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
            this.Text = "WolfWatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WolfWatchMetro_FormClosed);
            this.WWTabControl.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.tabPlaylists.ResumeLayout(false);
            this.tabPlaylists.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.settings_videoplayerandplaylistssettingsflowlayoutpanel.ResumeLayout(false);
            this.settings_stretchtofitpanel.ResumeLayout(false);
            this.settings_stretchtofitpanel.PerformLayout();
            this.settings_sortvideoslistpanel.ResumeLayout(false);
            this.settings_sortvideoslistpanel.PerformLayout();
            this.settings_generalsettingsflowlayoutpanel.ResumeLayout(false);
            this.settings_languagepanel.ResumeLayout(false);
            this.settings_languagepanel.PerformLayout();
            this.settings_autoupdatespanel.ResumeLayout(false);
            this.settings_autoupdatespanel.PerformLayout();
            this.tabAddPlaylist.ResumeLayout(false);
            this.tabAddPlaylist.PerformLayout();
            this.tabEditPlaylist.ResumeLayout(false);
            this.tabEditPlaylist.PerformLayout();
            this.tabEditVideo.ResumeLayout(false);
            this.tabEditVideo.PerformLayout();
            this.listContextMenu.ResumeLayout(false);
            this.playlistContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl WWTabControl;
        private MetroFramework.Controls.MetroTabPage tabPlayer;
        private MetroFramework.Controls.MetroTabPage tabPlaylists;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private System.Windows.Forms.ListBox inPlaylistList;
        private MetroFramework.Controls.MetroLabel playlists_playlistslist;
        private MetroFramework.Controls.MetroComboBox playlistsList;
        private MetroFramework.Controls.MetroButton playlistsMenu;
        private MetroFramework.Controls.MetroLabel settings_langgroupbox;
        private MetroFramework.Controls.MetroPanel settings_languagepanel;
        private MetroFramework.Controls.MetroRadioButton settings_spanish;
        private MetroFramework.Controls.MetroRadioButton settings_german;
        private MetroFramework.Controls.MetroRadioButton settings_french;
        private MetroFramework.Controls.MetroRadioButton settings_english;
        private System.Windows.Forms.FlowLayoutPanel settings_generalsettingsflowlayoutpanel;
        private MetroFramework.Controls.MetroLabel settings_generalsettingsgroupbox;
        private System.Windows.Forms.FlowLayoutPanel settings_videoplayerandplaylistssettingsflowlayoutpanel;
        private MetroFramework.Controls.MetroPanel settings_autoupdatespanel;
        private MetroFramework.Controls.MetroLabel settings_autoupdatesgroupbox;
        private MetroFramework.Controls.MetroToggle settings_autoupdates_switch;
        private MetroFramework.Controls.MetroPanel settings_stretchtofitpanel;
        private MetroFramework.Controls.MetroLabel settings_stretchtofitgroupbox;
        private MetroFramework.Controls.MetroToggle settings_stretchtofit_switch;
        private MetroFramework.Controls.MetroPanel settings_sortvideoslistpanel;
        private MetroFramework.Controls.MetroLabel settings_sortvideoslistgroupbox;
        private MetroFramework.Controls.MetroToggle settings_sortvideoslist_switch;
        private MetroFramework.Controls.MetroLabel settings_videoplayersettingsgroupbox;
        private MetroFramework.Controls.MetroTabPage tabAddPlaylist;
        private MetroFramework.Controls.MetroTabPage tabEditPlaylist;
        private MetroFramework.Controls.MetroTabPage tabEditVideo;
        private MetroFramework.Controls.MetroLabel addplaylist_addplaylist;
        private MetroFramework.Controls.MetroLabel editplaylist_editplaylist;
        private MetroFramework.Controls.MetroLabel editvideo_editvideo;
        private MetroFramework.Controls.MetroTextBox addplaylist_playlistname;
        private MetroFramework.Controls.MetroButton addplaylist_addplaylistbutton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton editplaylist_editplaylistbutton;
        private MetroFramework.Controls.MetroTextBox editplaylist_playlistname;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton editvideo_editvideobutton;
        private MetroFramework.Controls.MetroTextBox editvideo_videoname;
        private MetroFramework.Controls.MetroContextMenu playlistContextMenu;
        private MetroFramework.Controls.MetroContextMenu listContextMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportVideoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MetroFramework.Controls.MetroButton settings_showfiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}