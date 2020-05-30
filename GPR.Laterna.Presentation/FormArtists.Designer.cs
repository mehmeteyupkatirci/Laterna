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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnArtistFollow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnArtistLike = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnArtistShow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwArtist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.btnArtistFollow);
            this.panelDesktop.Controls.Add(this.BtnArtistLike);
            this.panelDesktop.Controls.Add(this.btnArtistShow);
            this.panelDesktop.Controls.Add(this.dgwArtist);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(947, 409);
            this.panelDesktop.TabIndex = 5;
            // 
            // btnArtistFollow
            // 
            this.btnArtistFollow.ActiveBorderThickness = 1;
            this.btnArtistFollow.ActiveCornerRadius = 20;
            this.btnArtistFollow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFollow.ActiveForecolor = System.Drawing.Color.White;
            this.btnArtistFollow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFollow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArtistFollow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnArtistFollow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArtistFollow.BackgroundImage")));
            this.btnArtistFollow.ButtonText = "Takip Et";
            this.btnArtistFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtistFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistFollow.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnArtistFollow.IdleBorderThickness = 2;
            this.btnArtistFollow.IdleCornerRadius = 20;
            this.btnArtistFollow.IdleFillColor = System.Drawing.Color.White;
            this.btnArtistFollow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFollow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnArtistFollow.Location = new System.Drawing.Point(67, 340);
            this.btnArtistFollow.Margin = new System.Windows.Forms.Padding(5);
            this.btnArtistFollow.Name = "btnArtistFollow";
            this.btnArtistFollow.Size = new System.Drawing.Size(191, 47);
            this.btnArtistFollow.TabIndex = 7;
            this.btnArtistFollow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArtistFollow.Click += new System.EventHandler(this.btnArtistFollow_Click);
            // 
            // BtnArtistLike
            // 
            this.BtnArtistLike.ActiveBorderThickness = 1;
            this.BtnArtistLike.ActiveCornerRadius = 20;
            this.BtnArtistLike.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.BtnArtistLike.ActiveForecolor = System.Drawing.Color.White;
            this.BtnArtistLike.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.BtnArtistLike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnArtistLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtnArtistLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnArtistLike.BackgroundImage")));
            this.BtnArtistLike.ButtonText = "Beğen";
            this.BtnArtistLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArtistLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArtistLike.ForeColor = System.Drawing.Color.MediumPurple;
            this.BtnArtistLike.IdleBorderThickness = 2;
            this.BtnArtistLike.IdleCornerRadius = 20;
            this.BtnArtistLike.IdleFillColor = System.Drawing.Color.White;
            this.BtnArtistLike.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.BtnArtistLike.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.BtnArtistLike.Location = new System.Drawing.Point(705, 340);
            this.BtnArtistLike.Margin = new System.Windows.Forms.Padding(5);
            this.BtnArtistLike.Name = "BtnArtistLike";
            this.BtnArtistLike.Size = new System.Drawing.Size(191, 47);
            this.BtnArtistLike.TabIndex = 6;
            this.BtnArtistLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnArtistLike.Click += new System.EventHandler(this.BtnArtistLike_Click);
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
            // dgwArtist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwArtist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwArtist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArtist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistShow;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwArtist;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnArtistLike;
        private Bunifu.Framework.UI.BunifuThinButton2 btnArtistFollow;
    }
}