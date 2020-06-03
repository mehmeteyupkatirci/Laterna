using GPR.Laterna.Entities.Concrete;
using GPR.Laterna.Presentation.Business;
using GPR.Laterna.Presentation.Helpers;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation
{
    public partial class FormTracks : Form
    {
        public static long TrackId = 0;
        public static string PreviewUrl = "";
        private string _previousUrl = "";
        CustomMessageBox customMessageBox;

        private TrackConnector _trackConnector;
        private UserConnector _userConnector;
        private List<UserLikedTrack> _userLikedTracks;
        private List<UserFollowedTrack> _userFollowedTracks;

        private WaveOut _player;
        public FormTracks()
        {
            InitializeComponent();
            _trackConnector = new TrackConnector();
            _userConnector = new UserConnector();
            _userFollowedTracks = new List<UserFollowedTrack>();
            _userLikedTracks = new List<UserLikedTrack>();
            _player = new WaveOut(WaveCallbackInfo.FunctionCallback());
        }

        private void FormTracks_Load(object sender, EventArgs e)
        {
            LoadTrackDGV();
            LoadTrackUserOperation();
        }

        private void LoadTrackUserOperation()
        {
            if (Properties.Settings.Default.isLogin)
            {
                _userLikedTracks = _userConnector.GetUserLikedTracks(Properties.Settings.Default.User.Id);
                _userFollowedTracks = _userConnector.GetUserFollowedTracks(Properties.Settings.Default.User.Id);
            }
        }

        private void LoadTrackDGV()
        {
            dgwTrack.DataSource = _trackConnector.GetAll();
            dgwTrack.Columns["Name"].HeaderText = "Şarkı Adı";
            dgwTrack.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwTrack.Columns["SpotId"].Visible = false;
            dgwTrack.Columns["Id"].Visible = false;
            dgwTrack.Columns["AlbumId"].Visible = false;
            dgwTrack.Columns["DurationMs"].Visible = false;
            dgwTrack.Columns["DiscNumber"].Visible = false;
            dgwTrack.Columns["CreatedAt"].Visible = false;
            dgwTrack.Columns["UpdatedAt"].Visible = false;
            dgwTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgwTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
            PreviewUrl = Convert.ToString(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells["PreviewUrl"].Value);
            var theLikedTrack = _userLikedTracks.Where(x=>x.TrackId==TrackId).FirstOrDefault();
            var theFollowedTrack = _userFollowedTracks.Where(x=>x.TrackId==TrackId).FirstOrDefault();
            if (theFollowedTrack != null)
            {
                btnTrackFlw.ButtonText = "Takipten Çık";
            }
            else
            {
                btnTrackFlw.ButtonText = "Takip Et";
            }
            if (theLikedTrack != null)
            {
                btnTrackLike.ButtonText = "Beğenmekten\nVazgeç";
                btnTrackLike.Font = new Font("Microsoft Sans Serif", 10);
            }
            else
            {
                btnTrackLike.ButtonText = "Beğen";
                btnTrackLike.Font = new Font("Microsoft Sans Serif", 14);
            }
        }

        private void DgwTrackCurrentRow()
        {
            TrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
        }

        private void btnTrackShow_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            MsgTrack msgTrack = new MsgTrack();
            msgTrack.Show();
        }

        private void btnTrackFlw_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowTrack(Properties.Settings.Default.User.Id, TrackId);
                if (result)
                {
                    Properties.Settings.Default.CustomMessage = "Takip Etme İşlemi Başarılı";
                    LoadTrackDGV();
                    LoadTrackUserOperation();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    var theFollowedTrack = _userFollowedTracks.Where(x => x.TrackId == TrackId).FirstOrDefault();
                    _userConnector.DeleteUserFollowedTrack(theFollowedTrack.Id);
                    Properties.Settings.Default.CustomMessage = "Takipten Çıkıldı";
                    LoadTrackDGV();
                    LoadTrackUserOperation();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
        }

        private void btnTrackLike_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.LikedTrack(Properties.Settings.Default.User.Id, TrackId);
                if (result)
                {
                    Properties.Settings.Default.CustomMessage = "Beğenme İşlemi Başarılı";
                    LoadTrackDGV();
                    LoadTrackUserOperation();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    var theLikedTrack = _userLikedTracks.Where(x => x.TrackId == TrackId).FirstOrDefault();
                    _userConnector.DeleteUserLikedTrack(theLikedTrack.Id);
                    Properties.Settings.Default.CustomMessage = "Beğenmekten Vazgeçildi";
                    LoadTrackDGV();
                    LoadTrackUserOperation();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
        }
        private void btnPlaylistAdd_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                MsgUserPlaylist userPlaylist = new MsgUserPlaylist();
                userPlaylist.Show();
            }
        }
        public static void PlayMp3FromUrl(string url)
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(url)
                    .GetResponse().GetResponseStream())
                {
                    stream.CopyTo(ms);
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                        
                    }
                }
            }
        }

        public  void StartMp3FromUrl()
        {
           
            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(PreviewUrl)
                    .GetResponse().GetResponseStream())
                {
                    stream.CopyTo(ms);
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    _player.Init(blockAlignedStream);
                    _player.Play();


                    while (_player.PlaybackState == PlaybackState.Playing || _player.PlaybackState == PlaybackState.Paused)
                    {
                       
                    }

                }
            }
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if(PreviewUrl == _previousUrl)
            {
                if(_player.PlaybackState == PlaybackState.Playing)
                {
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                    _player.Pause();
                }
                else if(_player.PlaybackState == PlaybackState.Paused)
                {
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                    _player.Resume();
                }
                else
                {
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                    Task task = Task.Run((Action)StartMp3FromUrl);
                }
            }
            else
            {
                _previousUrl = PreviewUrl;
                _player.Stop();
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                Task task = Task.Run((Action)StartMp3FromUrl);
            }
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _player.Stop();
            btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
        }
    }
}
