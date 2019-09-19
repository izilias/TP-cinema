using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpCinema
{
    public partial class Form1 : Form
    {
        private List<SalleCinema> lesSalles;
        public Form1()
        {
            InitializeComponent();
            SalleCinema Salle1 = new SalleCinema("Bad boy", 50, 8.60, 1);

            SalleCinema Salle2 = new SalleCinema("Avatar", 50, 8.60, 2);

            lesSalles = new List<SalleCinema>();
            lesSalles.Add(Salle1);
            lesSalles.Add(Salle2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (SalleCinema salle in lesSalles)
            {
                if (Convert.ToInt32(textBox1.Text) == salle.numsal)
                {
                    label1.Text = salle.toString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (SalleCinema salle in lesSalles)
            {
                if (Convert.ToInt32(textBox1.Text) == salle.numsal)
                {
                    salle.VendrePlaces(Convert.ToInt32(textBox2.Text), checkBox1.Checked);
                    label1.Text = salle.toString();
                    label5.Text = Convert.ToString(salle.chiffreAffaires());
                }
            }
        }
    }
}
