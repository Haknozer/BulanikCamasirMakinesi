using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BulanikCamasirMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] values = new double[3];
        double hassaslýk_value = 0.0;
        double miktar_value = 0.0;
        double kirlilik_value = 0.0;
        GirisGrafik girisGrafikHasssas;
        GirisGrafik girisGrafikMiktar;
        GirisGrafik girisGrafikKirli;
        Dictionary<string, Dictionary<string, double>> mamdani_hesap;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            hassaslýk_value = Convert.ToDouble(hassaslýk_numericupdown.Value);
            miktar_value = Convert.ToDouble(miktar_numericupdown.Value);
            kirlilik_value = Convert.ToDouble(kirlilik_numericupdown.Value);

            girisGrafikOlustur();
            
            tablo_olustur();

            values[0] = hassaslýk_value;
            values[1] = miktar_value;
            values[2] = kirlilik_value;


            mamdani_hesap = mamdaniHesapla(aralikBul());
            CikisOlustur(mamdani_hesap);

            ScrollBarEvent();
        }

        private void listbox_yaz()
        {
            mamdani_lstbox.Items.Clear();
            foreach (var item in mamdani_hesap)
            {
                foreach (var item1 in item.Value)
                {
                    string cikis = $"{item.Key}: {item1.Key} - {item1.Value}";
                    mamdani_lstbox.Items.Add(cikis);
                }
            }
        }

        private void ScrollBarEvent()
        {
            girisGrafikHasssas.ScrollbarValueChanged += (newValue) =>
            {
                hassaslýk_numericupdown.Value = (decimal)newValue;
                values[0] = newValue;
            };

            girisGrafikMiktar.ScrollbarValueChanged += (newValue) =>
            {
                miktar_numericupdown.Value = (decimal)newValue;
                values[1] = newValue;

            };

            girisGrafikKirli.ScrollbarValueChanged += (newValue) =>
            {
                kirlilik_numericupdown.Value = (decimal)newValue;
                values[2] = newValue;

            };
        }

        private void CikisOlustur(Dictionary<string, Dictionary<string, double>> aralik_deger)
        {
            AgirlikOrtalama agirlikOrtalama = new AgirlikOrtalama();
            DonusHizi donusHizi = new DonusHizi(donus_hizi_panel, 10, 20, "D\nÖ\nN\nÜ\nÞ\n \nH\nI\nZ\nI", aralik_deger["Dönüþ Hýzý"], ["HASSAS", "Normal-Hassas", "ORTA", "Normal-Güçlü", "GÜÇLÜ"]);
            double agirlikOrtalamaDonusHizi = agirlikOrtalama.HesaplaAðýrlýklýOrtalama("Dönüþ Hýzý", aralik_deger["Dönüþ Hýzý"]);
            donushizi_agýrlýkort.Text = agirlikOrtalamaDonusHizi.ToString("F7");
            donusHizi.CentroidHesaplandi += (centroidX) => CentroidHesaplandi(centroidX, "Dönüþ Hýzý");


            Deterjan deterjan = new Deterjan(deterjan_panel, 10, 20, "D\nE\nT\nE\nR\nJ\nA\nN", aralik_deger["Deterjan"], ["ÇOK AZ", "AZ", "ORTA", "FAZLA", "ÇOK FAZLA"]);
            double deterjanAgirlikOrtalama = agirlikOrtalama.HesaplaAðýrlýklýOrtalama("Deterjan", aralik_deger["Deterjan"]);
            deterjanAgirlik.Text = deterjanAgirlikOrtalama.ToString("F7");
            deterjan.CentroidHesaplandi += (centroidX) => CentroidHesaplandi(centroidX, "Deterjan");

            Sure sure = new Sure(sure_panel, 10, 20, "S\nÜ\nR\nE", aralik_deger["Süre"], ["KISA", "Normal-Kýsa", "ORTA", "Normal-Uzun", "UZUN"]);
            double sureAgirlikOrtalama = agirlikOrtalama.HesaplaAðýrlýklýOrtalama("Süre", aralik_deger["Süre"]);
            sure_agirlik.Text = sureAgirlikOrtalama.ToString("F7");
            sure.CentroidHesaplandi += (centroidX) => CentroidHesaplandi(centroidX, "Süre");

            listbox_yaz();
        }

        private Dictionary<string, Dictionary<string, double>> mamdaniHesapla(List<DataGridViewRow> tablo)
        {
            Mamdani mamdani = new Mamdani();
            Dictionary<string, Dictionary<string, double>> aralik_deger = mamdani.start(tablo, values);

            return aralik_deger;
        }

        private List<DataGridViewRow> aralikBul()
        {
            araliklar ara = new araliklar();
            List<int> secim = ara.start(values);

            List<DataGridViewRow> tablo = tabloSatirSec(secim);

            return tablo;
        }

        private void girisGrafikOlustur()
        {
            girisGrafikHasssas = new GirisGrafik(hassaslik_panel, hassaslýk_value, 10, 20, "H\nA\nS\nS\nA\nS\nL\nI\nK", ["SAÐLAM", "ORTA", "HASSAS"]);
            girisGrafikMiktar = new GirisGrafik(miktar_panel, miktar_value, 10, 20, "M\nÝ\nK\nT\nA\nR", ["KÜÇÜK", "ORTA", "BÜYÜK"]);
            girisGrafikKirli = new GirisGrafik(kirlilik_panel, kirlilik_value, 10, 20, "K\nÝ\nR\nL\nÝ\nL\ni\nK", ["KÜÇÜK", "ORTA", "BÜYÜK"]);
        }

        private void CentroidHesaplandi(double centroidX, string cikis)
        {
            switch (cikis)
            {
                case "Dönüþ Hýzý": donushizi_centroid.Text = centroidX.ToString("F7"); break;
                case "Deterjan": deterjan_centroid.Text = centroidX.ToString("F7"); break;
                case "Süre": sure_centroid.Text = centroidX.ToString("F7"); break;
            }
        }

        private List<DataGridViewRow> tabloSatirSec(List<int> secim)
        {
            List<DataGridViewRow> tablo = new List<DataGridViewRow>();
            dataGridView1.ClearSelection();
            foreach (var item in secim)
            {
                dataGridView1.Rows[item - 1].Selected = true;
                tablo.Add(dataGridView1.Rows[item - 1]);
            }

            return tablo;
        }

        private void tablo_olustur()
        {
            string[][] data = new string[][]
            {
            new string[] { "1", "hassas", "küçük", "küçük", "hassas", "kýsa", "çok az" },
            new string[] { "2", "hassas", "küçük", "orta", "normal hassas", "kýsa", "az" },
            new string[] { "3", "hassas", "küçük", "büyük", "orta", "normal kýsa", "orta" },
            new string[] { "4", "hassas", "orta", "küçük", "hassas", "kýsa", "orta" },
            new string[] { "5", "hassas", "orta", "orta", "normal hassas", "normal kýsa", "orta" },
            new string[] { "6", "hassas", "orta", "büyük", "orta", "orta", "fazla" },
            new string[] { "7", "hassas", "büyük", "küçük", "normal hassas", "normal kýsa", "orta" },
            new string[] { "8", "hassas", "büyük", "orta", "normal hassas", "orta", "fazla" },
            new string[] { "9", "hassas", "büyük", "büyük", "orta", "normal uzun", "fazla" },
            new string[] { "10", "orta", "küçük", "küçük", "normal hassas", "normal kýsa", "az" },
            new string[] { "11", "orta", "küçük", "orta", "orta", "kýsa", "orta" },
            new string[] { "12", "orta", "küçük", "büyük", "normal güçlü", "orta", "fazla" },
            new string[] { "13", "orta", "orta", "küçük", "normal hassas", "normal kýsa", "orta" },
            new string[] { "14", "orta", "orta", "orta", "orta", "orta", "orta" },
            new string[] { "15", "orta", "orta", "büyük", "hassas", "uzun", "fazla" },
            new string[] { "16", "orta", "büyük", "küçük", "hassas", "orta", "orta" },
            new string[] { "17", "orta", "büyük", "orta", "hassas", "normal uzun", "fazla" },
            new string[] { "18", "orta", "büyük", "büyük", "hassas", "uzun", "çok fazla" },
            new string[] { "19", "saðlam", "küçük", "küçük", "orta", "orta", "az" },
            new string[] { "20", "saðlam", "küçük", "orta", "normal güçlü", "orta", "orta" },
            new string[] { "21", "saðlam", "küçük", "büyük", "güçlü", "normal uzun", "fazla" },
            new string[] { "22", "saðlam", "orta", "küçük", "orta", "orta", "orta" },
            new string[] { "23", "saðlam", "orta", "orta", "normal güçlü", "normal uzun", "orta" },
            new string[] { "24", "saðlam", "orta", "büyük", "güçlü", "orta", "çok fazla" },
            new string[] { "25", "saðlam", "büyük", "küçük", "normal güçlü", "normal uzun", "fazla" },
            new string[] { "26", "saðlam", "büyük", "orta", "normal güçlü", "uzun", "fazla" },
            new string[] { "27", "saðlam", "büyük", "büyük", "güçlü", "uzun", "çok fazla" }
            };

            foreach (var row in data)
            {
                dataGridView1.Rows.Add(row);
            }
        }



        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hassaslýk_numericupdown_ValueChanged(object sender, EventArgs e)
        {
            double newVal = Convert.ToDouble(hassaslýk_numericupdown.Value);
            values[0] = newVal;
            if (girisGrafikHasssas != null)
                girisGrafikHasssas.YeniDeger(newVal);


            chartlarýSil();
            mamdani_hesap = mamdaniHesapla(aralikBul());
            CikisOlustur(mamdani_hesap);
        }

        private void chartlarýSil()
        {
            var charts_donus = donus_hizi_panel.Controls.OfType<Chart>().ToList();
            foreach (var ch in charts_donus)
            {
                donus_hizi_panel.Controls.Remove(ch);
                ch.Dispose();
            }
            var charts_deterjan = deterjan_panel.Controls.OfType<Chart>().ToList();
            foreach (var ch in charts_deterjan)
            {
                donus_hizi_panel.Controls.Remove(ch);
                ch.Dispose();
            }
            var charts_sure = sure_panel.Controls.OfType<Chart>().ToList();
            foreach (var ch in charts_sure)
            {
                donus_hizi_panel.Controls.Remove(ch);
                ch.Dispose();
            }
        }

        private void miktar_numericupdown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kirlilik_numericupdown_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void miktar_numericupdown_ValueChanged_1(object sender, EventArgs e)
        {
            double newVal = Convert.ToDouble(miktar_numericupdown.Value);
            values[1] = newVal;
            if (girisGrafikMiktar != null)
                girisGrafikMiktar.YeniDeger(newVal);
            chartlarýSil();
            mamdani_hesap = mamdaniHesapla(aralikBul());
            CikisOlustur(mamdani_hesap);
        }

        private void kirlilik_numericupdown_ValueChanged_1(object sender, EventArgs e)
        {
            double newVal = Convert.ToDouble(kirlilik_numericupdown.Value);
            values[2] = newVal;
            if (girisGrafikKirli != null)
                girisGrafikKirli.YeniDeger(newVal);
            chartlarýSil();
            mamdani_hesap = mamdaniHesapla(aralikBul());
            CikisOlustur(mamdani_hesap);
        }
    }
}
