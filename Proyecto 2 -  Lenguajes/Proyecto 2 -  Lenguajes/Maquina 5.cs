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
    public partial class Maquina_5 : Form
    {
        string E;
        char C;
        string Cadena;
        char[] Caracteres;
        char[] Cabeza;
        int Contador = 0;
        int CCabeza = 0;
        int Pasos;
        async Task Esperar()
        {
            await Task.Delay(2000);
        }
        public async void Maquina(string Estado, char Caracter)
        {
            E = Estado;
            C = Caracter;
            await Esperar();
            switch (E)
            {
                case "q0":
                    if (C == '1')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'β';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q1";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q1", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q1":
                    if (C == '1' || C == '-')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q1";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q1", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q2";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q2", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q2":
                    if (C == '1')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'β';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q3";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q3", C);
                    }
                    else if (C == '-')
                    {
                        Pasos++;
                        Caracteres[Contador] = '1';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q4";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q4", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q3":
                    if (C == '1' || C == '-')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q3";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q3", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q0";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q0", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q4":
                    Aceptacion.Text = "Cadena Aceptada";
                    MessageBox.Show("La maquina se ha detenido", "Cadena Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public Maquina_5()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea ingresar esta cadena?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decision == DialogResult.Yes)
            {
                //Se revisa si el texto a ingresar esta en blanco
                if (EMT5.Text == "")
                {
                    btnStart.Enabled = false;
                    MessageBox.Show("No puede ingresar una cadena en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    EMT5.Enabled = false;
                    btnIngreso.Enabled = false;
                    btnStart.Enabled = true;
                }
            }
            else if (decision == DialogResult.No)
            {
                btnStart.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string Cabezas = Cabezal.Text;
            Cadena = EMT5.Text;
            Cadena = Cadena + "β";
            Caracteres = Cadena.ToCharArray();

            for (int i = 1; i < Cadena.Length; i++)
            {
                Cabezas = Cabezas + "β";
            }
            Cabeza = Cabezas.ToCharArray();
            Cabezal.Text = Cabezas;
            Cinta.Text = Cadena;
            EstadoAct.Text = "q0";
            Maquina("q0", Caracteres[Contador]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.Show();
        }
    }
}
