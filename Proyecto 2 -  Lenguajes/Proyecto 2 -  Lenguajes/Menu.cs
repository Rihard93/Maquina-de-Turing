using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2____Lenguajes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            Maquina_1 MT1 = new Maquina_1();
            MT1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            Maquina_3 MT3 = new Maquina_3();
            MT3.Show();
            this.Hide();
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            Maquina_4 MT4 = new Maquina_4();
            MT4.Show();
            this.Hide();
        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            Maquina_5 MT5 = new Maquina_5();
            MT5.Show();
            this.Hide();
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            Maquina_2 MT2 = new Maquina_2();
            MT2.Show();
            this.Hide();
        }
    }
}
