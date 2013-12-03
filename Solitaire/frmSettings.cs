using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire
{
    public partial class frmSettings : Form
    {
        public PictureBox deck = new PictureBox();
        public ImageList deckBacks = new ImageList();
        
        public frmSettings() {}

        public frmSettings(ref PictureBox Deck, ref ImageList DeckBacks)
        {
            InitializeComponent();
            this.Visible = false;
            deck = Deck;
            deckBacks = DeckBacks;
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRed.Checked == true)
                deck.Image = deckBacks.Images[0];
            else
                deck.Image = deckBacks.Images[1];
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void buttonSaveClose_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rbtnRed.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rbtnBlue.Checked = true;
        }


    }
}
