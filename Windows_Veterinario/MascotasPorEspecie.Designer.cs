namespace Windows_Veterinario
{
    partial class MascotasPorEspecie
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
            this.cboEspecies = new System.Windows.Forms.ComboBox();
            this.dtgMascotas = new System.Windows.Forms.DataGridView();
            this.cod_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione especie: ";
            // 
            // cboEspecies
            // 
            this.cboEspecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecies.FormattingEnabled = true;
            this.cboEspecies.Location = new System.Drawing.Point(148, 28);
            this.cboEspecies.Name = "cboEspecies";
            this.cboEspecies.Size = new System.Drawing.Size(185, 21);
            this.cboEspecies.TabIndex = 1;
            // 
            // dtgMascotas
            // 
            this.dtgMascotas.AllowUserToAddRows = false;
            this.dtgMascotas.AllowUserToDeleteRows = false;
            this.dtgMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_mascota,
            this.nom_mascota,
            this.Especie});
            this.dtgMascotas.Location = new System.Drawing.Point(39, 140);
            this.dtgMascotas.Name = "dtgMascotas";
            this.dtgMascotas.ReadOnly = true;
            this.dtgMascotas.RowHeadersVisible = false;
            this.dtgMascotas.Size = new System.Drawing.Size(304, 275);
            this.dtgMascotas.TabIndex = 2;
            // 
            // cod_mascota
            // 
            this.cod_mascota.DataPropertyName = "cod_mascota";
            this.cod_mascota.HeaderText = "Código";
            this.cod_mascota.Name = "cod_mascota";
            this.cod_mascota.ReadOnly = true;
            // 
            // nom_mascota
            // 
            this.nom_mascota.DataPropertyName = "nom_mascota";
            this.nom_mascota.HeaderText = "Nombre";
            this.nom_mascota.Name = "nom_mascota";
            this.nom_mascota.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "Especie";
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de mascotas";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(93, 66);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 24);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(289, 430);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Registros:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(268, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MascotasPorEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 504);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgMascotas);
            this.Controls.Add(this.cboEspecies);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MascotasPorEspecie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MascotasPorEspecie";
            this.Load += new System.EventHandler(this.MascotasPorEspecie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEspecies;
        private System.Windows.Forms.DataGridView dtgMascotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}