﻿namespace GPR.Laterna.Presentation
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlaylists = new FontAwesome.Sharp.IconButton();
            this.btnFollow = new FontAwesome.Sharp.IconButton();
            this.btnLike = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPasswordValidate = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.btnUpdate);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.tbxPasswordValidate);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.tbxPassword);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.tbxEmail);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.tbxName);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(931, 371);
            this.panelDesktop.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Güncelle";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnUpdate.Location = new System.Drawing.Point(200, 213);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 41);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlaylists);
            this.panel1.Controls.Add(this.btnFollow);
            this.panel1.Controls.Add(this.btnLike);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 59);
            this.panel1.TabIndex = 22;
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlaylists.FlatAppearance.BorderSize = 0;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlaylists.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylists.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlaylists.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylists.IconSize = 32;
            this.btnPlaylists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.Location = new System.Drawing.Point(629, 0);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlaylists.Rotation = 0D;
            this.btnPlaylists.Size = new System.Drawing.Size(316, 59);
            this.btnPlaylists.TabIndex = 4;
            this.btnPlaylists.Text = "Playlistlerim";
            this.btnPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylists.UseVisualStyleBackColor = true;
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnFollow
            // 
            this.btnFollow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFollow.FlatAppearance.BorderSize = 0;
            this.btnFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFollow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFollow.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnFollow.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFollow.IconSize = 32;
            this.btnFollow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFollow.Location = new System.Drawing.Point(313, 0);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFollow.Rotation = 0D;
            this.btnFollow.Size = new System.Drawing.Size(316, 59);
            this.btnFollow.TabIndex = 3;
            this.btnFollow.Text = "Takip Ettiklerim";
            this.btnFollow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFollow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFollow.UseVisualStyleBackColor = true;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnLike
            // 
            this.btnLike.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLike.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLike.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.btnLike.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLike.IconSize = 32;
            this.btnLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.Location = new System.Drawing.Point(0, 0);
            this.btnLike.Name = "btnLike";
            this.btnLike.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLike.Rotation = 0D;
            this.btnLike.Size = new System.Drawing.Size(313, 59);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "Beğendiklerim";
            this.btnLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parola Tekrar";
            // 
            // tbxPasswordValidate
            // 
            this.tbxPasswordValidate.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxPasswordValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPasswordValidate.Location = new System.Drawing.Point(430, 96);
            this.tbxPasswordValidate.Name = "tbxPasswordValidate";
            this.tbxPasswordValidate.PasswordChar = '*';
            this.tbxPasswordValidate.Size = new System.Drawing.Size(115, 26);
            this.tbxPasswordValidate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(430, 53);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(115, 26);
            this.tbxPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.Location = new System.Drawing.Point(129, 99);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 26);
            this.tbxEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // tbxName
            // 
            this.tbxName.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(129, 56);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 26);
            this.tbxName.TabIndex = 0;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 371);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxPasswordValidate;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxPassword;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxEmail;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxName;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPlaylists;
        private FontAwesome.Sharp.IconButton btnFollow;
        private FontAwesome.Sharp.IconButton btnLike;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
    }
}