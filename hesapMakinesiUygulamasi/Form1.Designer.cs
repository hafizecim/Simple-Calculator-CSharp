namespace hesapMakinesiUygulamasi
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
            label1 = new Label();
            sayi = new TextBox();
            toplama = new Button();
            cikartma = new Button();
            carpma = new Button();
            bolme = new Button();
            mutlak = new Button();
            asagiYuvarla = new Button();
            yukariYuvarla = new Button();
            yuvarla = new Button();
            karekok = new Button();
            us = new Button();
            buyukBul = new Button();
            kucukBul = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            esittir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 0;
            label1.Text = "Sayı Giriniz :";
            label1.Click += label1_Click;
            // 
            // sayi
            // 
            sayi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            sayi.Location = new Point(171, 14);
            sayi.Name = "sayi";
            sayi.Size = new Size(152, 36);
            sayi.TabIndex = 1;
            sayi.TextChanged += sayi_TextChanged;
            // 
            // toplama
            // 
            toplama.BackColor = Color.LightSalmon;
            toplama.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            toplama.ForeColor = SystemColors.ActiveCaptionText;
            toplama.Location = new Point(25, 113);
            toplama.Name = "toplama";
            toplama.Size = new Size(70, 70);
            toplama.TabIndex = 3;
            toplama.Text = "+";
            toplama.UseVisualStyleBackColor = false;
            toplama.Click += toplama_Click;
            // 
            // cikartma
            // 
            cikartma.BackColor = Color.LightSalmon;
            cikartma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cikartma.ForeColor = SystemColors.ActiveCaptionText;
            cikartma.Location = new Point(101, 113);
            cikartma.Name = "cikartma";
            cikartma.Size = new Size(70, 70);
            cikartma.TabIndex = 4;
            cikartma.Text = "-";
            cikartma.UseVisualStyleBackColor = false;
            cikartma.Click += cikartma_Click;
            // 
            // carpma
            // 
            carpma.BackColor = Color.LightSalmon;
            carpma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            carpma.ForeColor = SystemColors.ActiveCaptionText;
            carpma.Location = new Point(177, 113);
            carpma.Name = "carpma";
            carpma.Size = new Size(70, 70);
            carpma.TabIndex = 5;
            carpma.Text = "*";
            carpma.UseVisualStyleBackColor = false;
            carpma.Click += button4_Click;
            // 
            // bolme
            // 
            bolme.BackColor = Color.LightSalmon;
            bolme.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            bolme.ForeColor = SystemColors.ActiveCaptionText;
            bolme.Location = new Point(253, 113);
            bolme.Name = "bolme";
            bolme.Size = new Size(70, 70);
            bolme.TabIndex = 6;
            bolme.Text = "/";
            bolme.UseVisualStyleBackColor = false;
            bolme.Click += bolme_Click;
            // 
            // mutlak
            // 
            mutlak.BackColor = Color.LightSalmon;
            mutlak.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mutlak.ForeColor = SystemColors.ActiveCaptionText;
            mutlak.Location = new Point(253, 189);
            mutlak.Name = "mutlak";
            mutlak.Size = new Size(70, 70);
            mutlak.TabIndex = 10;
            mutlak.Text = "Mutlak Değer";
            mutlak.UseVisualStyleBackColor = false;
            mutlak.Click += mutlak_Click;
            // 
            // asagiYuvarla
            // 
            asagiYuvarla.BackColor = Color.LightSalmon;
            asagiYuvarla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            asagiYuvarla.ForeColor = SystemColors.ActiveCaptionText;
            asagiYuvarla.Location = new Point(177, 189);
            asagiYuvarla.Name = "asagiYuvarla";
            asagiYuvarla.Size = new Size(70, 70);
            asagiYuvarla.TabIndex = 9;
            asagiYuvarla.Text = "Aşağı Yuvarla";
            asagiYuvarla.UseVisualStyleBackColor = false;
            asagiYuvarla.Click += asagiYuvarla_Click;
            // 
            // yukariYuvarla
            // 
            yukariYuvarla.BackColor = Color.LightSalmon;
            yukariYuvarla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            yukariYuvarla.ForeColor = SystemColors.ActiveCaptionText;
            yukariYuvarla.Location = new Point(101, 189);
            yukariYuvarla.Name = "yukariYuvarla";
            yukariYuvarla.Size = new Size(70, 70);
            yukariYuvarla.TabIndex = 8;
            yukariYuvarla.Text = "Yukarı Yuvarla";
            yukariYuvarla.UseVisualStyleBackColor = false;
            yukariYuvarla.Click += yukariYuvarla_Click;
            // 
            // yuvarla
            // 
            yuvarla.BackColor = Color.LightSalmon;
            yuvarla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            yuvarla.ForeColor = SystemColors.ActiveCaptionText;
            yuvarla.Location = new Point(25, 189);
            yuvarla.Name = "yuvarla";
            yuvarla.Size = new Size(70, 70);
            yuvarla.TabIndex = 7;
            yuvarla.Text = "Yuvarla";
            yuvarla.UseVisualStyleBackColor = false;
            yuvarla.Click += yuvarla_Click;
            // 
            // karekok
            // 
            karekok.BackColor = Color.LightSalmon;
            karekok.Font = new Font("Segoe UI", 9.7F, FontStyle.Bold);
            karekok.ForeColor = SystemColors.ActiveCaptionText;
            karekok.Location = new Point(253, 265);
            karekok.Name = "karekok";
            karekok.Size = new Size(70, 70);
            karekok.TabIndex = 14;
            karekok.Text = "Karekök Alma";
            karekok.UseVisualStyleBackColor = false;
            karekok.Click += karekok_Click;
            // 
            // us
            // 
            us.BackColor = Color.LightSalmon;
            us.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            us.ForeColor = SystemColors.ActiveCaptionText;
            us.Location = new Point(177, 265);
            us.Name = "us";
            us.Size = new Size(70, 70);
            us.TabIndex = 13;
            us.Text = "Üs Alma";
            us.UseVisualStyleBackColor = false;
            us.Click += us_Click;
            // 
            // buyukBul
            // 
            buyukBul.BackColor = Color.LightSalmon;
            buyukBul.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buyukBul.ForeColor = SystemColors.ActiveCaptionText;
            buyukBul.Location = new Point(101, 265);
            buyukBul.Name = "buyukBul";
            buyukBul.Size = new Size(70, 70);
            buyukBul.TabIndex = 12;
            buyukBul.Text = "Büyük Sayı Bul";
            buyukBul.UseVisualStyleBackColor = false;
            buyukBul.Click += buyukBul_Click;
            // 
            // kucukBul
            // 
            kucukBul.BackColor = Color.LightSalmon;
            kucukBul.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            kucukBul.ForeColor = SystemColors.ActiveCaptionText;
            kucukBul.Location = new Point(25, 265);
            kucukBul.Name = "kucukBul";
            kucukBul.Size = new Size(70, 70);
            kucukBul.TabIndex = 11;
            kucukBul.Text = "Küçük Sayı Bul";
            kucukBul.UseVisualStyleBackColor = false;
            kucukBul.Click += kucukBul_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 352);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 15;
            label2.Text = "Birinci Sayı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 386);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 16;
            label3.Text = "İkinci Sayı :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 423);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 17;
            label4.Text = "Sonuç :";
            // 
            // label5
            // 
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.BackColor = Color.DarkTurquoise;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(177, 352);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 18;
            label5.Text = "Birinci sayı";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkTurquoise;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(177, 386);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 19;
            label6.Text = "İkinci Sayı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Violet;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(177, 420);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 20;
            label7.Text = "Sonuç";
            // 
            // esittir
            // 
            esittir.BackColor = Color.Aquamarine;
            esittir.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            esittir.Location = new Point(25, 62);
            esittir.Name = "esittir";
            esittir.Size = new Size(298, 45);
            esittir.TabIndex = 21;
            esittir.Text = "=";
            esittir.UseVisualStyleBackColor = false;
            esittir.Click += esittir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 463);
            Controls.Add(esittir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(karekok);
            Controls.Add(us);
            Controls.Add(buyukBul);
            Controls.Add(kucukBul);
            Controls.Add(mutlak);
            Controls.Add(asagiYuvarla);
            Controls.Add(yukariYuvarla);
            Controls.Add(yuvarla);
            Controls.Add(bolme);
            Controls.Add(carpma);
            Controls.Add(cikartma);
            Controls.Add(toplama);
            Controls.Add(sayi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sayi;
        private Button toplama;
        private Button cikartma;
        private Button carpma;
        private Button bolme;
        private Button mutlak;
        private Button asagiYuvarla;
        private Button yukariYuvarla;
        private Button yuvarla;
        private Button karekok;
        private Button us;
        private Button buyukBul;
        private Button kucukBul;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button esittir;
    }
}
