using Sotyafoglalo.Frontend;
using System;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public partial class Bejelentkezes : Form
    {
        #region Valtozok
        Control controlForm = new Control();

        private int szamlalo;
        private int iskolaNevIndex;
        private readonly string[] iskolaNev = { "Arany", "Benedek", "Dr. Mező alsó", "Dr. Mező felső", "Dr. Török Béla", "Heltai", "Herman alsó", "Herman felső	", "Hunyadi", "Jókai", "Jókai", "Kaffka", "Liszt", "Móra", "Munkácsy alsó", "Munkácsy felső", "Németh Imre", "Széchenyi", "Vakok" };
        #endregion

        public Bejelentkezes()
        {
            InitializeComponent();
        }
        
        #region Funkciok
        private void Bevitel_Load(object sender, EventArgs e)
        {
            szamlalo = 1;

            csapatNevLabel.Text = szamlalo + ". Csapat neve:";
            csapatNevButton.Enabled = false;
            csapatNevTextBox.Enabled = false;

            csapatSzamLabel.Enabled = true;
            csapatSzamNumericUpDown.Enabled = true;
            csapatSzamButton.Enabled = true;
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
                    controlForm.Show();
                    this.Hide();
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
            new AdatkezeloForm().Show();
        }
        #endregion
    }
}
