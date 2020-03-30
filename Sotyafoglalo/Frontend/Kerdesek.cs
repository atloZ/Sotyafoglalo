using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public partial class Kerdesek : Form
    {
        #region Valtozok
        private string[] kerdesTomb = new string[5];
        private string[] labelek = new string[] { "A", "B", "C", "D" };
        private List<Label> valaszHelyek = new List<Label>();
        public Boolean bezarhat = false;

        public string[] KerdesTomb { get => kerdesTomb; set => kerdesTomb = value; }
        #endregion

        public Kerdesek()
        {
            InitializeComponent();
        }

        #region Funkciok
        private void Kerdesek_Load(object sender, EventArgs e)
        {
            bezarhat = false;

            valaszHelyek.Add(aValasz);
            valaszHelyek.Add(bValasz);
            valaszHelyek.Add(cValasz);
            valaszHelyek.Add(dValasz);
        }
        public void setKerdesek()
        {
            kerdesLabel.Text = kerdesTomb[0];
            for (int i = 0; i < 4; i++)
            {
                valaszHelyek[i].Text = labelek[i] + ": " + kerdesTomb[i + 1];
            }
        }
        public void setBGColor(int rowNum)
        {
            valaszHelyek[rowNum].BackColor = Color.Green;
        }

        private void Kerdesek_FormClosing(object sender, FormClosingEventArgs e)
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