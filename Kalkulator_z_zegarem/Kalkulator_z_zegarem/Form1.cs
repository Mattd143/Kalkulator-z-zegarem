namespace Kalkulator_z_zegarem
{
    public partial class Form1 : Form
    {

        private decimal wartosc1 = 0;  // miejsce na zmienne
        private decimal wartosc2 = 0;
        private decimal wynik = 0;
        private string dzialanie = "+";


        public Form1()
        {
            InitializeComponent();
        }

        private void P_zero_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "0";  // warunek uniemo¿liwiaj¹cy wpisywanie nieskoñczonych zer
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void P_kropka_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))  // warunek który uniemo¿liwia wpisania wielu kropek
            {
                textBox1.Text += ".";
            }
        }

        private void P_jeden_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")        // warunek usuwaj¹cy pocz¹tkowe zero z wyœwietlacza
            {
                textBox1.Text = "1";
            }
            else 
            { 
                textBox1.Text += "1"; 
            }
        }

        private void P_dwa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void P_trzy_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void P_cztery_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void P_piec_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void P_szesc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void P_siedem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void P_osiem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void P_dziewiec_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void P_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            wartosc1 = 0;
        }

        private void P_znak_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void P_minus_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "-";
        }

        private void P_plus_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "+";
        }

        private void P_razy_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "*";
        }

        private void P_dzielenie_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "/";
        }

        private void P_procent_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "%";
        }

        private void P_pierwiastek_Click(object sender, EventArgs e)
        {
            wartosc1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            dzialanie = "`";   // przypisalem pierwiastkowanie do tyldy
        }

        private void P_rownosc_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case "-":
                    wartosc2 = decimal.Parse(textBox1.Text);
                    wynik = wartosc1 - wartosc2;
                    textBox1.Text = wynik.ToString();
                break;
            }
        }
    }
}