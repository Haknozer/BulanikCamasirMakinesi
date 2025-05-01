using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikCamasirMakinesi
{
    internal class CikisGrafik
    {
        protected Panel panel;
        protected int left;
        protected int top;
        protected string name;
        protected Dictionary<string,double> value;
        protected string[] aralik;

        public CikisGrafik(Panel panel, int left, int top, string name, Dictionary<string, double> value, string[] aralik)
        {
            this.panel = panel;
            this.left = left;
            this.top = top;
            this.name = name;
            this.value = value;
            this.aralik = aralik;
        }
    }
}
