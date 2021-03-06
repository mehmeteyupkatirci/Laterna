﻿namespace GPR.Laterna.Presentation
{
    partial class FormTracks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTracks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnPlaylistAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTrackFlw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTrackShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTrackLike = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwTrack = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.btnPlaylistAdd);
            this.panelDesktop.Controls.Add(this.btnTrackFlw);
            this.panelDesktop.Controls.Add(this.btnTrackShow);
            this.panelDesktop.Controls.Add(this.btnTrackLike);
            this.panelDesktop.Controls.Add(this.dgwTrack);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(947, 410);
            this.panelDesktop.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 37);
            this.panel1.TabIndex = 8;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnStop.FlatAppearance.BorderSize = 3;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnStop.IconSize = 32;
            this.btnStop.Location = new System.Drawing.Point(474, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Rotation = 0D;
            this.btnStop.Size = new System.Drawing.Size(474, 37);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlay.FlatAppearance.BorderSize = 3;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlay.IconSize = 32;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0D;
            this.btnPlay.Size = new System.Drawing.Size(474, 37);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlaylistAdd
            // 
            this.btnPlaylistAdd.ActiveBorderThickness = 1;
            this.btnPlaylistAdd.ActiveCornerRadius = 20;
            this.btnPlaylistAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlaylistAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnPlaylistAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlaylistAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlaylistAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlaylistAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylistAdd.BackgroundImage")));
            this.btnPlaylistAdd.ButtonText = "Playliste Ekle";
            this.btnPlaylistAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylistAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaylistAdd.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaylistAdd.IdleBorderThickness = 2;
            this.btnPlaylistAdd.IdleCornerRadius = 20;
            this.btnPlaylistAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnPlaylistAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlaylistAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnPlaylistAdd.Location = new System.Drawing.Point(502, 340);
            this.btnPlaylistAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlaylistAdd.Name = "btnPlaylistAdd";
            this.btnPlaylistAdd.Size = new System.Drawing.Size(191, 47);
            this.btnPlaylistAdd.TabIndex = 4;
            this.btnPlaylistAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylistAdd.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
            // 
            // btnTrackFlw
            // 
            this.btnTrackFlw.ActiveBorderThickness = 1;
            this.btnTrackFlw.ActiveCornerRadius = 20;
            this.btnTrackFlw.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackFlw.ActiveForecolor = System.Drawing.Color.White;
            this.btnTrackFlw.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackFlw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrackFlw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnTrackFlw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrackFlw.BackgroundImage")));
            this.btnTrackFlw.ButtonText = "Takip Et";
            this.btnTrackFlw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackFlw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrackFlw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTrackFlw.IdleBorderThickness = 2;
            this.btnTrackFlw.IdleCornerRadius = 20;
            this.btnTrackFlw.IdleFillColor = System.Drawing.Color.White;
            this.btnTrackFlw.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackFlw.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackFlw.Location = new System.Drawing.Point(14, 340);
            this.btnTrackFlw.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackFlw.Name = "btnTrackFlw";
            this.btnTrackFlw.Size = new System.Drawing.Size(191, 47);
            this.btnTrackFlw.TabIndex = 3;
            this.btnTrackFlw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrackFlw.Click += new System.EventHandler(this.btnTrackFlw_Click);
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
            this.btnTrackShow.Location = new System.Drawing.Point(262, 340);
            this.btnTrackShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackShow.Name = "btnTrackShow";
            this.btnTrackShow.Size = new System.Drawing.Size(191, 47);
            this.btnTrackShow.TabIndex = 2;
            this.btnTrackShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrackShow.Click += new System.EventHandler(this.btnTrackShow_Click);
            // 
            // btnTrackLike
            // 
            this.btnTrackLike.ActiveBorderThickness = 1;
            this.btnTrackLike.ActiveCornerRadius = 20;
            this.btnTrackLike.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackLike.ActiveForecolor = System.Drawing.Color.White;
            this.btnTrackLike.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackLike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrackLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnTrackLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrackLike.BackgroundImage")));
            this.btnTrackLike.ButtonText = "Beğen";
            this.btnTrackLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrackLike.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnTrackLike.IdleBorderThickness = 2;
            this.btnTrackLike.IdleCornerRadius = 20;
            this.btnTrackLike.IdleFillColor = System.Drawing.Color.White;
            this.btnTrackLike.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackLike.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnTrackLike.Location = new System.Drawing.Point(742, 340);
            this.btnTrackLike.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrackLike.Name = "btnTrackLike";
            this.btnTrackLike.Size = new System.Drawing.Size(191, 47);
            this.btnTrackLike.TabIndex = 1;
            this.btnTrackLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrackLike.Click += new System.EventHandler(this.btnTrackLike_Click);
            // 
            // dgwTrack
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwTrack.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTrack.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwTrack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTrack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTrack.ColumnHeadersHeight = 40;
            this.dgwTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwTrack.DoubleBuffered = true;
            this.dgwTrack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwTrack.EnableHeadersVisualStyles = false;
            this.dgwTrack.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgwTrack.HeaderForeColor = System.Drawing.Color.White;
            this.dgwTrack.Location = new System.Drawing.Point(0, 0);
            this.dgwTrack.Margin = new System.Windows.Forms.Padding(10);
            this.dgwTrack.Name = "dgwTrack";
            this.dgwTrack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwTrack.RowHeadersWidth = 40;
            this.dgwTrack.RowTemplate.Height = 40;
            this.dgwTrack.Size = new System.Drawing.Size(947, 295);
            this.dgwTrack.TabIndex = 0;
            this.dgwTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTrack_CellClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.dgwTrack;
            // 
            // FormTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 410);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTracks";
            this.Text = "FormTracks";
            this.Load += new System.EventHandler(this.FormTracks_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrackFlw;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrackShow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrackLike;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwTrack;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaylistAdd;
        private FontAwesome.Sharp.IconButton btnStop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPlay;
    }
}