namespace BulanikCamasirMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            kirlilik_numericupdown = new NumericUpDown();
            miktar_numericupdown = new NumericUpDown();
            hassaslık_numericupdown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hassaslik_panel = new Panel();
            miktar_panel = new Panel();
            kirlilik_panel = new Panel();
            dataGridView1 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            donus_hizi_panel = new Panel();
            donushizi_agırlıkort = new Label();
            label5 = new Label();
            donushizi_centroid = new Label();
            label4 = new Label();
            sure_panel = new Panel();
            sure_agirlik = new Label();
            label10 = new Label();
            sure_centroid = new Label();
            label9 = new Label();
            deterjan_panel = new Panel();
            deterjanAgirlik = new Label();
            label7 = new Label();
            deterjan_centroid = new Label();
            label6 = new Label();
            mamdani_lstbox = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kirlilik_numericupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miktar_numericupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hassaslık_numericupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            donus_hizi_panel.SuspendLayout();
            sure_panel.SuspendLayout();
            deterjan_panel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(kirlilik_numericupdown);
            groupBox1.Controls.Add(miktar_numericupdown);
            groupBox1.Controls.Add(hassaslık_numericupdown);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(15, 609);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Değerleri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mamdani_lstbox);
            groupBox2.Location = new Point(263, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 147);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mamdani";
            // 
            // kirlilik_numericupdown
            // 
            kirlilik_numericupdown.BorderStyle = BorderStyle.FixedSingle;
            kirlilik_numericupdown.DecimalPlaces = 2;
            kirlilik_numericupdown.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kirlilik_numericupdown.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            kirlilik_numericupdown.Location = new Point(103, 108);
            kirlilik_numericupdown.Name = "kirlilik_numericupdown";
            kirlilik_numericupdown.Size = new Size(153, 27);
            kirlilik_numericupdown.TabIndex = 5;
            kirlilik_numericupdown.Value = new decimal(new int[] { 390, 0, 0, 131072 });
            kirlilik_numericupdown.ValueChanged += kirlilik_numericupdown_ValueChanged_1;
            // 
            // miktar_numericupdown
            // 
            miktar_numericupdown.BorderStyle = BorderStyle.FixedSingle;
            miktar_numericupdown.DecimalPlaces = 2;
            miktar_numericupdown.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            miktar_numericupdown.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            miktar_numericupdown.Location = new Point(103, 77);
            miktar_numericupdown.Name = "miktar_numericupdown";
            miktar_numericupdown.Size = new Size(153, 27);
            miktar_numericupdown.TabIndex = 4;
            miktar_numericupdown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            miktar_numericupdown.ValueChanged += miktar_numericupdown_ValueChanged_1;
            // 
            // hassaslık_numericupdown
            // 
            hassaslık_numericupdown.BorderStyle = BorderStyle.FixedSingle;
            hassaslık_numericupdown.DecimalPlaces = 2;
            hassaslık_numericupdown.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            hassaslık_numericupdown.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            hassaslık_numericupdown.Location = new Point(103, 46);
            hassaslık_numericupdown.Name = "hassaslık_numericupdown";
            hassaslık_numericupdown.Size = new Size(153, 27);
            hassaslık_numericupdown.TabIndex = 3;
            hassaslık_numericupdown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            hassaslık_numericupdown.ValueChanged += hassaslık_numericupdown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Kirlilik = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Miktar = ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Hassaslık = ";
            // 
            // hassaslik_panel
            // 
            hassaslik_panel.BackColor = Color.Beige;
            hassaslik_panel.BorderStyle = BorderStyle.FixedSingle;
            hassaslik_panel.Location = new Point(15, 3);
            hassaslik_panel.Name = "hassaslik_panel";
            hassaslik_panel.Size = new Size(461, 196);
            hassaslik_panel.TabIndex = 1;
            // 
            // miktar_panel
            // 
            miktar_panel.BackColor = Color.Beige;
            miktar_panel.BorderStyle = BorderStyle.FixedSingle;
            miktar_panel.Location = new Point(15, 205);
            miktar_panel.Name = "miktar_panel";
            miktar_panel.Size = new Size(461, 196);
            miktar_panel.TabIndex = 2;
            // 
            // kirlilik_panel
            // 
            kirlilik_panel.BackColor = Color.Beige;
            kirlilik_panel.BorderStyle = BorderStyle.FixedSingle;
            kirlilik_panel.Location = new Point(15, 407);
            kirlilik_panel.Name = "kirlilik_panel";
            kirlilik_panel.Size = new Size(461, 196);
            kirlilik_panel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(531, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.Size = new Size(645, 586);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 92;
            // 
            // Column1
            // 
            Column1.HeaderText = "Hassaslık";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 91;
            // 
            // Column2
            // 
            Column2.HeaderText = "Miktar";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 92;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kirlilik";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 92;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dönüş Hızı";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 92;
            // 
            // Column5
            // 
            Column5.HeaderText = "Süre";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 91;
            // 
            // Column6
            // 
            Column6.HeaderText = "Deterjan";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 92;
            // 
            // donus_hizi_panel
            // 
            donus_hizi_panel.BackColor = Color.LightSteelBlue;
            donus_hizi_panel.BorderStyle = BorderStyle.FixedSingle;
            donus_hizi_panel.Controls.Add(donushizi_agırlıkort);
            donus_hizi_panel.Controls.Add(label5);
            donus_hizi_panel.Controls.Add(donushizi_centroid);
            donus_hizi_panel.Controls.Add(label4);
            donus_hizi_panel.Location = new Point(603, 595);
            donus_hizi_panel.Name = "donus_hizi_panel";
            donus_hizi_panel.Size = new Size(573, 188);
            donus_hizi_panel.TabIndex = 4;
            // 
            // donushizi_agırlıkort
            // 
            donushizi_agırlıkort.AutoSize = true;
            donushizi_agırlıkort.BackColor = Color.DeepSkyBlue;
            donushizi_agırlıkort.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            donushizi_agırlıkort.Location = new Point(451, 0);
            donushizi_agırlıkort.Name = "donushizi_agırlıkort";
            donushizi_agırlıkort.Size = new Size(0, 23);
            donushizi_agırlıkort.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(298, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 2;
            label5.Text = "Ağırlıklı Ort :";
            // 
            // donushizi_centroid
            // 
            donushizi_centroid.AutoSize = true;
            donushizi_centroid.BackColor = Color.DeepSkyBlue;
            donushizi_centroid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            donushizi_centroid.Location = new Point(104, 0);
            donushizi_centroid.Name = "donushizi_centroid";
            donushizi_centroid.Size = new Size(0, 23);
            donushizi_centroid.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 0;
            label4.Text = "Centroid : ";
            // 
            // sure_panel
            // 
            sure_panel.BackColor = Color.LightSteelBlue;
            sure_panel.BorderStyle = BorderStyle.FixedSingle;
            sure_panel.Controls.Add(sure_agirlik);
            sure_panel.Controls.Add(label10);
            sure_panel.Controls.Add(sure_centroid);
            sure_panel.Controls.Add(label9);
            sure_panel.Location = new Point(603, 784);
            sure_panel.Name = "sure_panel";
            sure_panel.Size = new Size(573, 197);
            sure_panel.TabIndex = 5;
            // 
            // sure_agirlik
            // 
            sure_agirlik.AutoSize = true;
            sure_agirlik.BackColor = Color.DeepSkyBlue;
            sure_agirlik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sure_agirlik.Location = new Point(430, 1);
            sure_agirlik.Name = "sure_agirlik";
            sure_agirlik.Size = new Size(0, 23);
            sure_agirlik.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(298, 1);
            label10.Name = "label10";
            label10.Size = new Size(117, 23);
            label10.TabIndex = 4;
            label10.Text = "Ağırlıklı Ort :";
            // 
            // sure_centroid
            // 
            sure_centroid.AutoSize = true;
            sure_centroid.BackColor = Color.DeepSkyBlue;
            sure_centroid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sure_centroid.Location = new Point(104, 1);
            sure_centroid.Name = "sure_centroid";
            sure_centroid.Size = new Size(0, 23);
            sure_centroid.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(3, 1);
            label9.Name = "label9";
            label9.Size = new Size(95, 23);
            label9.TabIndex = 8;
            label9.Text = "Centroid : ";
            // 
            // deterjan_panel
            // 
            deterjan_panel.BackColor = Color.LightSteelBlue;
            deterjan_panel.BorderStyle = BorderStyle.FixedSingle;
            deterjan_panel.Controls.Add(deterjanAgirlik);
            deterjan_panel.Controls.Add(label7);
            deterjan_panel.Controls.Add(deterjan_centroid);
            deterjan_panel.Controls.Add(label6);
            deterjan_panel.Location = new Point(12, 783);
            deterjan_panel.Name = "deterjan_panel";
            deterjan_panel.Size = new Size(571, 198);
            deterjan_panel.TabIndex = 5;
            // 
            // deterjanAgirlik
            // 
            deterjanAgirlik.AutoSize = true;
            deterjanAgirlik.BackColor = Color.DeepSkyBlue;
            deterjanAgirlik.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deterjanAgirlik.Location = new Point(365, -1);
            deterjanAgirlik.Name = "deterjanAgirlik";
            deterjanAgirlik.Size = new Size(0, 23);
            deterjanAgirlik.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(227, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 6;
            label7.Text = "Ağırlık Ort.";
            // 
            // deterjan_centroid
            // 
            deterjan_centroid.AutoSize = true;
            deterjan_centroid.BackColor = Color.DeepSkyBlue;
            deterjan_centroid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deterjan_centroid.Location = new Point(104, 0);
            deterjan_centroid.Name = "deterjan_centroid";
            deterjan_centroid.Size = new Size(0, 23);
            deterjan_centroid.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 4;
            label6.Text = "Centroid : ";
            // 
            // mamdani_lstbox
            // 
            mamdani_lstbox.FormattingEnabled = true;
            mamdani_lstbox.Location = new Point(6, 22);
            mamdani_lstbox.Name = "mamdani_lstbox";
            mamdani_lstbox.Size = new Size(301, 124);
            mamdani_lstbox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1202, 991);
            Controls.Add(deterjan_panel);
            Controls.Add(sure_panel);
            Controls.Add(donus_hizi_panel);
            Controls.Add(dataGridView1);
            Controls.Add(kirlilik_panel);
            Controls.Add(miktar_panel);
            Controls.Add(hassaslik_panel);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bulanık Çamaşır Makinesi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kirlilik_numericupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)miktar_numericupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hassaslık_numericupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            donus_hizi_panel.ResumeLayout(false);
            donus_hizi_panel.PerformLayout();
            sure_panel.ResumeLayout(false);
            sure_panel.PerformLayout();
            deterjan_panel.ResumeLayout(false);
            deterjan_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown hassaslık_numericupdown;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown kirlilik_numericupdown;
        private NumericUpDown miktar_numericupdown;
        private Panel hassaslik_panel;
        private Panel miktar_panel;
        private Panel kirlilik_panel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel donus_hizi_panel;
        private Panel sure_panel;
        private Panel deterjan_panel;
        private Label donushizi_agırlıkort;
        private Label label5;
        private Label donushizi_centroid;
        private Label label4;
        private Label deterjanAgirlik;
        private Label label7;
        private Label deterjan_centroid;
        private Label label6;
        private Label sure_agirlik;
        private Label label10;
        private Label sure_centroid;
        private Label label9;
        private GroupBox groupBox2;
        private ListBox mamdani_lstbox;
    }
}
