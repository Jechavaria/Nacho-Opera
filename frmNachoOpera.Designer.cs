using System;

namespace Nacho_Opera
{
    partial class frmNachoOpera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNachoOpera));
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.gbNumeros = new System.Windows.Forms.GroupBox();
            this.btnComa = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblPrimerNumero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.lblValorResultado = new System.Windows.Forms.Label();
            this.txtSegundoNúmero = new System.Windows.Forms.TextBox();
            this.txtPrimerNúmero = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.pbCheemsFuerte = new System.Windows.Forms.PictureBox();
            this.pbCheemsSegundoNumero = new System.Windows.Forms.PictureBox();
            this.pbCheemsPrimerNumero = new System.Windows.Forms.PictureBox();
            this.gbNumeros.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsFuerte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsSegundoNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsPrimerNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(6, 15);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(126, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 80);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(241, 15);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 80);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // gbNumeros
            // 
            this.gbNumeros.Controls.Add(this.btnComa);
            this.gbNumeros.Controls.Add(this.Btn0);
            this.gbNumeros.Controls.Add(this.btn2);
            this.gbNumeros.Controls.Add(this.btn6);
            this.gbNumeros.Controls.Add(this.btn8);
            this.gbNumeros.Controls.Add(this.btn5);
            this.gbNumeros.Controls.Add(this.btn3);
            this.gbNumeros.Controls.Add(this.btn1);
            this.gbNumeros.Controls.Add(this.btn4);
            this.gbNumeros.Controls.Add(this.btn9);
            this.gbNumeros.Controls.Add(this.btn7);
            this.gbNumeros.Location = new System.Drawing.Point(12, 194);
            this.gbNumeros.Name = "gbNumeros";
            this.gbNumeros.Size = new System.Drawing.Size(327, 437);
            this.gbNumeros.TabIndex = 1;
            this.gbNumeros.TabStop = false;
            // 
            // btnComa
            // 
            this.btnComa.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(241, 315);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(80, 80);
            this.btnComa.TabIndex = 1;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(6, 315);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(200, 80);
            this.Btn0.TabIndex = 0;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(126, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 80);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(241, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 80);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(126, 15);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 80);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(241, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 80);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(6, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 80);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(6, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 80);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnBorrar);
            this.gbOperaciones.Controls.Add(this.btnResultado);
            this.gbOperaciones.Controls.Add(this.btnDividir);
            this.gbOperaciones.Controls.Add(this.btnMultiplicar);
            this.gbOperaciones.Controls.Add(this.btnRestar);
            this.gbOperaciones.Controls.Add(this.btnSumar);
            this.gbOperaciones.Location = new System.Drawing.Point(356, 194);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(137, 437);
            this.gbOperaciones.TabIndex = 2;
            this.gbOperaciones.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(6, 15);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(125, 50);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "⌫";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(6, 295);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(125, 100);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(6, 239);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(125, 50);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(6, 183);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(125, 50);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "×";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(6, 127);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(125, 50);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(6, 71);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(125, 50);
            this.btnSumar.TabIndex = 1;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblPrimerNumero
            // 
            this.lblPrimerNumero.AutoSize = true;
            this.lblPrimerNumero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNumero.Location = new System.Drawing.Point(6, 23);
            this.lblPrimerNumero.Name = "lblPrimerNumero";
            this.lblPrimerNumero.Size = new System.Drawing.Size(129, 23);
            this.lblPrimerNumero.TabIndex = 0;
            this.lblPrimerNumero.Text = "Primer número:";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(6, 87);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(147, 23);
            this.lblSegundoNumero.TabIndex = 1;
            this.lblSegundoNumero.Text = "Segundo número:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(6, 146);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 23);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // gbDisplay
            // 
            this.gbDisplay.Controls.Add(this.pbCheemsFuerte);
            this.gbDisplay.Controls.Add(this.pbCheemsSegundoNumero);
            this.gbDisplay.Controls.Add(this.pbCheemsPrimerNumero);
            this.gbDisplay.Controls.Add(this.lblOperacion);
            this.gbDisplay.Controls.Add(this.lblValorResultado);
            this.gbDisplay.Controls.Add(this.txtSegundoNúmero);
            this.gbDisplay.Controls.Add(this.txtPrimerNúmero);
            this.gbDisplay.Controls.Add(this.lblPrimerNumero);
            this.gbDisplay.Controls.Add(this.lblResultado);
            this.gbDisplay.Controls.Add(this.lblSegundoNumero);
            this.gbDisplay.Location = new System.Drawing.Point(12, 4);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(481, 184);
            this.gbDisplay.TabIndex = 0;
            this.gbDisplay.TabStop = false;
            // 
            // lblValorResultado
            // 
            this.lblValorResultado.AutoSize = true;
            this.lblValorResultado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorResultado.Location = new System.Drawing.Point(221, 134);
            this.lblValorResultado.Name = "lblValorResultado";
            this.lblValorResultado.Size = new System.Drawing.Size(0, 38);
            this.lblValorResultado.TabIndex = 3;
            // 
            // txtSegundoNúmero
            // 
            this.txtSegundoNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNúmero.Location = new System.Drawing.Point(228, 86);
            this.txtSegundoNúmero.Name = "txtSegundoNúmero";
            this.txtSegundoNúmero.Size = new System.Drawing.Size(235, 30);
            this.txtSegundoNúmero.TabIndex = 1;
            // 
            // txtPrimerNúmero
            // 
            this.txtPrimerNúmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNúmero.Location = new System.Drawing.Point(228, 26);
            this.txtPrimerNúmero.Name = "txtPrimerNúmero";
            this.txtPrimerNúmero.Size = new System.Drawing.Size(235, 30);
            this.txtPrimerNúmero.TabIndex = 0;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(248, 59);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 29);
            this.lblOperacion.TabIndex = 4;
            // 
            // pbCheemsFuerte
            // 
            this.pbCheemsFuerte.Image = global::Nacho_Opera.Properties.Resources.Cheems_fuerte_mediano;
            this.pbCheemsFuerte.Location = new System.Drawing.Point(132, 113);
            this.pbCheemsFuerte.Name = "pbCheemsFuerte";
            this.pbCheemsFuerte.Size = new System.Drawing.Size(89, 70);
            this.pbCheemsFuerte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheemsFuerte.TabIndex = 7;
            this.pbCheemsFuerte.TabStop = false;
            this.pbCheemsFuerte.Visible = false;
            // 
            // pbCheemsSegundoNumero
            // 
            this.pbCheemsSegundoNumero.Image = global::Nacho_Opera.Properties.Resources.Cheemsito_pequeño;
            this.pbCheemsSegundoNumero.Location = new System.Drawing.Point(176, 75);
            this.pbCheemsSegundoNumero.Name = "pbCheemsSegundoNumero";
            this.pbCheemsSegundoNumero.Size = new System.Drawing.Size(45, 37);
            this.pbCheemsSegundoNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheemsSegundoNumero.TabIndex = 6;
            this.pbCheemsSegundoNumero.TabStop = false;
            this.pbCheemsSegundoNumero.Visible = false;
            // 
            // pbCheemsPrimerNumero
            // 
            this.pbCheemsPrimerNumero.Image = global::Nacho_Opera.Properties.Resources.Cheemsito_pequeño;
            this.pbCheemsPrimerNumero.Location = new System.Drawing.Point(176, 19);
            this.pbCheemsPrimerNumero.Name = "pbCheemsPrimerNumero";
            this.pbCheemsPrimerNumero.Size = new System.Drawing.Size(45, 37);
            this.pbCheemsPrimerNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheemsPrimerNumero.TabIndex = 5;
            this.pbCheemsPrimerNumero.TabStop = false;
            this.pbCheemsPrimerNumero.Visible = false;
            // 
            // frmNachoOpera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 640);
            this.Controls.Add(this.gbDisplay);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbNumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNachoOpera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nacho suma";
            this.gbNumeros.ResumeLayout(false);
            this.gbOperaciones.ResumeLayout(false);
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsFuerte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsSegundoNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheemsPrimerNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.GroupBox gbNumeros;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblPrimerNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Label lblValorResultado;
        private System.Windows.Forms.TextBox txtSegundoNúmero;
        private System.Windows.Forms.TextBox txtPrimerNúmero;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.PictureBox pbCheemsPrimerNumero;
        private System.Windows.Forms.PictureBox pbCheemsSegundoNumero;
        private System.Windows.Forms.PictureBox pbCheemsFuerte;
    }
}

