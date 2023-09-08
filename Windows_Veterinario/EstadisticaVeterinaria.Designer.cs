namespace Windows_Veterinario
{
    partial class EstadisticaVeterinaria
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSalir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnMedicina = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnMascota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalir.Location = new System.Drawing.Point(244, 124);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(49, 18);
            this.lblSalir.TabIndex = 13;
            this.lblSalir.Text = "SALIR";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad consultas por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Top consultas:";
            // 
            // btnAño
            // 
            this.btnAño.Location = new System.Drawing.Point(37, 119);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(75, 23);
            this.btnAño.TabIndex = 10;
            this.btnAño.Text = "Año";
            this.btnAño.UseVisualStyleBackColor = true;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnMedicina
            // 
            this.btnMedicina.Location = new System.Drawing.Point(234, 39);
            this.btnMedicina.Name = "btnMedicina";
            this.btnMedicina.Size = new System.Drawing.Size(75, 23);
            this.btnMedicina.TabIndex = 9;
            this.btnMedicina.Text = "Medicina";
            this.btnMedicina.UseVisualStyleBackColor = true;
            this.btnMedicina.Click += new System.EventHandler(this.btnVeterinario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(37, 39);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnMascota
            // 
            this.btnMascota.Location = new System.Drawing.Point(138, 39);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(75, 23);
            this.btnMascota.TabIndex = 7;
            this.btnMascota.Text = "Mascotas";
            this.btnMascota.UseVisualStyleBackColor = true;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // EstadisticaVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 169);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAño);
            this.Controls.Add(this.btnMedicina);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EstadisticaVeterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaVeterinaria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EstadisticaVeterinaria_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnMedicina;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnMascota;
    }
}