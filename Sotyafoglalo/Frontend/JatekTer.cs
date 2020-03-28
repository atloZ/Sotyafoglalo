using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sotyafoglalo
{

    public partial class JatekTer : Form
    {
        private int csapatSzam;
        private string[] csapatNevek = new string[4];
        private bool isItTurn = false;
        private Control controlForm = new Control();
        private Control cForm = null;

        public JatekTer()
        {
            InitializeComponent();
        }

        public JatekTer(Form callingForm)
        {
            cForm = callingForm as Control;
            InitializeComponent();
        }

        public int CsapatSzam { get => csapatSzam; set => csapatSzam = value; }
        public string[] CsapatNevek { get => csapatNevek; set => csapatNevek = value; }
        private int[] csapatPontok = new int[4];

        private readonly string NEGY_CSAPAT =
            "1-400;1-0;1-400;4-400;4-0;4-400;1-400;1-300;1-300;4-300;4-300;4-400;1-400;1-300;1-300;4-300;4-300;4-400;2-400;2-300;2-300;3-300;3-300;3-400;2-400;2-300;2-300;3-300;3-300;3-400;2-0;2-400;2-400;3-400;3-0;3-400";

        private readonly string HAROM_CSAPAT =
            "1-400;1-0;1-400;1-400;3-400;3-400;1-400;1-300;1-300;1-300;3-300;3-400;1-400;1-300;1-300;1-300;3-300;3-400;2-400;2-300;2-300;2-300;3-300;3-400;2-400;2-300;2-300;2-300;3-300;3-400;2-0;2-400;2-400;2-400;3-400;3-0";

        private readonly string KET_CSAPAT =
            "1-400;1-0;1-400;1-400;1-400;1-400;1-400;1-300;1-300;1-300;1-300;1-400;1-400;1-300;1-300;1-300;1-300;1-400;2-400;2-300;2-300;2-300;2-300;2-400;2-400;2-300;2-300;2-300;2-300;2-400;2-400;2-400;2-400;2-400;2-0;2-400";

        private List<GroupBox> groups = new List<GroupBox>();
        private Cell[,] cells = new Cell[6, 6];
        private PictureBox[,] pictureBoxes = new PictureBox[6, 6];
        private int attackingTeamNumber;
        private List<Label> pontok = new List<Label>();

        private void Form1_Load(object sender, EventArgs e)
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

            pictureBoxes[0, 0] = pictureBox1;
            pictureBoxes[0, 1] = pictureBox2;
            pictureBoxes[0, 2] = pictureBox3;
            pictureBoxes[0, 3] = pictureBox4;
            pictureBoxes[0, 4] = pictureBox5;
            pictureBoxes[0, 5] = pictureBox6;

            //PictureBox mátrix második sor

            pictureBoxes[1, 0] = pictureBox7;
            pictureBoxes[1, 1] = pictureBox8;
            pictureBoxes[1, 2] = pictureBox9;
            pictureBoxes[1, 3] = pictureBox10;
            pictureBoxes[1, 4] = pictureBox11;
            pictureBoxes[1, 5] = pictureBox12;

            //PictureBox mátrix harmadik sor

            pictureBoxes[2, 0] = pictureBox13;
            pictureBoxes[2, 1] = pictureBox14;
            pictureBoxes[2, 2] = pictureBox15;
            pictureBoxes[2, 3] = pictureBox16;
            pictureBoxes[2, 4] = pictureBox17;
            pictureBoxes[2, 5] = pictureBox18;

            //PictureBox mátrix negyedik sor

            pictureBoxes[3, 0] = pictureBox19;
            pictureBoxes[3, 1] = pictureBox20;
            pictureBoxes[3, 2] = pictureBox21;
            pictureBoxes[3, 3] = pictureBox22;
            pictureBoxes[3, 4] = pictureBox23;
            pictureBoxes[3, 5] = pictureBox24;

            //PictureBox mátrix ötödik sor

            pictureBoxes[4, 0] = pictureBox25;
            pictureBoxes[4, 1] = pictureBox26;
            pictureBoxes[4, 2] = pictureBox27;
            pictureBoxes[4, 3] = pictureBox28;
            pictureBoxes[4, 4] = pictureBox29;
            pictureBoxes[4, 5] = pictureBox30;

            //PictureBox mátrix hatodik sor

            pictureBoxes[5, 0] = pictureBox31;
            pictureBoxes[5, 1] = pictureBox32;
            pictureBoxes[5, 2] = pictureBox33;
            pictureBoxes[5, 3] = pictureBox34;
            pictureBoxes[5, 4] = pictureBox35;
            pictureBoxes[5, 5] = pictureBox36;

            for (int i = 0; i < csapatSzam; i++)
            {
                groups[i].Text = csapatNevek[i];
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
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tamadocsapatSzam == cells[i, j].getFieldOwner() && cells[i, j].getValue() != Cell.FORTRESS_FIELD_VALUE)
                    {
                        if (Math.Sqrt(Math.Pow((i - tamadandoX), 2) + Math.Pow((j - tamadandoY), 2)) == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void setNextTeamName(string nev)
        {
            nextTeamLabel.Text = nev;
        }

        private void AttackField(int x, int y, int fieldOwner, int fieldValue)
        {
            if (tamadhatoE(attackingTeamNumber, x, y))
            {
                cForm.setSecondTeamLabel(fieldOwner);
                isItTurn = false;
                cForm.getAttackedField(x, y, fieldValue);
            }
            else
            {
                cForm.setSecondTeamLabel(-1);
            }
        }

        public void Attack(int attackingNumber)
        {
            attackingTeamNumber = attackingNumber;
            isItTurn = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int fOwner = cells[i, j].getFieldOwner();
                    int x = i;
                    int y = j;
                    int val = cells[i, j].getValue();
                    cells[i, j].getPBox().Click += delegate { AttackField(x, y, fOwner, val); };    //set onclick
                }
            }
        }

        public void setTeamPoints(int teamNumber, int pointsToIncrease)
        {
            csapatPontok[teamNumber] += pointsToIncrease;
            pontok[teamNumber].Text = csapatPontok[teamNumber] + "";
        }

        public void changeTerulet(int x, int y, int ujTulaj, int ertek)
        {
            cells[x, y].changeFieldOwner(ujTulaj);
            mezoErtekadas(x, y, ujTulaj, ertek, false);
        }

        private void mezoErtekadas(int x, int y, int tulaj, int ertek, bool load) //true akkor load
        {
            string firstHalfOfPicutre = "";
            string secondHalfOfPicture = "";
            int cellaTipus = -1;

            switch (tulaj)
            {
                case 1:
                    firstHalfOfPicutre = "kek";
                    break;
                case 2:
                    firstHalfOfPicutre = "piros";
                    break;
                case 3:
                    firstHalfOfPicutre = "rozsa";
                    break;
                case 4:
                    firstHalfOfPicutre = "sarga";
                    break;
                default:
                    firstHalfOfPicutre = "";
                    break;
            }
            switch (ertek)
            {
                case 0:
                    secondHalfOfPicture = "Var";
                    cellaTipus = Cell.FORTRESS_FIELD;
                    break;
                case 300:
                    secondHalfOfPicture = "300";
                    cellaTipus = Cell.REGULAR_FIELD;
                    break;
                case 400:
                    secondHalfOfPicture = "400";
                    cellaTipus = Cell.REGULAR_FIELD;
                    break;
                default:
                    secondHalfOfPicture = "";
                    break;
            }
            string kepID = firstHalfOfPicutre + secondHalfOfPicture;
            if (load)
            {
                cells[x, y] = new Cell(cellaTipus, tulaj, pictureBoxes[x, y], ertek);
            }

            cells[x, y].getPBox().Image = (Image)Properties.Resources.ResourceManager.GetObject(kepID);
            cells[x, y].getPBox().Refresh();
        }
        
        private void JatekTer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bejelentkezes obj = (Bejelentkezes)Application.OpenForms["Bevitel"];
            obj.Close();
        }
    }
}
