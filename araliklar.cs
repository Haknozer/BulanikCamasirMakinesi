using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikCamasirMakinesi
{
    public class araliklar
    {
        string[][] data = new string[][]
        {
            new string[] { "1", "hassas", "küçük", "küçük", "hassas", "kısa", "çok az" },
            new string[] { "2", "hassas", "küçük", "orta", "normal hassas", "kısa", "az" },
            new string[] { "3", "hassas", "küçük", "büyük", "orta", "normal kısa", "orta" },
            new string[] { "4", "hassas", "orta", "küçük", "hassas", "kısa", "orta" },
            new string[] { "5", "hassas", "orta", "orta", "normal hassas", "normal kısa", "orta" },
            new string[] { "6", "hassas", "orta", "büyük", "orta", "orta", "fazla" },
            new string[] { "7", "hassas", "büyük", "küçük", "normal hassas", "normal kısa", "orta" },
            new string[] { "8", "hassas", "büyük", "orta", "normal hassas", "orta", "fazla" },
            new string[] { "9", "hassas", "büyük", "büyük", "orta", "normal uzun", "fazla" },
            new string[] { "10", "orta", "küçük", "küçük", "normal hassas", "normal kısa", "az" },
            new string[] { "11", "orta", "küçük", "orta", "orta", "kısa", "orta" },
            new string[] { "12", "orta", "küçük", "büyük", "normal güçlü", "orta", "fazla" },
            new string[] { "13", "orta", "orta", "küçük", "normal hassas", "normal kısa", "orta" },
            new string[] { "14", "orta", "orta", "orta", "orta", "orta", "orta" },
            new string[] { "15", "orta", "orta", "büyük", "hassas", "uzun", "fazla" },
            new string[] { "16", "orta", "büyük", "küçük", "hassas", "orta", "orta" },
            new string[] { "17", "orta", "büyük", "orta", "hassas", "normal uzun", "fazla" },
            new string[] { "18", "orta", "büyük", "büyük", "hassas", "uzun", "çok fazla" },
            new string[] { "19", "sağlam", "küçük", "küçük", "orta", "orta", "az" },
            new string[] { "20", "sağlam", "küçük", "orta", "normal güçlü", "orta", "orta" },
            new string[] { "21", "sağlam", "küçük", "büyük", "güçlü", "normal uzun", "fazla" },
            new string[] { "22", "sağlam", "orta", "küçük", "orta", "orta", "orta" },
            new string[] { "23", "sağlam", "orta", "orta", "normal güçlü", "normal uzun", "orta" },
            new string[] { "24", "sağlam", "orta", "büyük", "güçlü", "orta", "çok fazla" },
            new string[] { "25", "sağlam", "büyük", "küçük", "normal güçlü", "normal uzun", "fazla" },
            new string[] { "26", "sağlam", "büyük", "orta", "normal güçlü", "uzun", "fazla" },
            new string[] { "27", "sağlam", "büyük", "büyük", "güçlü", "uzun", "çok fazla" }
        };
        private double[] values = [0.0,0.0,0.0];
        List<List<string>> aralik = new List<List<string>>();

        public List<int> start(double[] values)
        {
            aralik.Add(aralıkBul(values[0], "sağlam", "orta", "hassas"));
            aralik.Add(aralıkBul(values[1]));
            aralik.Add(aralıkBulKirlilik(values[2]));
            var birlesim = birlestir();
            return cikisaraliklaribul(birlesim);
        }

        List<List<string>> birlestir()
        {
            List<List<string>> birlestirme = new List<List<string>>();

            foreach (var item in aralik[0])
            {
                foreach (var item1 in aralik[1])
                {
                    foreach (var item2 in aralik[2])
                    {
                        birlestirme.Add([item, item1, item2]);
                    }
                }
            }
            return birlestirme;
        }


        List<int> cikisaraliklaribul(List<List<string>> birlesim)
        {
            List<int> aralik = new List<int>();
            foreach (var item in birlesim)
            {
                int i = 0;
                if (item[0] == "orta")
                {
                    i = 9;
                } else if (item[0] == "sağlam")
                {
                    i = 18;
                }

                for (; i < 27; i++)
                {
                    if (data[i][1] == item[0] && data[i][2] == item[1] && data[i][3] == item[2])
                    {
                        aralik.Add(i + 1);
                        break;
                    }
                    else if (data[i][1] != item[0]) break;
                }
            }
        
            return aralik;
        }




        List<string> aralıkBul(double val, string k = "küçük", string o = "orta", string b = "büyük")
        {
            List<string> text = [];

            if (val < 3)
            {
                text.Add(k);
            }
            else if (val >= 3 && val < 4)
            {
                text.Add(k);
                text.Add(o);
            }
            else if (val >= 4 && val < 5.5)
            {
                text.Add(o);
            }
            else if (val >= 5.5 && val < 7)
            {
                text.Add(o);
                text.Add(b);
            }
            else if (val >= 7)
            {
                text.Add(b);
            }

            return text;

        }

        List<string> aralıkBulKirlilik(double val, string k = "küçük", string o = "orta", string b = "büyük")
        {
            List<string> text = [];

            if (val < 3)
            {
                text.Add(k);
            }
            else if (val >= 3 && val < 4.50)
            {
                text.Add(k);
                text.Add(o);
            }
            else if (val >= 4.5 && val < 5.5)
            {
                text.Add(o);
            }
            else if (val >= 5.5 && val < 7)
            {
                text.Add(o);
                text.Add(b);
            }
            else if (val >= 7)
            {
                text.Add(b);
            }

            return text;

        }
    }
}
