namespace GPR.Laterna.Presentation
{
    partial class MsgFollowed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgFollowed));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgwPlaylist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgwTrack = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgwArtist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgwAlbums = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnTrack = new FontAwesome.Sharp.IconButton();
            this.btnPlaylist = new FontAwesome.Sharp.IconButton();
            this.btnArtist = new FontAwesome.Sharp.IconButton();
            this.btnAlbum = new FontAwesome.Sharp.IconButton();
            this.btnArtistClose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(434, 263);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(162, 42);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Playlistler";
            // 
            // dgwPlaylist
            // 
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwPlaylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgwPlaylist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dgwPlaylist.ColumnHeadersHeight = 35;
            this.dgwPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwPlaylist.DoubleBuffered = true;
            this.dgwPlaylist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPlaylist.EnableHeadersVisualStyles = false;
            this.dgwPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dgwPlaylist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dgwPlaylist.HeaderForeColor = System.Drawing.Color.White;
            this.dgwPlaylist.Location = new System.Drawing.Point(360, 307);
            this.dgwPlaylist.Margin = new System.Windows.Forms.Padding(10);
            this.dgwPlaylist.Name = "dgwPlaylist";
            this.dgwPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwPlaylist.RowHeadersWidth = 40;
            this.dgwPlaylist.RowTemplate.Height = 40;
            this.dgwPlaylist.Size = new System.Drawing.Size(300, 150);
            this.dgwPlaylist.TabIndex = 41;
            this.dgwPlaylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPlaylist_CellClick);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(99, 263);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 42);
            this.bunifuCustomLabel4.TabIndex = 40;
            this.bunifuCustomLabel4.Text = "Şarkılar";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(429, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(153, 42);
            this.bunifuCustomLabel3.TabIndex = 39;
            this.bunifuCustomLabel3.Text = "Albümler";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(75, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 42);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Şarkıcılar";
            // 
            // dgwTrack
            // 
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwTrack.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle51;
            this.dgwTrack.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwTrack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTrack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dgwTrack.ColumnHeadersHeight = 35;
            this.dgwTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwTrack.DoubleBuffered = true;
            this.dgwTrack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTrack.EnableHeadersVisualStyles = false;
            this.dgwTrack.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderForeColor = System.Drawing.Color.White;
            this.dgwTrack.Location = new System.Drawing.Point(25, 307);
            this.dgwTrack.Margin = new System.Windows.Forms.Padding(10);
            this.dgwTrack.Name = "dgwTrack";
            this.dgwTrack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwTrack.RowHeadersWidth = 40;
            this.dgwTrack.RowTemplate.Height = 40;
            this.dgwTrack.Size = new System.Drawing.Size(300, 150);
            this.dgwTrack.TabIndex = 37;
            this.dgwTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTrack_CellClick);
            // 
            // dgwArtist
            // 
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwArtist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.dgwArtist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgwArtist.ColumnHeadersHeight = 35;
            this.dgwArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwArtist.DoubleBuffered = true;
            this.dgwArtist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwArtist.EnableHeadersVisualStyles = false;
            this.dgwArtist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderForeColor = System.Drawing.Color.White;
            this.dgwArtist.Location = new System.Drawing.Point(25, 61);
            this.dgwArtist.Margin = new System.Windows.Forms.Padding(10);
            this.dgwArtist.Name = "dgwArtist";
            this.dgwArtist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwArtist.RowHeadersWidth = 40;
            this.dgwArtist.RowTemplate.Height = 40;
            this.dgwArtist.Size = new System.Drawing.Size(300, 150);
            this.dgwArtist.TabIndex = 36;
            this.dgwArtist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArtist_CellClick);
            // 
            // dgwAlbums
            // 
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwAlbums.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            this.dgwAlbums.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwAlbums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgwAlbums.ColumnHeadersHeight = 35;
            this.dgwAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwAlbums.DoubleBuffered = true;
            this.dgwAlbums.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwAlbums.EnableHeadersVisualStyles = false;
            this.dgwAlbums.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.dgwAlbums.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.dgwAlbums.HeaderForeColor = System.Drawing.Color.White;
            this.dgwAlbums.Location = new System.Drawing.Point(360, 61);
            this.dgwAlbums.Margin = new System.Windows.Forms.Padding(10);
            this.dgwAlbums.Name = "dgwAlbums";
            this.dgwAlbums.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwAlbums.RowHeadersWidth = 40;
            this.dgwAlbums.RowTemplate.Height = 40;
            this.dgwAlbums.Size = new System.Drawing.Size(300, 150);
            this.dgwAlbums.TabIndex = 35;
            this.dgwAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAlbums_CellClick);
            // 
            // btnTrack
            // 
            this.btnTrack.FlatAppearance.BorderSize = 0;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTrack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrack.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnTrack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrack.IconSize = 32;
            this.btnTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.Location = new System.Drawing.Point(25, 460);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrack.Rotation = 0D;
            this.btnTrack.Size = new System.Drawing.Size(300, 59);
            this.btnTrack.TabIndex = 46;
            this.btnTrack.Text = "Takipten Çık";
            this.btnTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnPlaylist.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylist.IconSize = 32;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(360, 460);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlaylist.Rotation = 0D;
            this.btnPlaylist.Size = new System.Drawing.Size(300, 59);
            this.btnPlaylist.TabIndex = 45;
            this.btnPlaylist.Text = "Takipten Çık";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnArtist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtist.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnArtist.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtist.IconSize = 32;
            this.btnArtist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.Location = new System.Drawing.Point(25, 211);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnArtist.Rotation = 0D;
            this.btnArtist.Size = new System.Drawing.Size(300, 59);
            this.btnArtist.TabIndex = 44;
            this.btnArtist.Text = "Takipten Çık";
            this.btnArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.FlatAppearance.BorderSize = 0;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbum.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlbum.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlbum.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnAlbum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnAlbum.IconSize = 32;
            this.btnAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.Location = new System.Drawing.Point(360, 211);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlbum.Rotation = 0D;
            this.btnAlbum.Size = new System.Drawing.Size(300, 59);
            this.btnAlbum.TabIndex = 43;
            this.btnAlbum.Text = "Takipten Çık";
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnArtistClose
            // 
            this.btnArtistClose.ActiveBorderThickness = 1;
            this.btnArtistClose.ActiveCornerRadius = 20;
            this.btnArtistClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnArtistClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnArtistClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnArtistClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArtistClose.BackgroundImage")));
            this.btnArtistClose.ButtonText = "Kapat";
            this.btnArtistClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnArtistClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnArtistClose.IdleBorderThickness = 2;
            this.btnArtistClose.IdleCornerRadius = 20;
            this.btnArtistClose.IdleFillColor = System.Drawing.Color.White;
            this.btnArtistClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnArtistClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnArtistClose.Location = new System.Drawing.Point(0, 538);
            this.btnArtistClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistClose.Name = "btnArtistClose";
            this.btnArtistClose.Size = new System.Drawing.Size(709, 47);
            this.btnArtistClose.TabIndex = 34;
            this.btnArtistClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistClose.Click += new System.EventHandler(this.btnArtistClose_Click);
            // 
            // MsgFollowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(709, 585);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnArtist);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgwPlaylist);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dgwTrack);
            this.Controls.Add(this.dgwArtist);
            this.Controls.Add(this.dgwAlbums);
            this.Controls.Add(this.btnArtistClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgFollowed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgFollowed";
            this.Load += new System.EventHandler(this.MsgFollowed_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MsgFollowed_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private FontAwesome.Sharp.IconButton btnTrack;
        private FontAwesome.Sharp.IconButton btnPlaylist;
        private FontAwesome.Sharp.IconButton btnArtist;
        private FontAwesome.Sharp.IconButton btnAlbum;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwPlaylist;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwTrack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwArtist;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwAlbums;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistClose;
    }
}