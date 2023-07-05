namespace simulacro_de_parcial_1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnresultado = new Button();
            btncancelar = new Button();
            btnsalir = new Button();
            label2 = new Label();
            txtaltura = new TextBox();
            label3 = new Label();
            txtradio = new TextBox();
            label1 = new Label();
            txtgeneratriz = new TextBox();
            SuspendLayout();
            // 
            // btnresultado
            // 
            btnresultado.Location = new Point(205, 142);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(149, 32);
            btnresultado.TabIndex = 4;
            btnresultado.Text = "mostrar resultado";
            btnresultado.UseVisualStyleBackColor = true;
            btnresultado.Click += btnresultado_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(713, 30);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(713, 403);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 56);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 7;
            label2.Text = "ingresa el valor de la altura";
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(205, 53);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 95);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 9;
            label3.Text = "ingrese alor de radio";
            // 
            // txtradio
            // 
            txtradio.Location = new Point(205, 87);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(100, 23);
            txtradio.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 11;
            label1.Text = "ingrese generatriz";
            // 
            // txtgeneratriz
            // 
            txtgeneratriz.Location = new Point(205, 20);
            txtgeneratriz.Name = "txtgeneratriz";
            txtgeneratriz.Size = new Size(100, 23);
            txtgeneratriz.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtgeneratriz);
            Controls.Add(label1);
            Controls.Add(txtradio);
            Controls.Add(label3);
            Controls.Add(txtaltura);
            Controls.Add(label2);
            Controls.Add(btnsalir);
            Controls.Add(btncancelar);
            Controls.Add(btnresultado);
            Name = "Form1";
            Text = "simulacro de parcial form";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnresultado;
        private Button btncancelar;
        private Button btnsalir;
        private Label label2;
        private TextBox txtaltura;
        private Label label3;
        private TextBox txtradio;
        private Label label1;
        private TextBox txtgeneratriz;
    }
}