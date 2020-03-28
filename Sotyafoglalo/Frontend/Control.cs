using Sotyafoglalo.Backend;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public partial class Control : Form
    {
        private string[] csapatNevek = new string[4];
        private int csapatSzam;
        public string[] CsapatNevek { get => csapatNevek; set => csapatNevek = value; }
        public int CsapatSzam { get => csapatSzam; set => csapatSzam = value; }

        public Stopwatch Stopwatch = new Stopwatch();

        private List<Kerdes> kerdesekList = new List<Kerdes>();
        private List<TippKerdes> tippekList = new List<TippKerdes>();

        private JatekTer jatekTerForm;
        private Bejelentkezes bevitelForm;

        private int[] lepesek;
        private int kerdesSzam = 0;
        private int hatralevoKerdesekSzama;
        private int lepesekIndex = 0;
        private int tippkerdesSzam = 0;

        private Kerdesek kForm;
        private TipKerdesek tForm;

        private int vedoNum;
        private int tamadottX;
        private int tamadottY;
        private int tamadottErtek;
        private string joValasz;
        private int joHelye;
        private bool isItValasztos = true;
        private int joTipp;
        //tippkérdéshez kell
        private int tamadoTipp;
        private int vedoTipp;
        private int eddigiTippekSzama = 0;

        public void stopperStarter()
        {
            this.Stopwatch.Reset();
            this.Stopwatch.Start();
        }

        public void stopperStop()
        {
            this.Stopwatch.Stop();
        }

        public Control()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopperLabel.Text = Stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.ff");
            kerdesekSzamaLabel.Text = "Hátralévő körök száma: " + hatralevoKerdesekSzama.ToString();

            if (isItValasztos)
            {
                if (Stopwatch.ElapsedMilliseconds == 120000) //két perc
                {
                    stopperStop();
                    kForm.setBGColor(joHelye);
                    checkAnswers();
                }
            }
            else
            {
                if (Stopwatch.ElapsedMilliseconds == 60000) //egy perc
                {
                    stopperStop();
                    tForm.displayHelyesValasz();
                    checkTippek();
                }
            }
        }

        public Screen GetSecondaryScreen()
        {
            if (Screen.AllScreens.Length == 1)
            {
                return null;
            }

            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == false)
                {
                    return screen;
                }
            }

            return null;
        }

        private void showOnSecondaryScreen(Form f)
        {
            if (Screen.AllScreens.Length > 1)
            {
                f.StartPosition = FormStartPosition.Manual;
                Screen screen = GetSecondaryScreen();
                f.Location = screen.WorkingArea.Location;
                f.Size = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
                f.Show();
            }
            else if (Screen.AllScreens.Length == 1)
            {
                f.Show();
            }
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            jatekTerForm = new JatekTer(this);
            jatekTerForm.CsapatNevek = csapatNevek;    //dbhelper
            jatekTerForm.CsapatSzam = csapatSzam;

            if (Screen.AllScreens.Length > 1)
            {
                // Important !
                jatekTerForm.StartPosition = FormStartPosition.Manual;

                // Get the second monitor screen
                Screen screen = GetSecondaryScreen();

                // set the location to the top left of the second screen
                jatekTerForm.Location = screen.WorkingArea.Location;

                // set it fullscreen
                jatekTerForm.Size = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);

                // Show the form
                jatekTerForm.Show();
            }
            else if (Screen.AllScreens.Length == 1)
            {
                jatekTerForm.Show();
            }

            jatekInditasButton.Enabled = false;
            korInditasButton.Enabled = true;
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            t_kerdesOKButton.Enabled = false;
            v_kerdesOKButton.Enabled = false;
            t_valaszDomainUpDown.Enabled = false;
            v_valaszDomainUpDown.Enabled = false;

            //dbhelper
            bevitelForm = new Bejelentkezes();
            StreamReader kerdesInput = new StreamReader(bevitelForm.KerdesekPath1);
            while (!kerdesInput.EndOfStream)
            {
                string[] beolvasott = kerdesInput.ReadLine().Split(';');
                kerdesekList.Add(new Kerdes(beolvasott[1], beolvasott[2], beolvasott[3], beolvasott[4], beolvasott[5], Convert.ToInt32(beolvasott[0])));
                kerdesSzam++;
            }

            hatralevoKerdesekSzama = kerdesSzam;

            switch (csapatSzam)
            {
                case 2:
                    lepesek = new int[] { 1, 2, 2, 1, 1, 2, 2, 1, 1, 2, 2, 1 };
                    break;
                case 3:
                    lepesek = new int[] { 1, 2, 3, 1, 3, 2, 2, 1, 3, 2, 3, 1, 3, 1, 2, 3, 2, 1 };
                    break;
                case 4:
                    lepesek = new int[] { 1, 2, 3, 4, 2, 4, 1, 3, 3, 1, 4, 2, 4, 3, 1, 2, 2, 3, 4, 1, 1, 4, 3, 2 };
                    break;

                default:
                    throw new Exception("Hibás lépésgenerálás");
            }

            //dbhelper
            bevitelForm = new Bejelentkezes();
            StreamReader tippelosek = new StreamReader(bevitelForm.TippkerdesekPath1);

            while (!tippelosek.EndOfStream)
            {
                string[] beolv = tippelosek.ReadLine().Split(';');
                tippekList.Add(new TippKerdes(beolv[1], Convert.ToInt32(beolv[0]), Convert.ToInt32(beolv[2])));
                tippkerdesSzam++;
            }

            korNyerteseLabel.Text = "";
        }

        private void startTurnBtn_Click(object sender, EventArgs e)
        {
            if (hatralevoKerdesekSzama > 0)
            {
                korNyerteseLabel.Text = "Aktuális csapat válaszon mezőt!";
                if (kForm != null)
                {
                    kForm.bezarhat = true;
                    kForm.Close();
                }
                if (tForm != null)
                {
                    tForm.bezarhat = true;
                    tForm.Close();
                }

                isItValasztos = true;

                tamadoCsapatGroupBox.Text = csapatNevek[lepesek[lepesekIndex]];
                jatekTerForm.setNextTeamName(csapatNevek[lepesek[lepesekIndex]]);
                jatekTerForm.Attack(lepesek[lepesekIndex]);

                hanyanValaszoltak = 0;
                eddigiTippekSzama = 0;

                t_tippTextBox.Visible = false;
                v_tippTextBox.Visible = false;

                t_gyorsabbCheckBox.Visible = false;
                v_gyorsabbCheckBox.Visible = false;

                v_tippOKButton.Visible = false;
                v_tippOKButton.Visible = false;

                korInditasButton.Enabled = false;
            }
            else if (hatralevoKerdesekSzama == 1)
            {
                MessageBox.Show("Már csak egy kérdés van!");
            }
            else
            {
                MessageBox.Show("Elfogytak a kérdések!");
            }
        }

        public void setSecondTeamLabel(int secNum)
        {
            if (secNum == -1)
            {
                vedoCsapatGroupBox.Text = "Ezt a területet nem lehet választani";
            }
            else
            {
                vedoNum = secNum;
                vedoCsapatGroupBox.Text = csapatNevek[secNum];
                kForm = new Kerdesek();
                kForm.Show();
                kerdesInditasButton.Enabled = true;
            }
        }

        public void getAttackedField(int x, int y, int value)
        {
            tamadottX = x;
            tamadottY = y;
            tamadottErtek = value;
        }

        private void stopperBtn_Click(object sender, EventArgs e)
        {
            korNyerteseLabel.Text = "Csapat adjon választ a kérdésre!";

            if (isItValasztos)
            {
                t_kerdesOKButton.Enabled = true;
                v_kerdesOKButton.Enabled = true;
                t_valaszDomainUpDown.ResetText();
                v_valaszDomainUpDown.ResetText();
                t_valaszDomainUpDown.Enabled = true;
                v_valaszDomainUpDown.Enabled = true;
                kerdesInditasButton.Enabled = false;

                //dbhelper
                Random kerdesRandom = new Random();
                int aktualisSzam = kerdesRandom.Next(0, kerdesSzam);
                Kerdes aktualisKerdes = kerdesekList[aktualisSzam];
                kerdesekList.RemoveAt(aktualisSzam);
                kerdesSzam--;

                String[] kerdesPasszolni = new string[5];
                kerdesPasszolni[0] = aktualisKerdes.getKerdes();

                //kérdések kiírása és keverése
                Random random = new Random();
                joHelye = random.Next(0, 4);
                int rossz1Helye = (joHelye + 1) % 4;
                int rossz2Helye = (joHelye + 2) % 4;
                int rossz3Helye = (joHelye + 3) % 4;

                kerdesPasszolni[joHelye + 1] = aktualisKerdes.getJoValasz();
                kerdesPasszolni[rossz1Helye + 1] = aktualisKerdes.getRossz1();
                kerdesPasszolni[rossz2Helye + 1] = aktualisKerdes.getRossz2();
                kerdesPasszolni[rossz3Helye + 1] = aktualisKerdes.getRossz3();

                switch (joHelye)
                {
                    case 0:
                        joValasz = "A";
                        break;
                    case 1:
                        joValasz = "B";
                        break;
                    case 2:
                        joValasz = "C";
                        break;
                    case 3:
                        joValasz = "D";
                        break;
                    default:
                        joValasz = "";
                        break;
                }

                kForm.KerdesTomb = kerdesPasszolni;
                kForm.setKerdesek();
                kerdesekSzamaLabel.Text = aktualisKerdes.getID().ToString();
                stopperStarter();
            }
            else
            {
                t_tippTextBox.ResetText();
                v_tippTextBox.ResetText();

                kerdesInditasButton.Enabled = false;

                //dbhelper
                Random tippRandom = new Random();
                int aktualisTippSzam = tippRandom.Next(0, tippkerdesSzam);
                TippKerdes aktualisTippKerdes = tippekList[aktualisTippSzam];
                tippekList.RemoveAt(aktualisTippSzam);
                tippkerdesSzam--;
                kerdesekSzamaLabel.Text = aktualisTippKerdes.getID() + "";
                tForm.setKerdes(aktualisTippKerdes.getKerdes(), aktualisTippKerdes.getValasz());
                joTipp = aktualisTippKerdes.getValasz();
                stopperStarter();
            }
        }

        private string tamadoValasz = "";
        private string vedoValasz = "";
        private int hanyanValaszoltak = 0;
        private void OkButton1_Click(object sender, EventArgs e)
        {
            if (t_valaszDomainUpDown.Text != "")
            {
                tamadoValasz = t_valaszDomainUpDown.SelectedItem.ToString();
                hanyanValaszoltak++;
                t_kerdesOKButton.Enabled = false;
                t_valaszDomainUpDown.Enabled = false;
                if (hanyanValaszoltak == 2)
                {
                    checkAnswers();
                }
            }
            else
            {
                MessageBox.Show("üres");
            }
        }

        private void okButton2_Click(object sender, EventArgs e)
        {
            if (v_valaszDomainUpDown.Text != "")
            {
                vedoValasz = v_valaszDomainUpDown.SelectedItem.ToString();
                hanyanValaszoltak++;
                v_kerdesOKButton.Enabled = false;
                if (hanyanValaszoltak == 2)
                {
                    checkAnswers();
                }
            }
            else
            {
                MessageBox.Show("üres");
            }
        }

        private void checkAnswers()
        {
            stopperStop();
            hatralevoKerdesekSzama--;

            t_kerdesOKButton.Enabled = false;
            v_kerdesOKButton.Enabled = false;
            t_valaszDomainUpDown.Enabled = false;
            v_valaszDomainUpDown.Enabled = false;

            if (vedoValasz == tamadoValasz)
            {
                if (vedoValasz == joValasz)
                {
                    //indítson egy tippelőset
                    startTippelosKerdes();
                }
                else
                {
                    //ne adjon pontot 
                    kForm.setBGColor(joHelye);
                    korNyerteseLabel.Text = "Senki";
                    lepesekIndex++;

                    korInditasButton.Enabled = true;
                    kerdesInditasButton.Enabled = false;
                }
            }
            else if (vedoValasz == joValasz)
            {
                kForm.setBGColor(joHelye);
                vedoNyert();
                lepesekIndex++;
                korInditasButton.Enabled = true;
                kerdesInditasButton.Enabled = false;
            }
            else if (tamadoValasz == joValasz)
            {
                //a támadó kapja meg a területet
                //a támadó kapja meg a pontot
                //a védő veszítse el a pontot
                tamadoNyert();
                lepesekIndex++;

                korInditasButton.Enabled = true;
                kerdesInditasButton.Enabled = false;
            }
            else
            {
                //senki nem kap semmit
                kForm.setBGColor(joHelye);
                korNyerteseLabel.Text = "Senki";
                lepesekIndex++;

                korInditasButton.Enabled = true;
                kerdesInditasButton.Enabled = false;
            }
        }

        private void startTippelosKerdes()
        {
            kForm.bezarhat = true;
            kForm.Close();

            stopperStop();

            v_tippOKButton.Enabled = true;
            t_tippOKButton.Enabled = true;
            t_kerdesOKButton.Enabled = false;
            v_kerdesOKButton.Enabled = false;

            t_valaszDomainUpDown.Enabled = false;
            v_valaszDomainUpDown.Enabled = false;

            tForm = new TipKerdesek();
            tForm.Show();
            isItValasztos = false;
            t_tippTextBox.Visible = true;
            v_tippTextBox.Visible = true;
            t_gyorsabbCheckBox.Visible = true;
            v_gyorsabbCheckBox.Visible = true;
            t_tippOKButton.Visible = true;
            v_tippOKButton.Visible = true;
            kerdesInditasButton.Enabled = true;

        }

        private void OKButton3_Click(object sender, EventArgs e)
        {
            if (t_tippTextBox.Text != "")
            {
                tamadoTipp = Convert.ToInt32(t_tippTextBox.Text);
                t_tippOKButton.Enabled = false;
                eddigiTippekSzama++;
                if (eddigiTippekSzama == 2)
                {
                    checkTippek();
                }
            }
            else
            {
                MessageBox.Show("üres");
            }
        }

        private void OKButton4_Click(object sender, EventArgs e)
        {
            if (v_tippTextBox.Text != "")
            {
                vedoTipp = Convert.ToInt32(v_tippTextBox.Text);
                v_tippOKButton.Enabled = false;
                eddigiTippekSzama++;
                if (eddigiTippekSzama == 2)
                {
                    checkTippek();
                }
            }
            else
            {
                MessageBox.Show("üres");
            }
        }

        private void checkTippek()
        {
            stopperStop();

            int abs1 = (int)Math.Abs(joTipp - tamadoTipp);
            int abs2 = (int)Math.Abs(joTipp - vedoTipp);
            if (abs1 == abs2)
            {
                if (t_gyorsabbCheckBox.Checked)
                {
                    tamadoNyert();
                }
                else if (v_gyorsabbCheckBox.Checked)
                {
                    tForm.displayHelyesValasz();
                    vedoNyert();
                }
            }
            else
            {
                if (abs1 < abs2)
                {
                    tamadoNyert();
                }
                else
                {
                    tForm.displayHelyesValasz();
                    korNyerteseLabel.Text = csapatNevek[vedoNum];
                }
            }
            lepesekIndex++;
            korInditasButton.Enabled = true;
            kerdesInditasButton.Enabled = false;
        }

        private void vedoNyert()
        {
            jatekTerForm.setTeamPoints(vedoNum, 100);
            korNyerteseLabel.Text = csapatNevek[vedoNum];
        }

        private void tamadoNyert()
        {
            jatekTerForm.setTeamPoints(lepesek[lepesekIndex], tamadottErtek);
            jatekTerForm.setTeamPoints(vedoNum, -tamadottErtek);
            jatekTerForm.changeTerulet(tamadottX, tamadottY, lepesek[lepesekIndex], tamadottErtek);
            tForm.displayHelyesValasz();
            korNyerteseLabel.Text = csapatNevek[lepesek[lepesekIndex]];
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopwatch.Stop();
            MessageBox.Show("Amig fut a játék addig ne csukj be!");
            Stopwatch.Start();
            e.Cancel = true;
        }

        private void gyorsabb1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //legyen a másik false
        }
    }
}