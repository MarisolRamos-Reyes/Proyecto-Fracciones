namespace Fraccion2
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
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.lblResultadoNumerador = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.numentero1 = new System.Windows.Forms.NumericUpDown();
            this.numentero2 = new System.Windows.Forms.NumericUpDown();
            this.lblResultadoEntero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultadoDenominador = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numentero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numentero2)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Location = new System.Drawing.Point(86, 77);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(120, 20);
            this.numNumerador1.TabIndex = 1;
            // 
            // numDenominador1
            // 
            this.numDenominador1.Location = new System.Drawing.Point(86, 115);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(120, 20);
            this.numDenominador1.TabIndex = 2;
            // 
            // numNumerador2
            // 
            this.numNumerador2.Location = new System.Drawing.Point(358, 77);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(120, 20);
            this.numNumerador2.TabIndex = 3;
            // 
            // numDenominador2
            // 
            this.numDenominador2.Location = new System.Drawing.Point(358, 115);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(120, 20);
            this.numDenominador2.TabIndex = 4;
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(484, 96);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(24, 25);
            this.lblCalcularResultado.TabIndex = 5;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // lblResultadoNumerador
            // 
            this.lblResultadoNumerador.AutoSize = true;
            this.lblResultadoNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNumerador.Location = new System.Drawing.Point(567, 77);
            this.lblResultadoNumerador.Name = "lblResultadoNumerador";
            this.lblResultadoNumerador.Size = new System.Drawing.Size(26, 25);
            this.lblResultadoNumerador.TabIndex = 6;
            this.lblResultadoNumerador.Text = "X";
            // 
            // cboOperacion
            // 
            this.cboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(212, 93);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(66, 33);
            this.cboOperacion.TabIndex = 7;
            // 
            // numentero1
            // 
            this.numentero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numentero1.Location = new System.Drawing.Point(12, 85);
            this.numentero1.Name = "numentero1";
            this.numentero1.Size = new System.Drawing.Size(68, 44);
            this.numentero1.TabIndex = 8;
            // 
            // numentero2
            // 
            this.numentero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numentero2.Location = new System.Drawing.Point(284, 85);
            this.numentero2.Name = "numentero2";
            this.numentero2.Size = new System.Drawing.Size(68, 44);
            this.numentero2.TabIndex = 9;
            // 
            // lblResultadoEntero
            // 
            this.lblResultadoEntero.AutoSize = true;
            this.lblResultadoEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEntero.Location = new System.Drawing.Point(514, 93);
            this.lblResultadoEntero.Name = "lblResultadoEntero";
            this.lblResultadoEntero.Size = new System.Drawing.Size(43, 42);
            this.lblResultadoEntero.TabIndex = 10;
            this.lblResultadoEntero.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "____________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "____________________";
            // 
            // lblResultadoDenominador
            // 
            this.lblResultadoDenominador.AutoSize = true;
            this.lblResultadoDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDenominador.Location = new System.Drawing.Point(567, 115);
            this.lblResultadoDenominador.Name = "lblResultadoDenominador";
            this.lblResultadoDenominador.Size = new System.Drawing.Size(26, 25);
            this.lblResultadoDenominador.TabIndex = 13;
            this.lblResultadoDenominador.Text = "X";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(546, 102);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(67, 13);
            this.lblLinea.TabIndex = 14;
            this.lblLinea.Text = "__________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 282);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblResultadoDenominador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoEntero);
            this.Controls.Add(this.numentero2);
            this.Controls.Add(this.numentero1);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.lblResultadoNumerador);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numentero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numentero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.Label lblResultadoNumerador;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.NumericUpDown numentero1;
        private System.Windows.Forms.NumericUpDown numentero2;
        private System.Windows.Forms.Label lblResultadoEntero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultadoDenominador;
        private System.Windows.Forms.Label lblLinea;
    }
}

