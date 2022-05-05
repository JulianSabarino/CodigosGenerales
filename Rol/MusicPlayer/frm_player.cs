using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class frm_player : Form
    {
        public frm_player()
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\musica\BADDEST.wav");
            player.Play();
        }

        System.Media.SoundPlayer player;

        private void btn_addList_Click(object sender, EventArgs e)
        {
            player.SoundLocation = @"D:\musica\BADDEST.wav";
            player.Load();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
