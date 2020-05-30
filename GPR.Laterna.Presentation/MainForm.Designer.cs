namespace GPR.Laterna.Presentation
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnPlaylist = new FontAwesome.Sharp.IconButton();
            this.btnTrack = new FontAwesome.Sharp.IconButton();
            this.btnAlbum = new FontAwesome.Sharp.IconButton();
            this.btnArtist = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMyProfile = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExpand = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.TitleChildHomeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgwTrack = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgwArtist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgwAlbums = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnTrackShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlbumShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnArtistShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleChildHomeBtn)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.btnTrack);
            this.panelMenu.Controls.Add(this.btnAlbum);
            this.panelMenu.Controls.Add(this.btnArtist);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 583);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(220, 60);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 440);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Rotation = 0D;
            this.btnLogOut.Size = new System.Drawing.Size(220, 60);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconSize = 32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 380);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUser.Rotation = 0D;
            this.btnUser.Size = new System.Drawing.Size(220, 60);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Profilim";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlaylist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.IconSize = 32;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 320);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlaylist.Rotation = 0D;
            this.btnPlaylist.Size = new System.Drawing.Size(220, 60);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Playlistler";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrack.FlatAppearance.BorderSize = 0;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTrack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrack.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnTrack.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTrack.IconSize = 32;
            this.btnTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.Location = new System.Drawing.Point(0, 260);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrack.Rotation = 0D;
            this.btnTrack.Size = new System.Drawing.Size(220, 60);
            this.btnTrack.TabIndex = 3;
            this.btnTrack.Text = "Şarkılar";
            this.btnTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlbum.FlatAppearance.BorderSize = 0;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbum.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlbum.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlbum.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.btnAlbum.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAlbum.IconSize = 32;
            this.btnAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.Location = new System.Drawing.Point(0, 200);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlbum.Rotation = 0D;
            this.btnAlbum.Size = new System.Drawing.Size(220, 60);
            this.btnAlbum.TabIndex = 2;
            this.btnAlbum.Text = "Albümler";
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnArtist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtist.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.btnArtist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnArtist.IconSize = 32;
            this.btnArtist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.Location = new System.Drawing.Point(0, 140);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnArtist.Rotation = 0D;
            this.btnArtist.Size = new System.Drawing.Size(220, 60);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Şarkıcılar";
            this.btnArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GPR.Laterna.Presentation.Properties.Resources.laterna111;
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.btnMyProfile);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnExpand);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.TitleChildHomeBtn);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(983, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMyProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnMyProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMyProfile.IconSize = 32;
            this.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.Location = new System.Drawing.Point(726, 3);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMyProfile.Rotation = 0D;
            this.btnMyProfile.Size = new System.Drawing.Size(136, 42);
            this.btnMyProfile.TabIndex = 6;
            this.btnMyProfile.Text = "Profilim";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 23;
            this.btnMinimize.Location = new System.Drawing.Point(868, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 23);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnExpand.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExpand.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnExpand.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExpand.IconSize = 23;
            this.btnExpand.Location = new System.Drawing.Point(906, 12);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(24, 23);
            this.btnExpand.TabIndex = 3;
            this.btnExpand.TabStop = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(944, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitBtn_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(89, 35);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(94, 24);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Ana Sayfa";
            // 
            // TitleChildHomeBtn
            // 
            this.TitleChildHomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.TitleChildHomeBtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.TitleChildHomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.TitleChildHomeBtn.IconColor = System.Drawing.Color.MediumPurple;
            this.TitleChildHomeBtn.IconSize = 55;
            this.TitleChildHomeBtn.Location = new System.Drawing.Point(33, 20);
            this.TitleChildHomeBtn.Name = "TitleChildHomeBtn";
            this.TitleChildHomeBtn.Size = new System.Drawing.Size(63, 55);
            this.TitleChildHomeBtn.TabIndex = 0;
            this.TitleChildHomeBtn.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(983, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.bunifuCustomLabel4);
            this.panelDesktop.Controls.Add(this.bunifuCustomLabel3);
            this.panelDesktop.Controls.Add(this.bunifuCustomLabel2);
            this.panelDesktop.Controls.Add(this.dgwTrack);
            this.panelDesktop.Controls.Add(this.dgwArtist);
            this.panelDesktop.Controls.Add(this.dgwAlbums);
            this.panelDesktop.Controls.Add(this.btnTrackShow);
            this.panelDesktop.Controls.Add(this.btnAlbumShow);
            this.panelDesktop.Controls.Add(this.btnArtistShow);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(983, 499);
            this.panelDesktop.TabIndex = 4;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(749, 94);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 42);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Şarkılar";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(420, 94);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(153, 42);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Albümler";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(86, 94);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 42);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Şarkıcılar";
            // 
            // dgwTrack
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwTrack.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTrack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgwTrack.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwTrack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTrack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTrack.ColumnHeadersHeight = 35;
            this.dgwTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwTrack.DoubleBuffered = true;
            this.dgwTrack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTrack.EnableHeadersVisualStyles = false;
            this.dgwTrack.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderForeColor = System.Drawing.Color.White;
            this.dgwTrack.Location = new System.Drawing.Point(663, 146);
            this.dgwTrack.Margin = new System.Windows.Forms.Padding(10);
            this.dgwTrack.Name = "dgwTrack";
            this.dgwTrack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwTrack.RowHeadersWidth = 40;
            this.dgwTrack.RowTemplate.Height = 40;
            this.dgwTrack.Size = new System.Drawing.Size(300, 150);
            this.dgwTrack.TabIndex = 8;
            this.dgwTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTracks_CellClick);
            // 
            // dgwArtist
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwArtist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwArtist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgwArtist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwArtist.ColumnHeadersHeight = 35;
            this.dgwArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwArtist.DoubleBuffered = true;
            this.dgwArtist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwArtist.EnableHeadersVisualStyles = false;
            this.dgwArtist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderForeColor = System.Drawing.Color.White;
            this.dgwArtist.Location = new System.Drawing.Point(22, 146);
            this.dgwArtist.Margin = new System.Windows.Forms.Padding(10);
            this.dgwArtist.Name = "dgwArtist";
            this.dgwArtist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwArtist.RowHeadersWidth = 40;
            this.dgwArtist.RowTemplate.Height = 40;
            this.dgwArtist.Size = new System.Drawing.Size(300, 150);
            this.dgwArtist.TabIndex = 7;
            this.dgwArtist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArtist_CellClick);
            // 
            // dgwAlbums
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwAlbums.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgwAlbums.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwAlbums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwAlbums.ColumnHeadersHeight = 35;
            this.dgwAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwAlbums.DoubleBuffered = true;
            this.dgwAlbums.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwAlbums.EnableHeadersVisualStyles = false;
            this.dgwAlbums.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.dgwAlbums.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.dgwAlbums.HeaderForeColor = System.Drawing.Color.White;
            this.dgwAlbums.Location = new System.Drawing.Point(343, 146);
            this.dgwAlbums.Margin = new System.Windows.Forms.Padding(10);
            this.dgwAlbums.Name = "dgwAlbums";
            this.dgwAlbums.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwAlbums.RowHeadersWidth = 40;
            this.dgwAlbums.RowTemplate.Height = 40;
            this.dgwAlbums.Size = new System.Drawing.Size(300, 150);
            this.dgwAlbums.TabIndex = 6;
            this.dgwAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAlbums_CellClick);
            // 
            // btnTrackShow
            // 
            this.btnTrackShow.ActiveBorderThickness = 1;
            this.btnTrackShow.ActiveCornerRadius = 20;
            this.btnTrackShow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackShow.ActiveForecolor = System.Drawing.Color.White;
            this.btnTrackShow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrackShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnTrackShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrackShow.BackgroundImage")));
            this.btnTrackShow.ButtonText = "Daha Fazla";
            this.btnTrackShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrackShow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnTrackShow.IdleBorderThickness = 2;
            this.btnTrackShow.IdleCornerRadius = 20;
            this.btnTrackShow.IdleFillColor = System.Drawing.Color.White;
            this.btnTrackShow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackShow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackShow.Location = new System.Drawing.Point(716, 335);
            this.btnTrackShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackShow.Name = "btnTrackShow";
            this.btnTrackShow.Size = new System.Drawing.Size(191, 47);
            this.btnTrackShow.TabIndex = 5;
            this.btnTrackShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrackShow.Click += new System.EventHandler(this.btnTrackShow_Click);
            // 
            // btnAlbumShow
            // 
            this.btnAlbumShow.ActiveBorderThickness = 1;
            this.btnAlbumShow.ActiveCornerRadius = 20;
            this.btnAlbumShow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnAlbumShow.ActiveForecolor = System.Drawing.Color.White;
            this.btnAlbumShow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnAlbumShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlbumShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAlbumShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlbumShow.BackgroundImage")));
            this.btnAlbumShow.ButtonText = "Daha Fazla";
            this.btnAlbumShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbumShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlbumShow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAlbumShow.IdleBorderThickness = 2;
            this.btnAlbumShow.IdleCornerRadius = 20;
            this.btnAlbumShow.IdleFillColor = System.Drawing.Color.White;
            this.btnAlbumShow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnAlbumShow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnAlbumShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlbumShow.Location = new System.Drawing.Point(386, 335);
            this.btnAlbumShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlbumShow.Name = "btnAlbumShow";
            this.btnAlbumShow.Size = new System.Drawing.Size(191, 47);
            this.btnAlbumShow.TabIndex = 4;
            this.btnAlbumShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlbumShow.Click += new System.EventHandler(this.btnAlbumShow_Click);
            // 
            // btnArtistShow
            // 
            this.btnArtistShow.ActiveBorderThickness = 1;
            this.btnArtistShow.ActiveCornerRadius = 20;
            this.btnArtistShow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistShow.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistShow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArtistShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnArtistShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArtistShow.BackgroundImage")));
            this.btnArtistShow.ButtonText = "Daha Fazla";
            this.btnArtistShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistShow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnArtistShow.IdleBorderThickness = 2;
            this.btnArtistShow.IdleCornerRadius = 20;
            this.btnArtistShow.IdleFillColor = System.Drawing.Color.White;
            this.btnArtistShow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistShow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistShow.Location = new System.Drawing.Point(56, 335);
            this.btnArtistShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistShow.Name = "btnArtistShow";
            this.btnArtistShow.Size = new System.Drawing.Size(191, 47);
            this.btnArtistShow.TabIndex = 3;
            this.btnArtistShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistShow.Click += new System.EventHandler(this.btnArtistShow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "deneme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1203, 583);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleChildHomeBtn)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnPlaylist;
        private FontAwesome.Sharp.IconButton btnTrack;
        private FontAwesome.Sharp.IconButton btnAlbum;
        private FontAwesome.Sharp.IconButton btnArtist;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox TitleChildHomeBtn;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnExpand;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistShow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlbumShow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrackShow;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwAlbums;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwTrack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwArtist;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private FontAwesome.Sharp.IconButton btnMyProfile;
        private System.Windows.Forms.Button button1;
    }
}