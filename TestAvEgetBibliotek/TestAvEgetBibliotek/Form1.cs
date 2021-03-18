using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAvEgetBibliotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instans av faglærere sin demo klasse
        MittBibliotek_A mb = new MittBibliotek_A();

        // Instans av selvlagd klasse
        MittBibliotek_B mbb = new MittBibliotek_B();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Test av faglærer sin klasse
            textBox1.Text = "tall: " + mb.AddisjonAvToTall(6, 3);

            //Test av egne metoder i faglærer sin klasse
            textBox2.Text = "tall: " + mb.SubtraksjonAvToTall(6, 3);
            textBox3.Text = "tall: " + mb.DivisjonAvToTall(6, 3);

            //Test av egen metode i egen klasse
            textBox4.Text = Convert.ToString(mbb.FinnOrdITekst("ole", "skolegård"));
        }
    }
}
