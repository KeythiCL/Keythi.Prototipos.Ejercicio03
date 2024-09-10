namespace Keythi.Prototipos.Ejercicio03.DatosDeUnaDireccion
{
    partial class DatosDeUnaDireccionForm
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
            TxtNumero = new TextBox();
            TxtPiso = new TextBox();
            TxtCalle = new TextBox();
            TxtDepartamento = new TextBox();
            ListPais = new ListBox();
            ListProvincia = new ListBox();
            ListLocalidad = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            BotonAceptar = new Button();
            SuspendLayout();
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(611, 55);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(125, 27);
            TxtNumero.TabIndex = 0;
            // 
            // TxtPiso
            // 
            TxtPiso.Location = new Point(742, 55);
            TxtPiso.Name = "TxtPiso";
            TxtPiso.Size = new Size(125, 27);
            TxtPiso.TabIndex = 1;
            // 
            // TxtCalle
            // 
            TxtCalle.Location = new Point(480, 55);
            TxtCalle.Name = "TxtCalle";
            TxtCalle.Size = new Size(125, 27);
            TxtCalle.TabIndex = 2;
            // 
            // TxtDepartamento
            // 
            TxtDepartamento.Location = new Point(873, 55);
            TxtDepartamento.Name = "TxtDepartamento";
            TxtDepartamento.Size = new Size(125, 27);
            TxtDepartamento.TabIndex = 3;
            // 
            // ListPais
            // 
            ListPais.FormattingEnabled = true;
            ListPais.Location = new Point(12, 55);
            ListPais.Name = "ListPais";
            ListPais.Size = new Size(150, 104);
            ListPais.TabIndex = 4;
            // 
            // ListProvincia
            // 
            ListProvincia.FormattingEnabled = true;
            ListProvincia.Location = new Point(168, 55);
            ListProvincia.Name = "ListProvincia";
            ListProvincia.Size = new Size(150, 104);
            ListProvincia.TabIndex = 5;
            // 
            // ListLocalidad
            // 
            ListLocalidad.FormattingEnabled = true;
            ListLocalidad.Location = new Point(324, 55);
            ListLocalidad.Name = "ListLocalidad";
            ListLocalidad.Size = new Size(150, 104);
            ListLocalidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 7;
            label1.Text = "Pais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 32);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Provincia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 32);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 32);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 10;
            label4.Text = "Calle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 32);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 11;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(742, 32);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 12;
            label6.Text = "Piso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(873, 32);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 13;
            label7.Text = "Departamento";
            // 
            // BotonAceptar
            // 
            BotonAceptar.Location = new Point(885, 130);
            BotonAceptar.Name = "BotonAceptar";
            BotonAceptar.Size = new Size(94, 29);
            BotonAceptar.TabIndex = 14;
            BotonAceptar.Text = "Aceptar";
            BotonAceptar.UseVisualStyleBackColor = true;
            BotonAceptar.Click += BotonAceptar_Click;
            // 
            // DatosDeUnaDireccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 195);
            Controls.Add(BotonAceptar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListLocalidad);
            Controls.Add(ListProvincia);
            Controls.Add(ListPais);
            Controls.Add(TxtDepartamento);
            Controls.Add(TxtCalle);
            Controls.Add(TxtPiso);
            Controls.Add(TxtNumero);
            Name = "DatosDeUnaDireccionForm";
            Text = "DatosDeUnaDireccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNumero;
        private TextBox TxtPiso;
        private TextBox TxtCalle;
        private TextBox TxtDepartamento;
        private ListBox ListPais;
        private ListBox ListProvincia;
        private ListBox ListLocalidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button BotonAceptar;
    }
}