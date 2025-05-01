using System;
using System.Collections.Generic;

namespace BulanikCamasirMakinesi
{
    internal class AgirlikOrtalama
    {
        public double HesaplaAğırlıklıOrtalama(string tur, Dictionary<string, double> degerler)
        {

            Dictionary<string,(double start,double end)> araliklar = turGetir(tur);
            double moment = 0;
            double toplamUyelik = 0;

            foreach (var item in degerler)
            {
                string etiket = item.Key;
                double uyelik = item.Value;

                if (araliklar.ContainsKey(etiket))
                {
                    double x1 = araliklar[etiket].start;
                    double x2 = araliklar[etiket].end;
                    double merkez = (x1 + x2) / 2.0;

                    moment += uyelik * merkez;
                    toplamUyelik += uyelik;
                }
            }

            if (toplamUyelik == 0)
                return 0;

            return moment / toplamUyelik;
        }

        private Dictionary<string, (double, double)> turGetir(string tur)
        {

            switch (tur) {
                case "Dönüş Hızı": return DonusHiziAraliklari;
                    break;
                case "Deterjan": return DeterjanAraliklari;
                    break;
                case "Süre":  return SureAraliklari;
                    break;
                default: return DonusHiziAraliklari;
                    break;
            }
        }

        public Dictionary<string, (double, double)> DonusHiziAraliklari = new()
        {
            { "hassas", (0, 1.5) },
            { "normal hassas", (0.5, 5) },
            { "orta", (2.75, 7.25) },
            { "normal güçlü", (5, 9.5) },
            { "güçlü", (8.5, 10) }
        };

        public Dictionary<string, (double, double)> DeterjanAraliklari = new()
        {
            { "çok az", (0, 85) },
            { "az", (20, 150) },
            { "orta", (85, 215) },
            { "fazla", (150, 280) },
            { "çok fazla", (215, 300) }
        };

        public Dictionary<string, (double, double)> SureAraliklari = new()
        {
            { "kısa", (0, 40) },
            { "normal kısa", (20, 60) },
            { "orta", (40, 76) },
            { "normal uzun", (60, 90) },
            { "uzun", (75, 100) }
        };
    }
}
