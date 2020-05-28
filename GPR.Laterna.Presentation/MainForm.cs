using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GPR.Laterna.Presentation.Business;

namespace GPR.Laterna.Presentation
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public static int AlbumId = 0;
        public static int ArtistId = 0;
        public static int TrackId = 0;

        private AlbumConnector _albumConnector;
        private ArtistConnector _artistConnector;
        private TrackConnector _trackConnector;
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            bool _btnHİde = true;
            BtnHide(_btnHİde);


            //album
            _albumConnector = new AlbumConnector();
            dgwAlbums.DataSource = _albumConnector.GetTopAlbums();
            dgwAlbums.Columns["Id"].Visible = false;
            dgwAlbums.Columns["ArtistId"].Visible = false;
            dgwAlbums.Columns["AlbumTypeId"].Visible = false;
            dgwAlbums.Columns["Copyrights"].Visible = false;
            dgwAlbums.Columns["Checked"].Visible = false;
            dgwAlbums.Columns["CreatedAt"].Visible = false;
            dgwAlbums.Columns["UpdatedAt"].Visible = false;
            dgwAlbums.Columns["Images"].Visible = false;
            dgwAlbums.Columns["SpotId"].Visible = false;
            dgwAlbums.Columns["ReleaseData"].Visible = false;

            dgwAlbums.Columns["Name"].HeaderText = "Albüm Adı";
            dgwAlbums.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //artist
            _artistConnector = new ArtistConnector();
            dgwArtist.DataSource = _artistConnector.GetTopArtist();
            dgwArtist.Columns["Name"].HeaderText = "Şarkıcı Adı";
            dgwArtist.Columns["Popularity"].HeaderText = "Popülerlik %100";

            dgwArtist.Columns["Genres"].Visible = false;
            dgwArtist.Columns["SpotId"].Visible = false;
            dgwArtist.Columns["Id"].Visible = false;
            dgwArtist.Columns["Images"].Visible = false;
            dgwArtist.Columns["CreatedAt"].Visible = false;
            dgwArtist.Columns["Checked"].Visible = false;
            dgwArtist.Columns["Searched"].Visible = false;
            dgwArtist.Columns["UpdatedAt"].Visible = false;
            dgwArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _trackConnector = new TrackConnector();
            dgwTrack.DataSource = _trackConnector.GetTopTracks();
            dgwTrack.Columns["Name"].HeaderText = "Şarkı Adı";
            dgwTrack.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwTrack.Columns["SpotId"].Visible = false;
            dgwTrack.Columns["PreviewUrl"].Visible = false;
            dgwTrack.Columns["Id"].Visible = false;
            dgwTrack.Columns["AlbumId"].Visible = false;
            dgwTrack.Columns["DurationMs"].Visible = false;
            dgwTrack.Columns["DiscNumber"].Visible = false;
            dgwTrack.Columns["CreatedAt"].Visible = false;
            dgwTrack.Columns["UpdatedAt"].Visible = false;
            dgwTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void BtnHide(bool BtnHide)
        {
            if (BtnHide ==true)
            {
                btnUser.Hide();
                btnLogOut.Hide();
                btnLogin.Show();
            }
            else
            {
                btnUser.Show();
                btnLogOut.Show();
                btnLogin.Hide();
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(255, 184, 0);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221  );
            public static Color color5 = Color.FromArgb(249, 88, 155 );
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                lblTitleChildForm.Text = currentBtn.Text;
                TitleChildHomeBtn.IconChar = currentBtn.IconChar;
                TitleChildHomeBtn.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FormArtists());
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FormAlbums());
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FormTracks());
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FormPlaylist());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FormUser());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            if(MessageBox.Show("Çıkış Yapmayı Onaylıyor Musunuz", "Çıkış Yap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool _btnHide = true;
                BtnHide(_btnHide);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            TitleChildHomeBtn.IconChar = IconChar.Home;
            TitleChildHomeBtn.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Ana Sayfa";
            leftBorderBtn.Visible = false;
        }
        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
            ActiveButton(sender, RGBColors.color6);
            bool _btnHide = false;
            BtnHide(_btnHide);
        }

        private void btnAlbumShow_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwAlbums.Rows[dgwAlbums.CurrentRow.Index].Cells[0].Value);
            AlbumId = id;
            MsgAlbum msgAlbum = new MsgAlbum();
            msgAlbum.Show();
        }

        private void dgwAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnArtistShow_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
            ArtistId = id;
            MsgArtist msgArtist = new MsgArtist();
            msgArtist.Show();
        }

        private void dgwTracks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTrackShow_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
            TrackId = id;
            MsgTrack msgTrack = new MsgTrack();
            msgTrack.Show();
        }
    }
}
