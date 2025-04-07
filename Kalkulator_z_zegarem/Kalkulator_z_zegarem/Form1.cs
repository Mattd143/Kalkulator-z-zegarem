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
            this.zegar = null;
            Form1.loo++;
        }

        public Form1(Form2 rodzic)
        {
            InitializeComponent();
            this.zegar = rodzic;
            Form1.loo++;
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
            if (!textBox1.Text.Contains(",") && !textBox1.Text.Contains("B³¹d"))  // warunek który uniemo¿liwia wpisania wielu kropek
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
                if (!string.IsNullOrEmpty(textBox1.Text))         // warunek ktory umozliwia zmienienie dzialania (mozna klikac kilka razy klawisz dzialania i bedzie zapisany najnowszy)
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

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    this.P_zero.PerformClick();
                    break;
                case '1':
                    this.P_jeden.PerformClick();
                    break;
                case '2':
                    this.P_dwa.PerformClick();
                    break;
                case '3':
                    this.P_trzy.PerformClick();
                    break;
                case '4':
                    this.P_cztery.PerformClick();
                    break;
                case '5':
                    this.P_piec.PerformClick();
                    break;
                case '6':
                    this.P_szesc.PerformClick();
                    break;
                case '7':
                    this.P_siedem.PerformClick();
                    break;
                case '8':
                    this.P_osiem.PerformClick();
                    break;
                case '9':
                    this.P_dziewiec.PerformClick();
                    break;
                case '-':
                    this.P_minus.PerformClick();
                    break;
                case '+':
                    this.P_plus.PerformClick();
                    break;
                case 'c':
                    this.P_clear.PerformClick();
                    break;
                case '=':
                    this.P_rownosc.PerformClick();
                    break;
                case '%':
                    this.P_procent.PerformClick(); 
                    break;
                case '`':
                    this.P_pierwiastek.PerformClick();
                    break;
                case '*':
                    this.P_razy.PerformClick();
                    break;
                case '/':
                    this.P_dzielenie.PerformClick();
                    break;
                case '?': 
                    this.P_znak.PerformClick();          // znak zapytania na klawiaturze odpowiada zmianie znaku
                    break;

            }

        }

        private void zieloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Mateu\\source\\repos\\C++\\Cisek_laby\\Zad1_Kalkulator\\Zdjecia\\85e15e1b-f8aa-45f2-adc1-9d90f1bf08c6.jfif");
        }

        private void niebieskieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Mateu\\source\\repos\\C++\\Cisek_laby\\Zad1_Kalkulator\\Zdjecia\\0a62b64c-3c11-497e-8229-3fbe9f86f047.jfif");
        }

        private void ró¿oweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Mateu\\source\\repos\\C++\\Cisek_laby\\Zad1_Kalkulator\\Zdjecia\\5c760003-527c-4569-88fc-a4dbdca30d17.jfif");
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit(); // dzia³a równie¿ na ukryte okienka
        }

        private void otwórzZegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form2.loo == 0)   // zabezpieczenie przed otwarciem wiecej niz jednego okna
            {
                this.zegar = new Form2();
                // this.Hide();
                
                
                zegar.ShowDialog();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}