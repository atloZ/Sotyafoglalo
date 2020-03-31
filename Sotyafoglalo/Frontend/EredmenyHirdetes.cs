using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotyafoglalo.Frontend
{
    public partial class EredmenyHirdetes : Form
    {
        public EredmenyHirdetes(string[] csapatok, int[] pontok,int csapatokSzama)
        {
            InitializeComponent();
            int savePont;
            string saveName;
            for (int j = 0; j < pontok.Length; j++)
            {
                for (int i = 0; i < csapatok.Length; i++)
                {
                    if (pontok[i] < pontok[j])
                    {
                        savePont = pontok[i];
                        pontok[i] = pontok[j];
                        pontok[j] = savePont;

                        saveName = csapatok[i];
                        csapatok[i] = csapatok[j];
                        csapatok[j] = saveName;
                    }
                }
            }

            elsoHelyezettLabel.Text = "1. \"" + csapatok[0] + "\" csapat elért pont: " + pontok[0];
            masodikHelyezettLabel.Text = "2. \"" + csapatok[1] + "\" csapat elért pont: " + pontok[1];
            if (csapatokSzama == 3)
            {
                harmadikHelyezettLabel.Text = "3. \"" + csapatok[2] + "\" csapat elért pont: " + pontok[2];
            }
            if (csapatokSzama == 4)
            {
                harmadikHelyezettLabel.Text = "3. \"" + csapatok[2] + "\" csapat elért pont: " + pontok[2];
                negyedikHelyezettLabel.Text = "4. \"" + csapatok[3] + "\" csapat elért pont: " + pontok[3];
            }
        }
        
        private void Eredmeny_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan bezárod a kérdéseket?", "Bezárás", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
    }
}
