namespace Windows_Veterinario
{
    partial class ConsultasTotalesXAño
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.dtgTop = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Seleccione Año:";
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cboAño.Location = new System.Drawing.Point(141, 26);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(185, 21);
            this.cboAño.TabIndex = 41;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(70, 64);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 24);
            this.btnConsultar.TabIndex = 40;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(17, 116);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(115, 13);
            this.lblTop.TabIndex = 39;
            this.lblTop.Text = "Consultas totales  \" \"  :";
            // 
            // dtgTop
            // 
            this.dtgTop.AllowUserToAddRows = false;
            this.dtgTop.AllowUserToDeleteRows = false;
            this.dtgTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.Consultas,
            this.Montos});
            this.dtgTop.Location = new System.Drawing.Point(20, 154);
            this.dtgTop.Name = "dtgTop";
            this.dtgTop.ReadOnly = true;
            this.dtgTop.RowHeadersVisible = false;
            this.dtgTop.Size = new System.Drawing.Size(306, 135);
            this.dtgTop.TabIndex = 38;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Consultas
            // 
            this.Consultas.DataPropertyName = "Consultas";
            this.Consultas.HeaderText = "Consultas";
            this.Consultas.Name = "Consultas";
            this.Consultas.ReadOnly = true;
            // 
            // Montos
            // 
            this.Montos.DataPropertyName = "Montos";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Montos.DefaultCellStyle = dataGridViewCellStyle1;
            this.Montos.HeaderText = " Montos (S/.)";
            this.Montos.Name = "Montos";
            this.Montos.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(242, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultasTotalesXAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 340);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.dtgTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultasTotalesXAño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasTotalesXAño";
            this.Load += new System.EventHandler(this.ConsultasTotalesXAño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dtgTop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montos;
        private System.Windows.Forms.Button btnSalir;
    }
}