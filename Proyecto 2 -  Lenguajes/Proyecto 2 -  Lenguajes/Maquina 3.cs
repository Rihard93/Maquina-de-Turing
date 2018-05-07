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
    public partial class Maquina_3 : Form
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
                    else if (C == 'x')
                    {
                        Pasos++;
                        EstadoAct.Text = "q6";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q6", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q1":

                    if (C == '1')
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
                    else if (C == 'x')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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
                        Caracteres[Contador] = 'Y';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q3";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q3", C);
                    }
                    else if (C == '=')
                    {
                        Pasos++;                        
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q5";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q5", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q3":
                    if (C == '1' || C == '=')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q4":
                    if (C == '1' || C == '=')
                    {
                        Pasos++;
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
                    else if (C == 'Y')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q5":
                    if (C == '1' || C == 'x')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q5";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q5", C);
                    }
                    else if (C == 'Y')
                    {
                        Pasos++;
                        Caracteres[Contador] = '1';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q5";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q5", C);
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

                case "q6":
                    Aceptacion.Text = "Cadena Aceptada";
                    MessageBox.Show("La maquina se ha detenido", "Cadena Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public Maquina_3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.Show();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea ingresar esta cadena?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decision == DialogResult.Yes)
            {
                //Se revisa si el texto a ingresar esta en blanco
                if (EMT3.Text == "")
                {
                    btnStart.Enabled = false;
                    MessageBox.Show("No puede ingresar una cadena en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    EMT3.Enabled = false;
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
            int R;
            Cadena = EMT3.Text;
            Cadena = Cadena + "=";            
            R = Separador(EMT3.Text);

            for (int i = 1; i < Cadena.Length; i++)
            {
                Cabezas = Cabezas + "β";
            }
            for (int i = 0; i < R; i++)
            {
                Cadena = Cadena + "β";
                Cabezas = Cabezas + "β";
            }
            Caracteres = Cadena.ToCharArray();
            Cabeza = Cabezas.ToCharArray();
            Cabezal.Text = Cabezas;
            Cinta.Text = Cadena;
            EstadoAct.Text = "q0";
            Maquina("q0", Caracteres[Contador]);
        }

        public int Separador(string entrada)
        {
            int E1, E2;
            string[] T = entrada.Split('x');
            E1 = T[0].Length;
            E2 = T[1].Length;
            return E1 * E2;
        }
    }
}
