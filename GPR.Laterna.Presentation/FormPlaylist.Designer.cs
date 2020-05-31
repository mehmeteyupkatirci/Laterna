namespace GPR.Laterna.Presentation
{
    partial class FormPlaylist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaylist));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgwPlaylist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnPlaylistFlw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPlaylistShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPlaylistLike = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaylist)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.dgwPlaylist;
            // 
            // dgwPlaylist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwPlaylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPlaylist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwPlaylist.ColumnHeadersHeight = 40;
            this.dgwPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwPlaylist.DoubleBuffered = true;
            this.dgwPlaylist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPlaylist.EnableHeadersVisualStyles = false;
            this.dgwPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dgwPlaylist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.dgwPlaylist.HeaderForeColor = System.Drawing.Color.White;
            this.dgwPlaylist.Location = new System.Drawing.Point(0, 0);
            this.dgwPlaylist.Margin = new System.Windows.Forms.Padding(10);
            this.dgwPlaylist.Name = "dgwPlaylist";
            this.dgwPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwPlaylist.RowHeadersWidth = 40;
            this.dgwPlaylist.RowTemplate.Height = 40;
            this.dgwPlaylist.Size = new System.Drawing.Size(947, 295);
            this.dgwPlaylist.TabIndex = 0;
            this.dgwPlaylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPlaylist_CellClick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.btnPlaylistFlw);
            this.panelDesktop.Controls.Add(this.btnPlaylistShow);
            this.panelDesktop.Controls.Add(this.btnPlaylistLike);
            this.panelDesktop.Controls.Add(this.dgwPlaylist);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(947, 410);
            this.panelDesktop.TabIndex = 6;
            // 
            // btnPlaylistFlw
            // 
            this.btnPlaylistFlw.ActiveBorderThickness = 1;
            this.btnPlaylistFlw.ActiveCornerRadius = 20;
            this.btnPlaylistFlw.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistFlw.ActiveForecolor = System.Drawing.Color.White;
            this.btnPlaylistFlw.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistFlw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlaylistFlw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlaylistFlw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylistFlw.BackgroundImage")));
            this.btnPlaylistFlw.ButtonText = "Takip Et";
            this.btnPlaylistFlw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylistFlw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaylistFlw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPlaylistFlw.IdleBorderThickness = 2;
            this.btnPlaylistFlw.IdleCornerRadius = 20;
            this.btnPlaylistFlw.IdleFillColor = System.Drawing.Color.White;
            this.btnPlaylistFlw.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistFlw.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistFlw.Location = new System.Drawing.Point(62, 325);
            this.btnPlaylistFlw.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlaylistFlw.Name = "btnPlaylistFlw";
            this.btnPlaylistFlw.Size = new System.Drawing.Size(191, 47);
            this.btnPlaylistFlw.TabIndex = 6;
            this.btnPlaylistFlw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylistFlw.Click += new System.EventHandler(this.btnPlaylsitFlw_Click);
            // 
            // btnPlaylistShow
            // 
            this.btnPlaylistShow.ActiveBorderThickness = 1;
            this.btnPlaylistShow.ActiveCornerRadius = 20;
            this.btnPlaylistShow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistShow.ActiveForecolor = System.Drawing.Color.White;
            this.btnPlaylistShow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlaylistShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlaylistShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylistShow.BackgroundImage")));
            this.btnPlaylistShow.ButtonText = "Daha Fazla";
            this.btnPlaylistShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylistShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaylistShow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaylistShow.IdleBorderThickness = 2;
            this.btnPlaylistShow.IdleCornerRadius = 20;
            this.btnPlaylistShow.IdleFillColor = System.Drawing.Color.White;
            this.btnPlaylistShow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistShow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistShow.Location = new System.Drawing.Point(381, 325);
            this.btnPlaylistShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlaylistShow.Name = "btnPlaylistShow";
            this.btnPlaylistShow.Size = new System.Drawing.Size(191, 47);
            this.btnPlaylistShow.TabIndex = 5;
            this.btnPlaylistShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylistShow.Click += new System.EventHandler(this.btnPlaylistShow_Click);
            // 
            // btnPlaylistLike
            // 
            this.btnPlaylistLike.ActiveBorderThickness = 1;
            this.btnPlaylistLike.ActiveCornerRadius = 20;
            this.btnPlaylistLike.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistLike.ActiveForecolor = System.Drawing.Color.White;
            this.btnPlaylistLike.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistLike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlaylistLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlaylistLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylistLike.BackgroundImage")));
            this.btnPlaylistLike.ButtonText = "Beğen";
            this.btnPlaylistLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylistLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaylistLike.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaylistLike.IdleBorderThickness = 2;
            this.btnPlaylistLike.IdleCornerRadius = 20;
            this.btnPlaylistLike.IdleFillColor = System.Drawing.Color.White;
            this.btnPlaylistLike.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistLike.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnPlaylistLike.Location = new System.Drawing.Point(687, 325);
            this.btnPlaylistLike.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlaylistLike.Name = "btnPlaylistLike";
            this.btnPlaylistLike.Size = new System.Drawing.Size(191, 47);
            this.btnPlaylistLike.TabIndex = 4;
            this.btnPlaylistLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylistLike.Click += new System.EventHandler(this.btnPlaylistLike_Click);
            // 
            // FormPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 410);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlaylist";
            this.Text = "FormPlaylist";
            this.Load += new System.EventHandler(this.FormPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaylist)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwPlaylist;
        private System.Windows.Forms.Panel panelDesktop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaylistFlw;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaylistShow;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaylistLike;
    }
}