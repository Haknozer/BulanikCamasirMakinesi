using System;
using System.Collections.Generic;

namespace BulanikCamasirMakinesi
{
    public class Centroid
    {
        public double HesaplaCentroid(Dictionary<string, (double start, double end)> araliklar,
            Dictionary<string, double> degerler, double stepSize = 0.01)
        {
            double pay = 0.0;
            double payda = 0.0;

            foreach (var item in degerler)
            {
                string etiket = item.Key;
                double yUst = item.Value;

                if (yUst <= 0)
                    continue;

                if (araliklar.ContainsKey(etiket))
                {
                    double x1 = araliklar[etiket].start;
                    double x2 = araliklar[etiket].end;
                    double orta = (x1 + x2) / 2.0;

                    for (double x = x1; x <= x2; x += stepSize)
                    {
                        double uyelikDegeri = Ucgen(x1, orta, x2, x);
                        uyelikDegeri = Math.Min(uyelikDegeri, yUst);

                        pay += x * uyelikDegeri * stepSize;
                        payda += uyelikDegeri * stepSize;
                    }
                }
            }

            if (Math.Abs(payda) < 1e-10) 
                return 0;

            return pay / payda;
        }

        private double Ucgen(double x1, double orta, double x2, double x)
        {
            if (x <= x1 || x >= x2)
                return 0;

            if (Math.Abs(x - orta) < 1e-10) 
                return 1;

            if (x < orta)
                return (x - x1) / (orta - x1);
            else
                return (x2 - x) / (x2 - orta);
        }
    }
}
