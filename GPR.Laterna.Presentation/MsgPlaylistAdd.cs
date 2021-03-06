﻿using FontAwesome.Sharp;
using GPR.Laterna.Presentation.Business;
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

namespace GPR.Laterna.Presentation
{
    public partial class MsgPlaylistAdd : Form
    {
        private PlaylistConnector _playlistConnector;
        CustomMessageBox customMessageBox;
        public static long FormPlaylistId = 0;
        public MsgPlaylistAdd()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
        }
        private void MsgPlaylist_Load(object sender, EventArgs e)
        {
            LoadPlaylistDGV();
        }

        private void LoadPlaylistDGV()
        {
            dgwPlaylist.DataSource = _playlistConnector.GetUserPlaylists(Properties.Settings.Default.User.Id);
            dgwPlaylist.Columns["Name"].HeaderText = "Playlist Adı";
            dgwPlaylist.Columns["Description"].HeaderText = "Açıklama";
            dgwPlaylist.Columns["Public"].HeaderText = "Herkese Açık";
            dgwPlaylist.Columns["Id"].Visible = false;
            dgwPlaylist.Columns["UserId"].Visible = false;
            dgwPlaylist.Columns["DeletedAt"].Visible = false;
            dgwPlaylist.Columns["CreatedAt"].Visible = false;
            dgwPlaylist.Columns["UpdatedAt"].Visible = false;
            dgwPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MsgPlaylistAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void dgwPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dgwPlaylist.Rows[e.RowIndex];
                tbxName.Text = gridViewRow.Cells["Name"].Value.ToString();
                tbxDescription.Text = gridViewRow.Cells["Description"].Value.ToString();
            }
        }

        private void DgwCurrentRows()
        {
            FormPlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string description = tbxDescription.Text;
            bool isPublic = checkIsPublic.Checked;
            _playlistConnector.AddPlaylist(name, description, isPublic);
            LoadPlaylistDGV();
            Properties.Settings.Default.CustomMessage = "Ekleme İşlemi Başarıyla Gerçekleşti";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgwCurrentRows();
            string name = tbxName.Text;
            string description = tbxDescription.Text;
            bool isPublic = checkIsPublic.Checked;
            _playlistConnector.UpdatePlaylist(name, description, isPublic,FormPlaylistId);
            LoadPlaylistDGV();
            Properties.Settings.Default.CustomMessage = "Güncelleme İşlemi Başarıyla Gerçekleşti";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DgwCurrentRows();
            _playlistConnector.DeletePlaylist(FormPlaylistId);
            LoadPlaylistDGV();
            Properties.Settings.Default.CustomMessage = "Silme İşlemi Başarıyla Gerçekleşti";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowTracks_Click(object sender, EventArgs e)
        {
            MsgPlaylistTracks msgPlaylistTracks = new MsgPlaylistTracks();
            msgPlaylistTracks.Show();
        }
    }
}
