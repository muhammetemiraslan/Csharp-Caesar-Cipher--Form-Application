namespace caesar
{
    public partial class Form1 : Form
    {

        string metin = "";
        string sifreliMetin = "";
        string alfabe = "abcçdefgðhýijklmnoöprþtuüvyz";
        int anahtar = 3;

        public Form1()
        {
            InitializeComponent();
        }

        void sifrele()
        {
            sifreliMetin = "";

            metin = textBox1.Text;
            metin = textBox1.Text.ToLower();

            for (int i = 0; i < metin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 28; j++)
                {
                    if (metin[i] == alfabe[j])
                    {
                        sonuc = true;
                        char ch = alfabe[(j + anahtar) % 28];
                        sifreliMetin += ch;
                    }
                }
                if (!sonuc)
                    sifreliMetin += metin[i];
            }


            textBox2.Text = sifreliMetin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifrele();
        }

        void desifre()
        {
            metin = "";

            sifreliMetin = textBox2.Text.ToLower();

            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 28; j++)
                {
                    if (sifreliMetin[i] == alfabe[j])
                    {
                        sonuc = true;

                        int indis = j - anahtar;
                        if (indis < 0)
                            indis += 28;

                        char ch = alfabe[indis];

                        metin += ch;
                    }
                }
                if (!sonuc)
                    metin += sifreliMetin[i];
            }


            textBox3.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desifre();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}