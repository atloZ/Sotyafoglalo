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

        public static readonly int OCCUPIED_BY_TEAM_1 = 0;
        public static readonly int OCCUPIED_BY_TEAM_2 = 1;
        public static readonly int OCCUPIED_BY_TEAM_3 = 2;
        public static readonly int OCCUPIED_BY_TEAM_4 = 3;
        public static readonly int FORTRESS_FIELD = 5;
        public static readonly int REGULAR_FIELD = 6;
        public static readonly int FORTRESS_FIELD_VALUE = 0;
        public static readonly int INNER_FIELD_VALUE = 300;
        public static readonly int OUTER_FIELD_VALUE = 400;
        private PictureBox picBoxRef;
        private readonly int type;
        private int fieldOwner;
        private int valueOfField;

        public Cell(int requiredType, int requiredfieldOwner, PictureBox picBox, int valueOfField)
        {
            this.type = requiredType;
            this.fieldOwner = requiredfieldOwner;
            this.picBoxRef = picBox;
            this.valueOfField = valueOfField;
        }

        public int getType()
        {
            return type;
        }

        public int getFieldOwner()
        {
            return fieldOwner;
        }

        public void changeFieldOwner(int requiredFieldOwner)
        {
            fieldOwner = requiredFieldOwner;
        }
        public int getValue()
        {
            return valueOfField;
        }

        public PictureBox getPBox()
        {
            return picBoxRef;
        }

    }
}