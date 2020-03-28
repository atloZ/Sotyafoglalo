using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotyafoglalo.Backend
{
    public class Kerdes
    {
        private string kerdes;
        private string joValasz;
        private string rosszValasz1;
        private string rosszValasz2;
        private string rosszValasz3;
        private int kerdesID;

        public Kerdes(string kerdes, string jovalasz, string rossz1, string rossz2, string rossz3, int id)
        {
            this.kerdes = kerdes;
            this.joValasz = jovalasz;
            this.rosszValasz1 = rossz1;
            this.rosszValasz2 = rossz2;
            this.rosszValasz3 = rossz3;
            this.kerdesID = id;
        }

        public string getKerdes()
        {
            return this.kerdes;
        }

        public string getJoValasz()
        {
            return this.joValasz;
        }

        public string getRossz1()
        {
            return this.rosszValasz1;
        }

        public string getRossz2()
        {
            return this.rosszValasz2;
        }

        public string getRossz3()
        {
            return this.rosszValasz3;
        }

        public int getID()
        {
            return this.kerdesID;
        }

    }
}
