namespace GPR.Laterna.Presentation
{
    partial class CustomMessageBox
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOkay = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 247);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(645, 25);
            this.panelBottom.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(213, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(209, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "bunifuCustomLabel1";
            // 
            // btnOkay
            // 
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOkay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOkay.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnOkay.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOkay.IconSize = 32;
            this.btnOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOkay.Location = new System.Drawing.Point(247, 153);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOkay.Rotation = 0D;
            this.btnOkay.Size = new System.Drawing.Size(133, 60);
            this.btnOkay.TabIndex = 3;
            this.btnOkay.Text = "Tamam";
            this.btnOkay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOkay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(645, 25);
            this.panelTop.TabIndex = 4;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(645, 272);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMessage;
        private FontAwesome.Sharp.IconButton btnOkay;
        private System.Windows.Forms.Panel panelTop;
    }
}