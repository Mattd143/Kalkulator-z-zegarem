namespace Kalkulator_z_zegarem
{
    public partial class Form1 : Form
    {

        private decimal wartosc1 = 0;  // miejsce na zmienne
        private decimal wartosc2 = 0;
        private decimal wynik = 0;
        private string dzialanie = "+";
        private bool tosamodzialanie = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void P_zero_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))                // usuwa napis z b³êdem
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
            if (!textBox1.Text.Contains(",") && textBox1.Text.Contains("B³¹d"))  // warunek który uniemo¿liwia wpisania wielu kropek
            {
                textBox1.Text += ",";
            }
        }

        private void P_jeden_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))        // warunek usuwaj¹cy pocz¹tkowe zero z wyœwietlacza i ewentualny napis z bledem
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d") )
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            if (textBox1.Text == "0" || textBox1.Text.Contains("B³¹d"))
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
            tosamodzialanie = false;
            wartosc2 = 0;
            wartosc1 = 0;        // usuwa zapamietane dzialanie
        }

        private void P_znak_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d") && !string.IsNullOrEmpty(textBox1.Text))
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
        }

        private void P_minus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))         // warunek ktory umozliwia zmienienie dzialania (mozna klikac kilka razy klawisz dzialania i nie bedzie zapisany najnowszy)
                {
                    wartosc1 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                dzialanie = "-";
                tosamodzialanie = false;
            }
        }

        private void P_plus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    wartosc1 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                dzialanie = "+";
                tosamodzialanie = false;
            }
        }

        private void P_razy_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    wartosc1 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                dzialanie = "*";
                tosamodzialanie = false;
            }
        }

        private void P_dzielenie_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    wartosc1 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                dzialanie = "/";
                tosamodzialanie = false;
            }
        }

        private void P_procent_Click(object sender, EventArgs e)       // reszta z dzielenia
        {
            if (!textBox1.Text.Contains("B³¹d"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    wartosc1 = decimal.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                dzialanie = "%";
                tosamodzialanie = false;
            }
        }

        private void P_pierwiastek_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("B³¹d") && !string.IsNullOrEmpty(textBox1.Text))
            {
                wartosc1 = (decimal)double.Parse(textBox1.Text);
                textBox1.Clear();
                if (wartosc1 >= 0)
                {
                    wynik = (decimal)Math.Sqrt((double)wartosc1);
                    textBox1.Text = wynik.ToString();
                }
                else
                {
                    textBox1.Text = "B³¹d, pierwiastkowanie liczb ujemnych";
                }
            }
        }

        private void P_rownosc_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case "-":
                    if (tosamodzialanie == false && !string.IsNullOrEmpty(textBox1.Text))
                    {
                        wartosc2 = decimal.Parse(textBox1.Text);
                    }
                    wynik = wartosc1 - wartosc2;
                    textBox1.Text = wynik.ToString();
                    wartosc1 = wynik;
                    tosamodzialanie = true;

                    break;
                case "+":
                    if (!string.IsNullOrEmpty(textBox1.Text))        // warunek ktory umozliwia klikniecie dzialanie i od razu znaku rownosci
                    {
                        wartosc2 = decimal.Parse(textBox1.Text);
                    }
                    wynik = wartosc1 + wartosc2;
                    textBox1.Text = wynik.ToString();
                    if (tosamodzialanie == false)
                    {
                        wartosc1 = wartosc2;
                        tosamodzialanie = true;
                    }
                    break;
                case "/":
                    if (tosamodzialanie == false && !string.IsNullOrEmpty(textBox1.Text))
                    {
                        wartosc2 = decimal.Parse(textBox1.Text);
                    }
                    if (wartosc2 != 0) 
                    {
                        wynik = wartosc1 / wartosc2;
                        textBox1.Text = wynik.ToString();
                        wartosc1 = wynik;
                        tosamodzialanie = true;
                    }
                    else
                    {
                        textBox1.Text = "B³¹d, nie mo¿na dzieliæ przez zero";
                    }
                    break;
                case "*":
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        wartosc2 = decimal.Parse(textBox1.Text);
                    }
                    wynik = wartosc1 * wartosc2;
                    textBox1.Text = wynik.ToString();
                    if (tosamodzialanie == false)
                    {
                        wartosc1 = wartosc2;
                        tosamodzialanie = true;
                    }
                    break;
                case "%":
                    if (tosamodzialanie == false && !string.IsNullOrEmpty(textBox1.Text))
                    {
                        wartosc2 = decimal.Parse(textBox1.Text);
                    }
                    wynik = wartosc1 % wartosc2;
                    textBox1.Text = wynik.ToString();
                    wartosc1 = wynik;
                    tosamodzialanie = true;
                    break;

            }

        }

        private void P_procent_Resize(object sender, EventArgs e)
        {

        }
    }
}