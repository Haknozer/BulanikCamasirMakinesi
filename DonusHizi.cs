using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BulanikCamasirMakinesi
{
    internal class DonusHizi : CikisGrafik
    {
        Dictionary<string, (double start, double end)> araliklar = new Dictionary<string, (double, double)>
        {
            { "hassas", (0, 1.5) },
            { "normal hassas", (0.5, 5) },
            { "orta", (2.75, 7.25) },
            { "normal güçlü", (5, 9.5) },
            { "güçlü", (8.5, 10) }
        };
        public event Action<double> CentroidHesaplandi;
        private Chart chart;
        public DonusHizi(Panel panel, int left, int top, string name, Dictionary<string, double> value, string[] aralik) : base(panel, left, top, name, value, aralik)
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
            area.AxisX.Maximum = 12;
            area.AxisX.Interval = 1;
            area.AxisX.ScaleView.Size = 10;
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
            labelHassaslik.Font = new Font("Arial", 9, FontStyle.Bold);
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
                    seri.Points.AddXY(0.5, 1);
                    seri.Points.AddXY(1.5, 0);

                    DataPoint p = new DataPoint(0.5, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 1)
                {
                    seri.Points.AddXY(0.5, 0);
                    seri.Points.AddXY(2.75, 1);
                    seri.Points.AddXY(5, 0);

                    DataPoint p = new DataPoint(2.75, 0.8);
                    p.MarkerStyle = MarkerStyle.None;
                    p.Color = Color.Transparent;
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 2)
                {
                    seri.Points.AddXY(2.75, 0);
                    seri.Points.AddXY(5, 1);
                    seri.Points.AddXY(7.25, 0);

                    DataPoint p = new DataPoint(5, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 3)
                {
                    seri.Points.AddXY(5, 0);
                    seri.Points.AddXY(7.25, 1);
                    seri.Points.AddXY(9.5, 0);

                    DataPoint p = new DataPoint(7.25, 0.8);
                    p.MarkerStyle = MarkerStyle.None;
                    p.Color = Color.Transparent;
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if (i == 4)
                {
                    seri.Points.AddXY(8.5, 0);
                    seri.Points.AddXY(9.5, 1);
                    seri.Points.AddXY(10, 1);

                    DataPoint p = new DataPoint(9.5, 1);
                    p.Label = aralik[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
            }
            chart.PostPaint += Chart_PostPaint;
            chart.Invalidate();
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
                        YamukAlaniCiz(g, area, x1, x2, val, 0.0, Color.FromArgb(160, 255, 255, 0));
                    }
                }
                Centroid centroid = new Centroid();
                double centroidX = centroid.HesaplaCentroid(araliklar, value,0.10);

                CentroidHesaplandi?.Invoke(centroidX);
            }
        }


        private void YamukAlaniCiz(Graphics g, ChartArea area, double x1, double x2, double yUst, double yAlt, Color renk)
        {
            double pX1 = area.AxisX.ValueToPixelPosition(x1);
            double pX2 = area.AxisX.ValueToPixelPosition(x2);
            double pYAlt = area.AxisY.ValueToPixelPosition(yAlt);
            double pYUst = area.AxisY.ValueToPixelPosition(yUst);
            double xOrta1;
            double xOrta2;


            if (yUst == 1)
            {
                xOrta1 =  (pX1 + (pX2 - pX1) * 0.50);
                xOrta2 =  (pX2 - (pX2 - pX1) * 0.50);
            }
            else if (yUst >= .75)
            {
                xOrta1 = (pX1 + (pX2 - pX1) * 0.40);
                xOrta2 = (pX2 - (pX2 - pX1) * 0.40);
            }
            else if (yUst >= .50)
            {
                xOrta1 = (pX1 + (pX2 - pX1) * 0.30);
                xOrta2 = (pX2 - (pX2 - pX1) * 0.30);
            }
            else if (yUst >= 0.25)
            {
                xOrta1 = (pX1 + (pX2 - pX1) * 0.20);
                xOrta2 = (pX2 - (pX2 - pX1) * 0.20);
            }else
            {
                xOrta1 = (pX1 + (pX2 - pX1) * 0.10);
                xOrta2 = (pX2 - (pX2 - pX1) * 0.10);
            }

            if (x1 == 0)
            {
                xOrta1 = pX1;
            }
            else if (x2 == 10)
            {
                xOrta2 = pX2;
            }

            double realXOrta1 = area.AxisX.PixelPositionToValue((float)xOrta1);
            double realXOrta2 = area.AxisX.PixelPositionToValue((float)xOrta2);
            PointF[] yamuk = {
                new PointF((float)pX1, (float)pYAlt),
                new PointF((float)pX2, (float)pYAlt),
                new PointF((float)xOrta2, (float)pYUst),
                new PointF((float)xOrta1, (float)pYUst)
            };


            using (SolidBrush brush = new SolidBrush(renk))
            {
                g.FillPolygon(brush, yamuk);
            }
        }
    }
}