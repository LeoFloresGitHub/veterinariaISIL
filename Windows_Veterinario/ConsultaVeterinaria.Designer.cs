namespace Windows_Veterinario
{
    partial class ConsultaVeterinaria
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
            this.btnMascota = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVeterinario = new System.Windows.Forms.Button();
            this.btnEspecies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMascota
            // 
            this.btnMascota.Location = new System.Drawing.Point(130, 39);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(75, 23);
            this.btnMascota.TabIndex = 0;
            this.btnMascota.Text = "Mascotas";
            this.btnMascota.UseVisualStyleBackColor = true;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(29, 39);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.Location = new System.Drawing.Point(226, 39);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.Size = new System.Drawing.Size(75, 23);
            this.btnVeterinario.TabIndex = 2;
            this.btnVeterinario.Text = "Veterinario";
            this.btnVeterinario.UseVisualStyleBackColor = true;
            this.btnVeterinario.Click += new System.EventHandler(this.btnVeterinario_Click);
            // 
            // btnEspecies
            // 
            this.btnEspecies.Location = new System.Drawing.Point(29, 119);
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Size = new System.Drawing.Size(75, 23);
            this.btnEspecies.TabIndex = 3;
            this.btnEspecies.Text = "Especies";
            this.btnEspecies.UseVisualStyleBackColor = true;
            this.btnEspecies.Click += new System.EventHandler(this.btnEspecies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Realizar consultas de visitas de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de mascota por especie:";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalir.Location = new System.Drawing.Point(236, 124);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(49, 18);
            this.lblSalir.TabIndex = 6;
            this.lblSalir.Text = "SALIR";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // ConsultaVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 166);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEspecies);
            this.Controls.Add(this.btnVeterinario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultaVeterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaVeterinaria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultaVeterinaria_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVeterinario;
        private System.Windows.Forms.Button btnEspecies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalir;
    }
}