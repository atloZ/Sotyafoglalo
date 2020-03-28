using Sotyafoglalo.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public partial class Bejelentkezes : Form
    {
        Control controlForm = new Control();

        private int szamlalo;
        private int iskolaNevIndex;
        private string[] iskolaNev = { "Arany", "Benedek", "Dr. Mező alsó", "Dr. Mező felső", "Dr. Török Béla", "Heltai", "Herman alsó", "Herman felső	", "Hunyadi", "Jókai", "Jókai", "Kaffka", "Liszt", "Móra", "Munkácsy alsó", "Munkácsy felső", "Németh Imre", "Széchenyi", "Vakok" };

        private static int csapatSzam = 0;
        private static string csapatNev1 = null;
        private static string csapatNev2 = null;
        private static string csapatNev3 = null;
        private static string csapatNev4 = null;

        public static int CsapatSzam { get => csapatSzam; }
        public static string CsapatNev1 { get => csapatNev1; }
        public static string CsapatNev2 { get => csapatNev2; }
        public static string CsapatNev3 { get => csapatNev3; }
        public static string CsapatNev4 { get => csapatNev4; }

        public Bejelentkezes()
        {
            InitializeComponent();

        }

        private void Bevitel_Load(object sender, EventArgs e)
        {
            szamlalo = 1;

            csapatSzam = 0;
            csapatNev1 = null;
            csapatNev2 = null;
            csapatNev3 = null;
            csapatNev4 = null;
            csapatNevLabel.Text = szamlalo + ". Csapat neve:";
            csapatNevButton.Enabled = false;
            csapatNevTextBox.Enabled = false;

            csapatSzamLabel.Enabled = true;
            csapatSzamNumericUpDown.Enabled = true;
            csapatSzamButton.Enabled = true;
        }

        private void alapButton_Click(object sender, EventArgs e)
        {
            Bevitel_Load(sender, e);
        }

        private void csapatSzamButton_Click(object sender, EventArgs e)
        {
            controlForm.CsapatSzam = Convert.ToInt32(csapatSzamNumericUpDown.Value);
            csapatSzamLabel.Enabled = false;
            csapatSzamNumericUpDown.Enabled = false;
            csapatSzamButton.Enabled = false;

            csapatNevTextBox.Enabled = true;
            csapatNevButton.Enabled = true;
        }

        private void csapatNevButton_Click(object sender, EventArgs e)
        {
            iskolaNevIndex = 0;
            bool vanE = csapatNevTextBox.Text != controlForm.CsapatNevek[0] && 
                csapatNevTextBox.Text != controlForm.CsapatNevek[1] && 
                csapatNevTextBox.Text != controlForm.CsapatNevek[2];

            if (csapatNevTextBox.Text != "" && vanE)
            {
                csapatNevLabel.Text = (szamlalo + 1) + ". Csapat neve:";

                if (szamlalo <=4 && szamlalo >= 1)
                {
                    controlForm.CsapatNevek[szamlalo-1] = csapatNevTextBox.Text;
                    csapatNevTextBox.Clear();
                }

                if (szamlalo == controlForm.CsapatSzam)
                {
                    this.Hide();
                    controlForm.Show();
                }

                szamlalo++;
            }
            else if (csapatNevTextBox.Text == "")
            {
                MessageBox.Show("Üresen hagytad a mezöt!");
            }
            else
            {
                MessageBox.Show("Ez a név már foglalt!");
            }
        }

        private void select_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (csapatSzamButton.Enabled == true)
                {
                    csapatSzamButton_Click(this, new EventArgs());
                }
                else if (csapatNevButton.Enabled == true)
                {
                    csapatNevButton_Click(this, new EventArgs());
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (csapatSzamButton.Enabled == false && csapatNevButton.Enabled == true && iskolaNevIndex < iskolaNev.Length)
                {
                    csapatNevTextBox.Text = iskolaNev[iskolaNevIndex];
                    iskolaNevIndex++;
                }
                else
                {
                    iskolaNevIndex = 0;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (csapatSzamButton.Enabled == false && csapatNevButton.Enabled == true && iskolaNevIndex > 0)
                {
                    csapatNevTextBox.Text = iskolaNev[iskolaNevIndex];
                    iskolaNevIndex--;
                }
                else
                {
                    iskolaNevIndex = 0;
                }
            }
        }

        private void adatKezelesButton_Click(object sender, EventArgs e)
        {
            AdatkezeloForm ak = new AdatkezeloForm();
            ak.Show();
        }
    }
}
