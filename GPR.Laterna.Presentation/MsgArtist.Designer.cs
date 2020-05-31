namespace GPR.Laterna.Presentation
{
    partial class MsgArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgArtist));
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPopularity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGenres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnArtistClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pcbImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(643, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "bunifuCustomLabel1";
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPopularity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPopularity.Location = new System.Drawing.Point(645, 243);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(190, 26);
            this.lblPopularity.TabIndex = 1;
            this.lblPopularity.Text = "bunifuCustomLabel1";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGenres.Location = new System.Drawing.Point(645, 208);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(190, 26);
            this.lblGenres.TabIndex = 1;
            this.lblGenres.Text = "bunifuCustomLabel1";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(466, 208);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(50, 26);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Tür :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(466, 243);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(173, 26);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Popülerlik  100% : ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(466, 170);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(118, 26);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Playlist Adı :";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(947, 31);
            this.panelTitle.TabIndex = 7;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown_1);
            // 
            // btnArtistClose
            // 
            this.btnArtistClose.ActiveBorderThickness = 1;
            this.btnArtistClose.ActiveCornerRadius = 20;
            this.btnArtistClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
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
            this.btnArtistClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistClose.Location = new System.Drawing.Point(0, 426);
            this.btnArtistClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistClose.Name = "btnArtistClose";
            this.btnArtistClose.Size = new System.Drawing.Size(947, 47);
            this.btnArtistClose.TabIndex = 8;
            this.btnArtistClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistClose.Click += new System.EventHandler(this.btnArtistClose_Click);
            // 
            // pcbImages
            // 
            this.pcbImages.Location = new System.Drawing.Point(12, 48);
            this.pcbImages.Name = "pcbImages";
            this.pcbImages.Size = new System.Drawing.Size(429, 361);
            this.pcbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImages.TabIndex = 3;
            this.pcbImages.TabStop = false;
            // 
            // MsgArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(947, 473);
            this.Controls.Add(this.btnArtistClose);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.pcbImages);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblPopularity);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgArtist";
            this.Load += new System.EventHandler(this.MsgArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPopularity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGenres;
        private System.Windows.Forms.PictureBox pcbImages;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel panelTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistClose;
    }
}