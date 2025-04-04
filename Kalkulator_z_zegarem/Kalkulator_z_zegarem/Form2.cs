using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_z_zegarem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.kalkulator = null;
            Form2.loo++;
        }
        public Form2(Form1 rodzic)
        {
            InitializeComponent();
            this.kalkulator = rodzic;
            Form2.loo++;
        }
    }
}
