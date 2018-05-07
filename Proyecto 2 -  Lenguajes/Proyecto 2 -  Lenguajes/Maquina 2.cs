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
    public partial class Maquina_2 : Form
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
                    if (C == 'a')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'X';
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
                    else if (C == 'b')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'Y';
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
                    else if (C == 'c')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'Z';
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
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q1":
                    if (C == 'a' || C == 'b' || C == 'c')
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
                        Caracteres[Contador] = 'X';
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

                case "q2":
                    if (C == 'a' || C == 'b' || C == 'c')
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
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'Y';
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
                    if (C == 'a' || C == 'b' || C == 'c')
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
                        Caracteres[Contador] = 'Z';
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
                    if (C == 'a' || C == 'b' || C == 'c')
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
                    else if (C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;                        
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q5":
                    if (C == 'a')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'β';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q6";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q6", C);
                    }
                    else if (C == 'b')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'β';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q8";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q8", C);
                    }
                    else if (C == 'c')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'β';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q10";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q10", C);
                    }
                    else if (C == 'X')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'a';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q12";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q12", C);
                    }
                    else if (C == 'Y')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'b';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q13";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q13", C);
                    }
                    else if (C == 'Z')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'c';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q14";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q14", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q6":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q6";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q6", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'a';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q7";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q7", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q7":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q7";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q7", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'a';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q8":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q8";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q8", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'b';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q9";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q9", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q9":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q9";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q9", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'b';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q10":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q10";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q10", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'c';
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q11";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q11", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q11":
                    if (C == 'a' || C == 'b' || C == 'c' || C == 'X' || C == 'Y' || C == 'Z')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q11";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q11", C);
                    }
                    else if (C == 'β')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'c';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
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

                case "q12":
                    if (C == 'a' || C == 'b' || C == 'c')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q12";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q12", C);
                    }
                    else if (C == 'X')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'a';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q15";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q15", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q13":
                    if (C == 'a' || C == 'b' || C == 'c')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q13";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q13", C);
                    }
                    else if (C == 'Y')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'b';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q15";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q15", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q14":
                    if (C == 'a' || C == 'b' || C == 'c')
                    {
                        Pasos++;
                        Contador--;
                        Cabeza[CCabeza] = 'β';
                        CCabeza--;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q14";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q14", C);
                    }
                    else if (C == 'Z')
                    {
                        Pasos++;
                        Caracteres[Contador] = 'c';
                        Contador++;
                        Cabeza[CCabeza] = 'β';
                        CCabeza++;
                        Cabeza[CCabeza] = '↓';
                        EstadoAct.Text = "q15";
                        N_Pasos.Text = Pasos.ToString();
                        Cinta.Text = new string(Caracteres);
                        Cabezal.Text = new string(Cabeza);
                        C = Caracteres[Contador];
                        Maquina("q15", C);
                    }
                    else
                    {
                        Aceptacion.Text = "No Aceptada";
                        MessageBox.Show("La maquina se ha detenido", "Cadena No Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "q15":
                    Aceptacion.Text = "Cadena Aceptada";
                    MessageBox.Show("La maquina se ha detenido", "Cadena Aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }
        }
        public Maquina_2()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea ingresar esta cadena?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decision == DialogResult.Yes)
            {
                //Se revisa si el texto a ingresar esta en blanco
                if (EMT1.Text == "")
                {
                    btnStart.Enabled = false;
                    MessageBox.Show("No puede ingresar una cadena en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    EMT1.Enabled = false;
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
            Cadena = EMT1.Text;
            Cadena = Cadena + "β";            

            for (int i = 1; i < EMT1.Text.Length; i++)
            {
                Cadena = Cadena + "β";
            }
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
