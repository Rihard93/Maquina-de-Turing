namespace Proyecto_2____Lenguajes
{
    partial class Maquina_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EMT1 = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Cinta = new System.Windows.Forms.Label();
            this.Cabezal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstadoAct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N_Pasos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aceptacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena:";
            // 
            // EMT1
            // 
            this.EMT1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMT1.Location = new System.Drawing.Point(102, 10);
            this.EMT1.Name = "EMT1";
            this.EMT1.Size = new System.Drawing.Size(175, 27);
            this.EMT1.TabIndex = 1;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(18, 50);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(258, 31);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresar Cadena";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(307, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(289, 68);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Iniciar Maquina de Turing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(602, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 68);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Menu Principal";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Cinta
            // 
            this.Cinta.AutoSize = true;
            this.Cinta.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinta.Location = new System.Drawing.Point(14, 139);
            this.Cinta.Name = "Cinta";
            this.Cinta.Size = new System.Drawing.Size(29, 33);
            this.Cinta.TabIndex = 5;
            this.Cinta.Text = "β";
            // 
            // Cabezal
            // 
            this.Cabezal.AutoSize = true;
            this.Cabezal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabezal.Location = new System.Drawing.Point(14, 106);
            this.Cabezal.Name = "Cabezal";
            this.Cabezal.Size = new System.Drawing.Size(29, 33);
            this.Cabezal.TabIndex = 6;
            this.Cabezal.Text = "↓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado:";
            // 
            // EstadoAct
            // 
            this.EstadoAct.AutoSize = true;
            this.EstadoAct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoAct.Location = new System.Drawing.Point(14, 234);
            this.EstadoAct.Name = "EstadoAct";
            this.EstadoAct.Size = new System.Drawing.Size(36, 19);
            this.EstadoAct.TabIndex = 8;
            this.EstadoAct.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pasos:";
            // 
            // N_Pasos
            // 
            this.N_Pasos.AutoSize = true;
            this.N_Pasos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Pasos.Location = new System.Drawing.Point(303, 234);
            this.N_Pasos.Name = "N_Pasos";
            this.N_Pasos.Size = new System.Drawing.Size(18, 19);
            this.N_Pasos.TabIndex = 10;
            this.N_Pasos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado Cadena:";
            // 
            // Aceptacion
            // 
            this.Aceptacion.AutoSize = true;
            this.Aceptacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptacion.Location = new System.Drawing.Point(598, 234);
            this.Aceptacion.Name = "Aceptacion";
            this.Aceptacion.Size = new System.Drawing.Size(36, 19);
            this.Aceptacion.TabIndex = 12;
            this.Aceptacion.Text = "N/A";
            // 
            // Maquina_1
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
            this.Name = "Maquina_1";
            this.Text = "Palindromos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EMT1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Cinta;
        private System.Windows.Forms.Label Cabezal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EstadoAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label N_Pasos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Aceptacion;
    }
}