
namespace Temperaturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbMedidas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformacion2 = new System.Windows.Forms.Label();
            this.pnlCelsius = new System.Windows.Forms.Panel();
            this.pnlKelvin = new System.Windows.Forms.Panel();
            this.cmbKelvin = new System.Windows.Forms.ComboBox();
            this.cmbCelsius = new System.Windows.Forms.ComboBox();
            this.pnlFahrenheit = new System.Windows.Forms.Panel();
            this.cmbFahrenheit = new System.Windows.Forms.ComboBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtMedidas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.pnlCelsius.SuspendLayout();
            this.pnlKelvin.SuspendLayout();
            this.pnlFahrenheit.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMedidas
            // 
            this.CmbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMedidas.FormattingEnabled = true;
            this.CmbMedidas.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.CmbMedidas.Location = new System.Drawing.Point(184, 15);
            this.CmbMedidas.Name = "CmbMedidas";
            this.CmbMedidas.Size = new System.Drawing.Size(121, 21);
            this.CmbMedidas.TabIndex = 0;
            this.CmbMedidas.SelectedIndexChanged += new System.EventHandler(this.CmbMedidas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlFahrenheit);
            this.groupBox1.Controls.Add(this.pnlKelvin);
            this.groupBox1.Controls.Add(this.lblInformacion2);
            this.groupBox1.Controls.Add(this.lblInformacion);
            this.groupBox1.Controls.Add(this.pnlCelsius);
            this.groupBox1.Controls.Add(this.pnlDatos);
            this.groupBox1.Controls.Add(this.CmbMedidas);
            this.groupBox1.Location = new System.Drawing.Point(-3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblInformacion2
            // 
            this.lblInformacion2.AutoSize = true;
            this.lblInformacion2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion2.Location = new System.Drawing.Point(6, 104);
            this.lblInformacion2.Name = "lblInformacion2";
            this.lblInformacion2.Size = new System.Drawing.Size(172, 16);
            this.lblInformacion2.TabIndex = 3;
            this.lblInformacion2.Text = "Seleccione la medida a transformar";
            // 
            // pnlCelsius
            // 
            this.pnlCelsius.Controls.Add(this.cmbCelsius);
            this.pnlCelsius.Location = new System.Drawing.Point(184, 104);
            this.pnlCelsius.Name = "pnlCelsius";
            this.pnlCelsius.Size = new System.Drawing.Size(126, 31);
            this.pnlCelsius.TabIndex = 2;
            this.pnlCelsius.Visible = false;
            // 
            // pnlKelvin
            // 
            this.pnlKelvin.Controls.Add(this.cmbKelvin);
            this.pnlKelvin.Location = new System.Drawing.Point(184, 104);
            this.pnlKelvin.Name = "pnlKelvin";
            this.pnlKelvin.Size = new System.Drawing.Size(126, 31);
            this.pnlKelvin.TabIndex = 4;
            this.pnlKelvin.Visible = false;
            // 
            // cmbKelvin
            // 
            this.cmbKelvin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKelvin.FormattingEnabled = true;
            this.cmbKelvin.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.cmbKelvin.Location = new System.Drawing.Point(0, 3);
            this.cmbKelvin.Name = "cmbKelvin";
            this.cmbKelvin.Size = new System.Drawing.Size(121, 21);
            this.cmbKelvin.TabIndex = 0;
            // 
            // cmbCelsius
            // 
            this.cmbCelsius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCelsius.FormattingEnabled = true;
            this.cmbCelsius.Items.AddRange(new object[] {
            "Fahrenheit",
            "Kelvin"});
            this.cmbCelsius.Location = new System.Drawing.Point(0, 3);
            this.cmbCelsius.Name = "cmbCelsius";
            this.cmbCelsius.Size = new System.Drawing.Size(121, 21);
            this.cmbCelsius.TabIndex = 0;
            // 
            // pnlFahrenheit
            // 
            this.pnlFahrenheit.Controls.Add(this.cmbFahrenheit);
            this.pnlFahrenheit.Location = new System.Drawing.Point(184, 104);
            this.pnlFahrenheit.Name = "pnlFahrenheit";
            this.pnlFahrenheit.Size = new System.Drawing.Size(126, 31);
            this.pnlFahrenheit.TabIndex = 3;
            this.pnlFahrenheit.Visible = false;
            // 
            // cmbFahrenheit
            // 
            this.cmbFahrenheit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFahrenheit.FormattingEnabled = true;
            this.cmbFahrenheit.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin"});
            this.cmbFahrenheit.Location = new System.Drawing.Point(0, 3);
            this.cmbFahrenheit.Name = "cmbFahrenheit";
            this.cmbFahrenheit.Size = new System.Drawing.Size(121, 21);
            this.cmbFahrenheit.TabIndex = 0;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(6, 16);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(151, 16);
            this.lblInformacion.TabIndex = 2;
            this.lblInformacion.Text = "Seleccione la medida a utilizar:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtMedidas);
            this.pnlDatos.Location = new System.Drawing.Point(184, 42);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(109, 35);
            this.pnlDatos.TabIndex = 2;
            this.pnlDatos.Visible = false;
            // 
            // txtMedidas
            // 
            this.txtMedidas.Location = new System.Drawing.Point(0, 3);
            this.txtMedidas.Name = "txtMedidas";
            this.txtMedidas.Size = new System.Drawing.Size(100, 20);
            this.txtMedidas.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCelsius.ResumeLayout(false);
            this.pnlKelvin.ResumeLayout(false);
            this.pnlFahrenheit.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMedidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMedidas;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Panel pnlCelsius;
        private System.Windows.Forms.Panel pnlFahrenheit;
        private System.Windows.Forms.Panel pnlKelvin;
        private System.Windows.Forms.ComboBox cmbCelsius;
        private System.Windows.Forms.ComboBox cmbFahrenheit;
        private System.Windows.Forms.ComboBox cmbKelvin;
        private System.Windows.Forms.Label lblInformacion2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

