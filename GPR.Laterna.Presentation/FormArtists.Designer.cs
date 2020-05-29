namespace GPR.Laterna.Presentation
{
    partial class FormArtists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArtists));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnArtistFlw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnArtistShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnArtistLike = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwArtist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.btnArtistFlw);
            this.panelDesktop.Controls.Add(this.btnArtistShow);
            this.panelDesktop.Controls.Add(this.btnArtistLike);
            this.panelDesktop.Controls.Add(this.dgwArtist);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(947, 409);
            this.panelDesktop.TabIndex = 5;
            // 
            // btnArtistFlw
            // 
            this.btnArtistFlw.ActiveBorderThickness = 1;
            this.btnArtistFlw.ActiveCornerRadius = 20;
            this.btnArtistFlw.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFlw.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistFlw.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFlw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArtistFlw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnArtistFlw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArtistFlw.BackgroundImage")));
            this.btnArtistFlw.ButtonText = "Takip Et";
            this.btnArtistFlw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistFlw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistFlw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnArtistFlw.IdleBorderThickness = 2;
            this.btnArtistFlw.IdleCornerRadius = 20;
            this.btnArtistFlw.IdleFillColor = System.Drawing.Color.White;
            this.btnArtistFlw.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFlw.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFlw.Location = new System.Drawing.Point(72, 340);
            this.btnArtistFlw.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistFlw.Name = "btnArtistFlw";
            this.btnArtistFlw.Size = new System.Drawing.Size(191, 47);
            this.btnArtistFlw.TabIndex = 3;
            this.btnArtistFlw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistFlw.Click += new System.EventHandler(this.btnArtistFlw_Click);
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
            this.btnArtistShow.Location = new System.Drawing.Point(391, 340);
            this.btnArtistShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistShow.Name = "btnArtistShow";
            this.btnArtistShow.Size = new System.Drawing.Size(191, 47);
            this.btnArtistShow.TabIndex = 2;
            this.btnArtistShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistShow.Click += new System.EventHandler(this.btnArtistShow_Click);
            // 
            // btnArtistLike
            // 
            this.btnArtistLike.ActiveBorderThickness = 1;
            this.btnArtistLike.ActiveCornerRadius = 20;
            this.btnArtistLike.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistLike.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistLike.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistLike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArtistLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnArtistLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArtistLike.BackgroundImage")));
            this.btnArtistLike.ButtonText = "Beğen";
            this.btnArtistLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistLike.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnArtistLike.IdleBorderThickness = 2;
            this.btnArtistLike.IdleCornerRadius = 20;
            this.btnArtistLike.IdleFillColor = System.Drawing.Color.White;
            this.btnArtistLike.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistLike.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistLike.Location = new System.Drawing.Point(697, 340);
            this.btnArtistLike.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistLike.Name = "btnArtistLike";
            this.btnArtistLike.Size = new System.Drawing.Size(191, 47);
            this.btnArtistLike.TabIndex = 1;
            this.btnArtistLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistLike.Click += new System.EventHandler(this.btnArtistLike_Click);
            // 
            // dgwArtist
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwArtist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwArtist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwArtist.ColumnHeadersHeight = 40;
            this.dgwArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwArtist.DoubleBuffered = true;
            this.dgwArtist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwArtist.EnableHeadersVisualStyles = false;
            this.dgwArtist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.dgwArtist.HeaderForeColor = System.Drawing.Color.White;
            this.dgwArtist.Location = new System.Drawing.Point(0, 0);
            this.dgwArtist.Margin = new System.Windows.Forms.Padding(10);
            this.dgwArtist.Name = "dgwArtist";
            this.dgwArtist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwArtist.RowHeadersWidth = 40;
            this.dgwArtist.RowTemplate.Height = 40;
            this.dgwArtist.Size = new System.Drawing.Size(947, 295);
            this.dgwArtist.TabIndex = 0;
            this.dgwArtist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArtist_CellClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.dgwArtist;
            // 
            // FormArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 409);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArtists";
            this.Text = "Artists";
            this.Load += new System.EventHandler(this.FormArtists_Load);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistFlw;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistShow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistLike;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwArtist;
    }
}