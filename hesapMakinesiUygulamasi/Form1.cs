using System.Diagnostics;

namespace hesapMakinesiUygulamasi
{
    public partial class Form1 : Form
    {
        int sonuc, sayi1, sayi2;
        decimal ondalik;
        byte islem;

        public Form1()
        {
            InitializeComponent();
        }

        public int Sayi1al()
        {
            sayi1 = Convert.ToInt32(sayi.Text);
            label5.Text = sayi1.ToString();
            sayi.Text = "";
            return sayi1; 
        }

        public int Sayi2al()
        {
            sayi2 = Convert.ToInt32(sayi.Text);
            label6.Text = sayi2.ToString();
            sayi.Text = "";
            return sayi2;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 3;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cikartma_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 2;
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 1;
        }

        private void kucukBul_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 6;
        }

        private void yukariYuvarla_Click(object sender, EventArgs e)
        {

        }

        private void asagiYuvarla_Click(object sender, EventArgs e)
        {

        }

        private void mutlak_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 5;
        }

        private void buyukBul_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 7;
        }

        private void us_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 8;
        }

        private void karekok_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bolme_Click(object sender, EventArgs e)
        {
            Sayi1al();
            islem = 4;
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case 1:
                    Sayi2al();
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    Sayi2al();
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    Sayi2al();
                    sonuc= sayi1 * sayi2; 
                    break;
                case 4:
                    Sayi2al();
                    sonuc = sayi1 / sayi2;
                    break;
                case 5:
                    sonuc = Math.Abs(sayi1);
                    break;
                case 6:
                    Sayi2al();
                    sonuc = Math.Min(sayi1, sayi2);
                    break;
                case 7:
                    Sayi2al();
                    sonuc = Math.Max(sayi1, sayi2);
                    break;
                case 8:
                    Sayi2al();
                    sonuc = (int) Math.Pow(sayi1, sayi2);
                    break;
            }
            label7.Text = sonuc.ToString();
        }

        private void sayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
