using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public partial class TipKerdesek : Form
    {
        #region Valtozok
        private int helyesValasz;
        public Boolean bezarhat = false;
        #endregion

        public TipKerdesek()
        {
            InitializeComponent();
        }

        #region Funkciok
        public void setKerdes(string kerdes, int reqhelyesValasz)
        {
            label1.Text = kerdes;
            helyesValasz = reqhelyesValasz;
        }

        public void displayHelyesValasz()
        {
            label2.Text = helyesValasz + "";
            label2.BackColor = Color.Green;
        }

        private void Tippelos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bezarhat)
            {
                if (MessageBox.Show("Biztosan bezárod a kérdéseket?", "Bezárás", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
            else
            {
                MessageBox.Show("A kérdés még nem fejezödött be");
                e.Cancel = true;
                this.Activate();
            }
        }
        #endregion
    }
}