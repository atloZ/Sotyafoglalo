using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sotyafoglalo
{

    public partial class JatekTer : Form
    {
        #region Csapatok beallas
        private readonly string NEGY_CSAPAT =
            "1-400;1-0;1-400;4-400;4-0;4-400;1-400;1-300;1-300;4-300;4-300;4-400;1-400;1-300;1-300;4-300;4-300;4-400;2-400;2-300;2-300;3-300;3-300;3-400;2-400;2-300;2-300;3-300;3-300;3-400;2-0;2-400;2-400;3-400;3-0;3-400";

        private readonly string HAROM_CSAPAT =
            "1-400;1-0;1-400;1-400;3-400;3-400;1-400;1-300;1-300;1-300;3-300;3-400;1-400;1-300;1-300;1-300;3-300;3-400;2-400;2-300;2-300;2-300;3-300;3-400;2-400;2-300;2-300;2-300;3-300;3-400;2-0;2-400;2-400;2-400;3-400;3-0";

        private readonly string KET_CSAPAT =
            "1-400;1-0;1-400;1-400;1-400;1-400;1-400;1-300;1-300;1-300;1-300;1-400;1-400;1-300;1-300;1-300;1-300;1-400;2-400;2-300;2-300;2-300;2-300;2-400;2-400;2-300;2-300;2-300;2-300;2-400;2-400;2-400;2-400;2-400;2-0;2-400";
        #endregion

        #region Valtozok
        private int csapatSzam;
        private string[] csapatNevek = new string[4];
        private bool futoKor = false;
        private int[] csapatPontok = new int[4];
        
        private Control cForm = null;

        private List<GroupBox> groups = new List<GroupBox>();
        private Cell[,] cellak = new Cell[6, 6];
        private PictureBox[,] pictureBoxok = new PictureBox[6, 6];
        private List<Label> pontok = new List<Label>();

        private int tamadoCsapatSzama;
        public int CsapatSzam { get => csapatSzam; set => csapatSzam = value; }
        public string[] CsapatNevek { get => csapatNevek; set => csapatNevek = value; }
        public int[] CsapatPontok { get => csapatPontok; }
        #endregion

        public JatekTer(Form callingForm)
        {
            cForm = callingForm as Control;
            InitializeComponent();
        }

        #region Funkciok
        private void JatekTer_Load(object sender, EventArgs e)
        {
            pontok.Add(pointDisplay1);
            pontok.Add(pointDisplay2);
            pontok.Add(pointDisplay3);
            pontok.Add(pointDisplay4);
            groups.Add(team1Box);
            groups.Add(team2Box);
            groups.Add(team3Box);
            groups.Add(team4Box);

            //PictureBox mátrix első sor

            pictureBoxok[0, 0] = pictureBox1;
            pictureBoxok[0, 1] = pictureBox2;
            pictureBoxok[0, 2] = pictureBox3;
            pictureBoxok[0, 3] = pictureBox4;
            pictureBoxok[0, 4] = pictureBox5;
            pictureBoxok[0, 5] = pictureBox6;

            //PictureBox mátrix második sor

            pictureBoxok[1, 0] = pictureBox7;
            pictureBoxok[1, 1] = pictureBox8;
            pictureBoxok[1, 2] = pictureBox9;
            pictureBoxok[1, 3] = pictureBox10;
            pictureBoxok[1, 4] = pictureBox11;
            pictureBoxok[1, 5] = pictureBox12;

            //PictureBox mátrix harmadik sor

            pictureBoxok[2, 0] = pictureBox13;
            pictureBoxok[2, 1] = pictureBox14;
            pictureBoxok[2, 2] = pictureBox15;
            pictureBoxok[2, 3] = pictureBox16;
            pictureBoxok[2, 4] = pictureBox17;
            pictureBoxok[2, 5] = pictureBox18;

            //PictureBox mátrix negyedik sor

            pictureBoxok[3, 0] = pictureBox19;
            pictureBoxok[3, 1] = pictureBox20;
            pictureBoxok[3, 2] = pictureBox21;
            pictureBoxok[3, 3] = pictureBox22;
            pictureBoxok[3, 4] = pictureBox23;
            pictureBoxok[3, 5] = pictureBox24;

            //PictureBox mátrix ötödik sor

            pictureBoxok[4, 0] = pictureBox25;
            pictureBoxok[4, 1] = pictureBox26;
            pictureBoxok[4, 2] = pictureBox27;
            pictureBoxok[4, 3] = pictureBox28;
            pictureBoxok[4, 4] = pictureBox29;
            pictureBoxok[4, 5] = pictureBox30;

            //PictureBox mátrix hatodik sor

            pictureBoxok[5, 0] = pictureBox31;
            pictureBoxok[5, 1] = pictureBox32;
            pictureBoxok[5, 2] = pictureBox33;
            pictureBoxok[5, 3] = pictureBox34;
            pictureBoxok[5, 4] = pictureBox35;
            pictureBoxok[5, 5] = pictureBox36;

            for (int i = 0; i < csapatSzam; i++)
            {
                int alapPont = 0;
                groups[i].Text = csapatNevek[i];

                switch (csapatSzam)
                {
                    case 2:
                        alapPont = 5600;
                        break;
                    case 3:
                        alapPont = 4000;
                        break;
                    case 4:
                        alapPont = 2800;
                        break;
                    default:
                        break;
                }
                setCsapatPont(i, alapPont);
            }
            for (int i = csapatSzam; i < 4; i++)
            {
                groups[i].Visible = false;
            }

            string terkepFelosztas = "";
            if (csapatSzam == 4)
            {
                terkepFelosztas = NEGY_CSAPAT;
            }
            else if (csapatSzam == 3)
            {
                terkepFelosztas = HAROM_CSAPAT;
            }
            else
            {
                terkepFelosztas = KET_CSAPAT;
            }
            int terkepSzamlalo = 0;
            string[] terkep = terkepFelosztas.Split(';');
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Image cellaKep = Properties.Resources.kek400;

                    string jelenlegiCella = terkep[terkepSzamlalo];

                    string[] szamok = jelenlegiCella.Split('-');

                    mezoErtekadas(i, j, Convert.ToInt32(szamok[0]), Convert.ToInt32(szamok[1]), true);

                    terkepSzamlalo++;
                }
            }
        }

        private bool tamadhatoE(int tamadocsapatSzam, int tamadandoX, int tamadandoY)
        {
            if (tamadocsapatSzam != cellak[tamadandoX, tamadandoY].getMezoTulaj() && cellak[tamadandoX, tamadandoY].getErtek() != Cell.VAR_MEZO_ERTEK)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (tamadocsapatSzam == cellak[i, j].getMezoTulaj())
                        {
                            if (Math.Sqrt(Math.Pow((i - tamadandoX), 2) + Math.Pow((j - tamadandoY), 2)) == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public void setKovetkezoCsapatNeve(string nev)
        {
            nextTeamLabel.Text = nev;
        }

        private void mezoTamadas(int x, int y, int mezoTulaj, int mezoErtek)
        {
            if (tamadhatoE(tamadoCsapatSzama, x, y) && futoKor)
            {
                cForm.setSecondTeamLabel(mezoTulaj);
                futoKor = false;
                cForm.getTamadottMezo(x, y, mezoErtek);
            }
            else
            {
                cForm.setSecondTeamLabel(-1);
            }
        }

        public void tamadas(int attackingNumber)
        {
            tamadoCsapatSzama = attackingNumber;
            futoKor = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int fOwner = cellak[i, j].getMezoTulaj();
                    int x = i;
                    int y = j;
                    int val = cellak[i, j].getErtek();
                    cellak[i, j].getPBox().Click += delegate { mezoTamadas(x, y, fOwner, val); };    //set onclick
                }
            }
        }

        public void setCsapatPont(int csapatSzam, int pluszPont)
        {
            csapatPontok[csapatSzam] += pluszPont;
            pontok[csapatSzam].Text = csapatPontok[csapatSzam] + "";
        }

        public void changeTerulet(int x, int y, int ujTulaj, int ertek)
        {
            cellak[x, y].mezoTulajValtas(ujTulaj);
            mezoErtekadas(x, y, ujTulaj, ertek, false);
        }

        private void mezoErtekadas(int x, int y, int tulaj, int ertek, bool load) //true akkor load
        {
            string mezoSzin = "";
            string mezoTipus = "";

            switch (tulaj)
            {
                case 1:
                    mezoSzin = "kek";
                    break;
                case 2:
                    mezoSzin = "piros";
                    break;
                case 3:
                    mezoSzin = "rozsa";
                    break;
                case 4:
                    mezoSzin = "sarga";
                    break;
                default:
                    mezoSzin = "";
                    break;
            }
            switch (ertek)
            {
                case 0:
                    mezoTipus = "var";
                    break;
                case 300:
                    mezoTipus = "300";
                    break;
                case 400:
                    mezoTipus = "400";
                    break;
                default:
                    mezoTipus = "";
                    break;
            }
            string kepID = mezoSzin + mezoTipus;
            if (load)
            {
                cellak[x, y] = new Cell(tulaj, pictureBoxok[x, y], ertek);
            }

            cellak[x, y].getPBox().Image = (Image)Properties.Resources.ResourceManager.GetObject(kepID);
            cellak[x, y].getPBox().Refresh();
        }
        
        private void JatekTer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Amig fut a játék addig ne csukj be! Biztos véget akkar vetni ennek?", "Játék vége", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            cForm.Dispose();
        }
        #endregion
    }
}
