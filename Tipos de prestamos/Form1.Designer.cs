namespace Tipos_de_prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbConsumo = new System.Windows.Forms.RadioButton();
            this.rbVehiculo = new System.Windows.Forms.RadioButton();
            this.rbVivienda = new System.Windows.Forms.RadioButton();
            this.gboTP = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gboTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbConsumo
            // 
            this.rbConsumo.AutoSize = true;
            this.rbConsumo.Location = new System.Drawing.Point(22, 32);
            this.rbConsumo.Name = "rbConsumo";
            this.rbConsumo.Size = new System.Drawing.Size(69, 17);
            this.rbConsumo.TabIndex = 0;
            this.rbConsumo.TabStop = true;
            this.rbConsumo.Text = "Consumo";
            this.rbConsumo.UseVisualStyleBackColor = true;
            // 
            // rbVehiculo
            // 
            this.rbVehiculo.AutoSize = true;
            this.rbVehiculo.Location = new System.Drawing.Point(22, 63);
            this.rbVehiculo.Name = "rbVehiculo";
            this.rbVehiculo.Size = new System.Drawing.Size(66, 17);
            this.rbVehiculo.TabIndex = 1;
            this.rbVehiculo.TabStop = true;
            this.rbVehiculo.Text = "Vehiculo";
            this.rbVehiculo.UseVisualStyleBackColor = true;
            // 
            // rbVivienda
            // 
            this.rbVivienda.AutoSize = true;
            this.rbVivienda.Location = new System.Drawing.Point(22, 95);
            this.rbVivienda.Name = "rbVivienda";
            this.rbVivienda.Size = new System.Drawing.Size(66, 17);
            this.rbVivienda.TabIndex = 2;
            this.rbVivienda.TabStop = true;
            this.rbVivienda.Text = "Vivienda";
            this.rbVivienda.UseVisualStyleBackColor = true;
            // 
            // gboTP
            // 
            this.gboTP.Controls.Add(this.rbVivienda);
            this.gboTP.Controls.Add(this.rbConsumo);
            this.gboTP.Controls.Add(this.rbVehiculo);
            this.gboTP.Location = new System.Drawing.Point(12, 12);
            this.gboTP.Name = "gboTP";
            this.gboTP.Size = new System.Drawing.Size(203, 122);
            this.gboTP.TabIndex = 3;
            this.gboTP.TabStop = false;
            this.gboTP.Text = "Tipo de prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto del prestamo";
            // 
            // mtxMonto
            // 
            this.mtxMonto.Location = new System.Drawing.Point(390, 27);
            this.mtxMonto.Mask = "999999999999999";
            this.mtxMonto.Name = "mtxMonto";
            this.mtxMonto.Size = new System.Drawing.Size(94, 20);
            this.mtxMonto.TabIndex = 5;
            this.mtxMonto.ValidatingType = typeof(int);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(392, 86);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 228);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboTP);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.gboTP.ResumeLayout(false);
            this.gboTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbConsumo;
        private System.Windows.Forms.RadioButton rbVehiculo;
        private System.Windows.Forms.RadioButton rbVivienda;
        private System.Windows.Forms.GroupBox gboTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxMonto;
        private System.Windows.Forms.Button btnCalcular;
    }
}

