using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikCamasirMakinesi
{

    internal class Mamdani
    {

        public Dictionary<string,Dictionary<string,double>> start(List<DataGridViewRow> dataGridViews,double[] deger)
        {
            Dictionary<string, Dictionary<string, double>> aralik_deger = new Dictionary<string, Dictionary<string, double>>()
            {
                { "Dönüş Hızı", new Dictionary<string, double>() },
                { "Süre", new Dictionary<string, double>() },
                { "Deterjan", new Dictionary<string, double>() }
            };

            foreach (DataGridViewRow item1 in dataGridViews)
            {
                string hassasKey = item1.Cells[1].Value.ToString();
                string miktarKey = item1.Cells[2].Value.ToString();
                string kirlilikKey = item1.Cells[3].Value.ToString();
                string donusHiziKey = item1.Cells[4].Value.ToString();
                string sureKey = item1.Cells[5].Value.ToString();
                string deterjanKey = item1.Cells[6].Value.ToString();



                double mamdani_hassas = MamdaniHassaslikHesaplama(hassasKey, deger[0]);
                double mamdani_miktar = MamdaniMiktarHesaplama(miktarKey, deger[1]);
                double mamdani_kirlilik = MamdaniKirlilikHesaplama(kirlilikKey, deger[2]);

                double min_man = Math.Min(mamdani_hassas, Math.Min(mamdani_miktar,mamdani_kirlilik));

                if (aralik_deger["Dönüş Hızı"].TryGetValue(donusHiziKey, out double hassasDeger))
                {
                    aralik_deger["Dönüş Hızı"][donusHiziKey] = Math.Max(min_man, hassasDeger);
                }
                else
                {
                    aralik_deger["Dönüş Hızı"].Add(donusHiziKey, min_man);
                }

                if (aralik_deger["Süre"].TryGetValue(sureKey, out double sureDeger))
                {
                    aralik_deger["Süre"][sureKey] = Math.Max(min_man, sureDeger);
                }
                else
                {
                    aralik_deger["Süre"].Add(sureKey, min_man);
                }

                if (aralik_deger["Deterjan"].TryGetValue(deterjanKey, out double kirlilikDeger))
                {
                    aralik_deger["Deterjan"][deterjanKey] = Math.Max(kirlilikDeger, min_man);
                }
                else
                {
                    aralik_deger["Deterjan"].Add(deterjanKey, min_man);
                }
            }

            return aralik_deger;
        }


        public double MamdaniHassaslikHesaplama(string uyelikTipi,double hassaslik)
        {
            double mamHassaslik = 1;
            if (hassaslik < 2 && uyelikTipi == "sağlam")
            {
                mamHassaslik = 1;
            }
            if (hassaslik >= 2 && hassaslik <= 4 && uyelikTipi == "sağlam")
            {
                mamHassaslik = (4 - hassaslik) / 2;
            }
            else if (hassaslik >= 3 && hassaslik <= 5 && uyelikTipi == "orta")
            {
                mamHassaslik = (hassaslik - 3) / 2;
            }
            else if (hassaslik >= 5 && hassaslik <= 7 && uyelikTipi == "orta")
            {
                mamHassaslik = (7 - hassaslik) / 2;
            }
            else if (hassaslik >= 5.5 && hassaslik <= 8 && uyelikTipi == "hassas")
            {
                mamHassaslik = (hassaslik - 5.5) / 2.5;
            }
            else
            {
                mamHassaslik = 1;
            }
            return mamHassaslik;
        }
        public double MamdaniMiktarHesaplama(string uyelikTipi,double miktar)
        {
            double mamMiktar = 1;
            if (miktar < 2 && uyelikTipi == "küçük")
            {
                mamMiktar = 1;
            }
            else if (miktar >= 2 && miktar <= 4 && uyelikTipi == "küçük")
            {
                mamMiktar = (4 - miktar) / 2;
            }
            else if (miktar >= 3 && miktar <= 5 && uyelikTipi == "orta")
            {
                mamMiktar = (miktar - 3) / 2;
            }
            else if (miktar >= 5 && miktar <= 7 && uyelikTipi == "orta")
            {
                mamMiktar = (7 - miktar) / 2;
            }
            else if (miktar >= 5.5 && miktar <= 8 && uyelikTipi == "büyük")
            {
                mamMiktar = (miktar - 5.5) / 2.5;
            }
            else
            {
                mamMiktar = 1;
            }
            return mamMiktar;
        }

        public double MamdaniKirlilikHesaplama(string uyelikTipi, double kirlilik)
        {
            double mamKirlilik = 1;
            if (kirlilik < 2 && uyelikTipi == "küçük")
            {
                mamKirlilik = 1;
            }
            else if (kirlilik >= 2 && kirlilik <= 4.5 && uyelikTipi == "küçük")
            {
                mamKirlilik = (4.5 - kirlilik) / 2.5;
            }
            else if (kirlilik >= 3 && kirlilik <= 5 && uyelikTipi == "orta")
            {
                mamKirlilik = (kirlilik - 3) / 2;
            }
            else if (kirlilik >= 5 && kirlilik <= 7 && uyelikTipi == "orta")
            {
                mamKirlilik = (7 - kirlilik) / 2;
            }
            else if (kirlilik >= 5.5 && kirlilik <= 8 && uyelikTipi == "büyük")
            {
                mamKirlilik = (kirlilik - 5.5) / 2.5;
            }
            else
            {
                mamKirlilik = 1;
            }
            return mamKirlilik;
        }

    }
}
