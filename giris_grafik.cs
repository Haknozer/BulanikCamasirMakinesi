using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BulanikCamasirMakinesi
{
    internal class GirisGrafik
    {
        private Panel panel;
        private int left;
        private int top;
        private string name;
        private double value;
        private TrackBar trackBar;
        private Series secimSerisi;
        Chart chart;
        public event Action<double> ScrollbarValueChanged;
        public GirisGrafik(Panel panel,double value,int left,int top,string name, string[] isimler) {
            this.panel = panel;
            this.value = value;
            this.left = left;
            this.top = top;
            this.name = name;
            CizGrafik(isimler);
        }

        private void CizGrafik(string[] isimler) {
            chart = new Chart {
                Width = 450,
                Height = 175,
                Left = left,
                Top = top,
                BackColor = Color.Beige
            };


            ChartArea area = new ChartArea();
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 10;
            area.AxisX.Interval = 1;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 1.3;
            area.AxisY.Interval = 1;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            area.BackColor = Color.Beige;
            
            chart.ChartAreas.Add(area);

            Label labelHassaslik = new Label();
            labelHassaslik.Text = name;
            labelHassaslik.TextAlign = ContentAlignment.MiddleCenter;
            labelHassaslik.Font = new Font("Arial", 10, FontStyle.Bold);
            labelHassaslik.Size = new Size(30, 200);
            labelHassaslik.Location = new Point(0, 0);
            labelHassaslik.BackColor = Color.Transparent;
            panel.Controls.Add(labelHassaslik);


            Color[] renkler = { Color.Blue, Color.Green, Color.DeepPink };


            for (int i = 0; i < 3; i++)
            {
                Series seri = new Series(isimler[i])
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2,
                    Color = renkler[i]
                };

                if (i == 0)
                {
                    seri.Points.AddXY(0, 1);
                    seri.Points.AddXY(2, 1);
                    if (name == "K\nİ\nR\nL\nİ\nL\ni\nK")
                    {
                        seri.Points.AddXY(4.5, 0);
                    }else seri.Points.AddXY(4, 0);
                     
                    DataPoint p = new DataPoint(2, 1);
                    p.Label = isimler[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
                else if(i == 1)
                {
                    seri.Points.AddXY(3, 0);
                    seri.Points.AddXY(5, 1);
                    seri.Points.AddXY(7, 0);

                    DataPoint p = new DataPoint(5, 1);
                    p.Label = isimler[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                } else if (i == 2)
                {
                    seri.Points.AddXY(5.5, 0);
                    seri.Points.AddXY(8, 1);
                    seri.Points.AddXY(10, 1);

                    DataPoint p = new DataPoint(8, 1);
                    p.Label = isimler[i];
                    seri.Font = new Font("Arial", 10, FontStyle.Bold);
                    seri.Points.Add(p);

                    chart.Series.Add(seri);
                }
            }

            secimSerisi = new Series("Secim")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };
            secimSerisi.Points.AddXY(value, 0);
            secimSerisi.Points.AddXY(value, 1.1);
            chart.Series.Add(secimSerisi);

            panel.Controls.Add(chart);

            trackBar = new TrackBar
            {
                Minimum = 0,
                Maximum = 100,
                TickFrequency = 10,
                Width = 410,
                Left = 35,
                Top = 0,
            };
            trackBar.Value = (int)(value * 10);
            trackBar.Scroll += TrackBar_Scroll;
            panel.Controls.Add(trackBar);

        }
        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            double secilenX = trackBar.Value / 10.0;
            secimSerisi.Points[0].XValue = secilenX;
            secimSerisi.Points[1].XValue = secilenX;
            ScrollbarValueChanged?.Invoke(secilenX);

        }

        public void YeniDeger(double value)
        {
            trackBar.Value = (int)(value * 10);
            UpdateSecimSerisi(value);
        }

        private void UpdateSecimSerisi(double value)
        {
            Series secimSerisi = chart.Series.FindByName("Secim");

            if (secimSerisi != null)
            {
                secimSerisi.Points.Clear();  

                secimSerisi.Points.AddXY(value, 0);
                secimSerisi.Points.AddXY(value, 1.1);
            }
            else
            {
                secimSerisi = new Series("Secim")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Red,
                    BorderWidth = 2
                };
                secimSerisi.Points.AddXY(value, 0);
                secimSerisi.Points.AddXY(value, 1.1);
                chart.Series.Add(secimSerisi);
            }
        }
    }

}
