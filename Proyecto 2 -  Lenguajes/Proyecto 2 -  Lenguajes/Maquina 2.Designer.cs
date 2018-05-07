namespace Proyecto_2____Lenguajes
{
    partial class Maquina_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aceptacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.N_Pasos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstadoAct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cabezal = new System.Windows.Forms.Label();
            this.Cinta = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.EMT1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aceptacion
            // 
            this.Aceptacion.AutoSize = true;
            this.Aceptacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptacion.Location = new System.Drawing.Point(600, 240);
            this.Aceptacion.Name = "Aceptacion";
            this.Aceptacion.Size = new System.Drawing.Size(36, 19);
            this.Aceptacion.TabIndex = 25;
            this.Aceptacion.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado Cadena:";
            // 
            // N_Pasos
            // 
            this.N_Pasos.AutoSize = true;
            this.N_Pasos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Pasos.Location = new System.Drawing.Point(305, 240);
            this.N_Pasos.Name = "N_Pasos";
            this.N_Pasos.Size = new System.Drawing.Size(18, 19);
            this.N_Pasos.TabIndex = 23;
            this.N_Pasos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pasos:";
            // 
            // EstadoAct
            // 
            this.EstadoAct.AutoSize = true;
            this.EstadoAct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoAct.Location = new System.Drawing.Point(16, 240);
            this.EstadoAct.Name = "EstadoAct";
            this.EstadoAct.Size = new System.Drawing.Size(36, 19);
            this.EstadoAct.TabIndex = 21;
            this.EstadoAct.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado:";
            // 
            // Cabezal
            // 
            this.Cabezal.AutoSize = true;
            this.Cabezal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabezal.Location = new System.Drawing.Point(16, 112);
            this.Cabezal.Name = "Cabezal";
            this.Cabezal.Size = new System.Drawing.Size(29, 33);
            this.Cabezal.TabIndex = 19;
            this.Cabezal.Text = "↓";
            // 
            // Cinta
            // 
            this.Cinta.AutoSize = true;
            this.Cinta.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinta.Location = new System.Drawing.Point(16, 145);
            this.Cinta.Name = "Cinta";
            this.Cinta.Size = new System.Drawing.Size(29, 33);
            this.Cinta.TabIndex = 18;
            this.Cinta.Text = "β";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(604, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 68);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Menu Principal";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(309, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(289, 68);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Iniciar Maquina de Turing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(20, 56);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(258, 31);
            this.btnIngreso.TabIndex = 15;
            this.btnIngreso.Text = "Ingresar Cadena";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // EMT1
            // 
            this.EMT1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMT1.Location = new System.Drawing.Point(104, 16);
            this.EMT1.Name = "EMT1";
            this.EMT1.Size = new System.Drawing.Size(175, 27);
            this.EMT1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadena:";
            // 
            // Maquina_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 275);
            this.ControlBox = false;
            this.Controls.Add(this.Aceptacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.N_Pasos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EstadoAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cabezal);
            this.Controls.Add(this.Cinta);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.EMT1);
            this.Controls.Add(this.label1);
            this.Name = "Maquina_2";
            this.Text = "Copia de Patron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aceptacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label N_Pasos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EstadoAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cabezal;
        private System.Windows.Forms.Label Cinta;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox EMT1;
        private System.Windows.Forms.Label label1;
    }
}