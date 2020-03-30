using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotyafoglalo
{
    public class Cell
    {
        public static readonly int CSAPAT_1 = 1;
        public static readonly int CSAPAT_2 = 2;
        public static readonly int CSAPAT_3 = 3;
        public static readonly int CSAPAT_4 = 4;
        public static readonly int VAR_MEZO_ERTEK = 0;
        public static readonly int BELSO_MEZO_ERTEK = 300;
        public static readonly int KULSO_MEZO_ERTEK = 400;

        private PictureBox picBoxRef;
        private int mezoTulaj;
        private int mezoErteke;

        public Cell(int requiredfieldOwner, PictureBox picBox, int valueOfField)
        {
            this.mezoTulaj = requiredfieldOwner;
            this.picBoxRef = picBox;
            this.mezoErteke = valueOfField;
        }

        public int getMezoTulaj()
        {
            return mezoTulaj;
        }

        public void mezoTulajValtas(int requiredFieldOwner)
        {
            this.mezoTulaj = requiredFieldOwner;
        }
        public int getErtek()
        {
            return mezoErteke;
        }

        public PictureBox getPBox()
        {
            return picBoxRef;
        }
    }
}