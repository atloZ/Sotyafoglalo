using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotyafoglalo.Backend
{
    public class TippKerdes
    {
        private string kerdes;
        private int kerdesID;
        private int valasz;

        public TippKerdes(string reqkerdes, int id, int reqvalasz)
        {
            kerdes = reqkerdes;
            kerdesID = id;
            valasz = reqvalasz;
        }
        public int getID()
        {
            return this.kerdesID;
        }
        public int getValasz()
        {
            return this.valasz;
        }

        public string getKerdes()
        {
            return this.kerdes;
        }
    }
}
