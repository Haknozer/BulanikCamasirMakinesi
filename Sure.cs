using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BulanikCamasirMakinesi
{
    internal class Sure : CikisGrafik
    {
        Dictionary<string, (double start, double end)> araliklar = new Dictionary<string, (double, double)>
        {
            { "kısa", (0, 40) },
            { "normal kısa", (20, 60) },
            { "orta", (40, 76) },
            { "normal uzun", (60, 90) },
            { "uzun", (75, 100) }
        };
        public event Action<double> CentroidHesaplandi;
        private Chart chart;
        public Sure(Panel panel, int left, int top, string name, Dictionary<string, double> value, string[] aralik) : base(panel, left, top, name, value, aralik)
        {
            CizGrafik();
        }

        private void CizGrafik()
        {
            chart = new Chart
            {
                Width = 475,
                Height = 175,
                Left = left,
                Top = top,
                BackColor = Color.LightSteelBlue
            };


            ChartArea area = new ChartArea();
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 100;
            area.AxisX.Interval = 10;
            area.AxisX.ScaleView.Size = 110;
            area.AxisX.ScrollBar.Enabled = false;

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 1.3;
            area.AxisY.Interval = 1;


            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            area.BackColor = Color.LightSteelBlue;

            chart.ChartAreas.Add(area);

            Label labelHassaslik = new Label();
            labelHassaslik.Text = name;
            labelHassaslik.TextAlign = ContentAlignment.MiddleCenter;
            labelHassaslik.Font = new Font("Arial", 10, FontStyle.Bold);
            labelHassaslik.Size = new Size(30, 200);
            labelHassaslik.Location = new Point(panel.Width - 25, 0);
            labelHassaslik.BackColor = Color.Transparent;
            panel.Controls.Add(labelHassaslik);


            Color[] renkler = { Color.Blue, Color.Green, Color.Yellow, Color.Red, Color.Purple };

            for (int i = 0; i < 5; i++)
            {
                Series seri = new Series(aralik[i])
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2,
                    Color = renkler[i]
                };

                if (i == 0)
                {
                    seri.Points.AddXY(0, 1);
                    seri.Points.AddXY(25, 1);
                    seri.Points.AddXY(40, 0);

                    DataPoint p = new DataPoint(25, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 1)
                {
                    seri.Points.AddXY(20, 0);
                    seri.Points.AddXY(40, 1);
                    seri.Points.AddXY(60, 0);

                    DataPoint p = new DataPoint(40, 0.8);
                    p.MarkerStyle = MarkerStyle.None;
                    p.Color = Color.Transparent;
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 2)
                {
                    seri.Points.AddXY(40, 0);
                    seri.Points.AddXY(60, 1);
                    seri.Points.AddXY(75, 0);

                    DataPoint p = new DataPoint(60, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 3)
                {
                    seri.Points.AddXY(60, 0);   
                    seri.Points.AddXY(75, 1);
                    seri.Points.AddXY(90, 0);

                    DataPoint p = new DataPoint(75, 0.8);
                    p.MarkerStyle = MarkerStyle.None;
                    p.Color = Color.Transparent;
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 4)
                {
                    seri.Points.AddXY(75, 0);
                    seri.Points.AddXY(90, 1);
                    seri.Points.AddXY(100, 1);

                    DataPoint p = new DataPoint(90, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
            }
            chart.PostPaint += Chart_PostPaint;
            panel.Controls.Add(chart);
        }

        private void Chart_PostPaint(object sender, ChartPaintEventArgs e)
        {
            if (e.ChartElement is ChartArea)
            {
                ChartArea area = chart.ChartAreas[0];
                Graphics g = e.ChartGraphics.Graphics;

                foreach (var item in value)
                {
                    string aralikAdi = item.Key;
                    double val = item.Value;

                    if (araliklar.ContainsKey(aralikAdi))
                    {
                        double x1 = araliklar[aralikAdi].start;
                        double x2 = araliklar[aralikAdi].end;
                        YamukAlaniCiz(g, area, x1, x2, val, 0.0, Color.FromArgb(200, 255, 255, 0));
                    }
                }

                Centroid centroid = new Centroid();
                double centroidX = centroid.HesaplaCentroid(araliklar, value,10);

                CentroidHesaplandi?.Invoke(centroidX);
            }
        }
        private void YamukAlaniCiz(Graphics g, ChartArea area, double x1, double x2, double yUst, double yAlt, Color renk)
        {
            float pX1 = (float)area.AxisX.ValueToPixelPosition(x1);
            float pX2 = (float)area.AxisX.ValueToPixelPosition(x2);
            float pYAlt = (float)area.AxisY.ValueToPixelPosition(yAlt);
            float pYUst = (float)area.AxisY.ValueToPixelPosition(yUst);
            float xOrta1;
            float xOrta2;


            if (yUst == 1)
            {
                xOrta1 = (float)(pX1 + (pX2 - pX1) * 0.50);
                xOrta2 = (float)(pX2 - (pX2 - pX1) * 0.50);
            }
            else if (yUst >= .75)
            {
                xOrta1 = (float)(pX1 + (pX2 - pX1) * 0.40);
                xOrta2 = (float)(pX2 - (pX2 - pX1) * 0.40);
            }
            else if (yUst >= .50)
            {
                xOrta1 = (float)(pX1 + (pX2 - pX1) * 0.30);
                xOrta2 = (float)(pX2 - (pX2 - pX1) * 0.30);
            }
            else if (yUst >= 0.25)
            {
                xOrta1 = (float)(pX1 + (pX2 - pX1) * 0.20);
                xOrta2 = (float)(pX2 - (pX2 - pX1) * 0.20);
            }
            else
            {
                xOrta1 = (float)(pX1 + (pX2 - pX1) * 0.10);
                xOrta2 = (float)(pX2 - (pX2 - pX1) * 0.10);
            }


            if (x1 == 0)
            {
                xOrta1 = (float)pX1;
            }else if (x2 == 100)
            {
                xOrta2 = (float)pX2;
            }
                PointF[] yamuk = {
                new PointF(pX1, pYAlt),
                new PointF(pX2, pYAlt),
                new PointF(xOrta2, pYUst),
                new PointF(xOrta1, pYUst)
            };

            using (SolidBrush brush = new SolidBrush(renk))
            {
                g.FillPolygon(brush, yamuk);
            }
        }
    }
}
