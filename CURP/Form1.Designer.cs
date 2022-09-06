namespace CURP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.PATERNO = new System.Windows.Forms.TextBox();
            this.MATERNO = new System.Windows.Forms.TextBox();
            this.MASCULINO = new System.Windows.Forms.RadioButton();
            this.FEMENINO = new System.Windows.Forms.RadioButton();
            this.CIUDAD = new System.Windows.Forms.ComboBox();
            this.CONSULTA = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dato = new System.Windows.Forms.Label();
            this.Dato2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURP ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave Única Del Registro Poblacional ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Entidad Federativa: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de Nacimiento: ";
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(149, 84);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(223, 22);
            this.NOMBRE.TabIndex = 8;
            this.NOMBRE.Leave += new System.EventHandler(this.NOMBRE_Leave);
            // 
            // PATERNO
            // 
            this.PATERNO.Location = new System.Drawing.Point(149, 118);
            this.PATERNO.Name = "PATERNO";
            this.PATERNO.Size = new System.Drawing.Size(223, 22);
            this.PATERNO.TabIndex = 9;
            this.PATERNO.Leave += new System.EventHandler(this.PATERNO_Leave);
            // 
            // MATERNO
            // 
            this.MATERNO.Location = new System.Drawing.Point(151, 154);
            this.MATERNO.Name = "MATERNO";
            this.MATERNO.Size = new System.Drawing.Size(223, 22);
            this.MATERNO.TabIndex = 10;
            this.MATERNO.Leave += new System.EventHandler(this.MATERNO_Leave);
            // 
            // MASCULINO
            // 
            this.MASCULINO.AutoSize = true;
            this.MASCULINO.Location = new System.Drawing.Point(151, 187);
            this.MASCULINO.Name = "MASCULINO";
            this.MASCULINO.Size = new System.Drawing.Size(92, 21);
            this.MASCULINO.TabIndex = 11;
            this.MASCULINO.TabStop = true;
            this.MASCULINO.Text = "Masculino";
            this.MASCULINO.UseVisualStyleBackColor = true;
            // 
            // FEMENINO
            // 
            this.FEMENINO.AutoSize = true;
            this.FEMENINO.Location = new System.Drawing.Point(281, 185);
            this.FEMENINO.Name = "FEMENINO";
            this.FEMENINO.Size = new System.Drawing.Size(91, 21);
            this.FEMENINO.TabIndex = 12;
            this.FEMENINO.TabStop = true;
            this.FEMENINO.Text = "Femenino";
            this.FEMENINO.UseVisualStyleBackColor = true;
            // 
            // CIUDAD
            // 
            this.CIUDAD.FormattingEnabled = true;
            this.CIUDAD.Items.AddRange(new object[] {
            "AGUASCALIENTES AS ",
            "BAJA CALIFORNIA BC",
            "BAJA CALIFORNIA SUR BS ",
            "CAMPECHE CC",
            "COAHUILA CL ",
            "COLIMA CM",
            "CHIAPAS CS ",
            "CHIHUAHUA CH",
            "DISTRITO FEDERAL DF",
            " DURANGO DG",
            "GUANAJUATO GT ",
            "GUERRERO GR",
            "HIDALGO HG ",
            "JALISCO JC",
            "MÉXICO MC ",
            "MICHOACÁN MN",
            "MORELOS MS ",
            "NAYARIT NT",
            "NUEVO LEÓN NL",
            "OAXACA OC",
            "PUEBLA PL",
            "QUERÉTARO QT",
            "QUINTANA ROO QR ",
            "SAN LUIS POTOSÍ SP",
            "SINALOA SL ",
            "SONORA SR",
            "TABASCO TC ",
            "TAMAULIPAS TS",
            "TLAXCALA TL ",
            "VERACRUZ VZ",
            "YUCATÁN YN ",
            "ZACATECAS ZS",
            "NACIDO EN EL EXTRANJERO NE"});
            this.CIUDAD.Location = new System.Drawing.Point(151, 218);
            this.CIUDAD.Name = "CIUDAD";
            this.CIUDAD.Size = new System.Drawing.Size(221, 24);
            this.CIUDAD.TabIndex = 13;
            // 
            // CONSULTA
            // 
            this.CONSULTA.Location = new System.Drawing.Point(337, 460);
            this.CONSULTA.Name = "CONSULTA";
            this.CONSULTA.Size = new System.Drawing.Size(91, 36);
            this.CONSULTA.TabIndex = 15;
            this.CONSULTA.Text = "Consulta";
            this.CONSULTA.UseVisualStyleBackColor = true;
            this.CONSULTA.Click += new System.EventHandler(this.CONSULTA_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1, 304);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calendario ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Location = new System.Drawing.Point(318, 331);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(0, 17);
            this.Dato.TabIndex = 20;
            // 
            // Dato2
            // 
            this.Dato2.AutoSize = true;
            this.Dato2.Location = new System.Drawing.Point(353, 396);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(0, 17);
            this.Dato2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 508);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CONSULTA);
            this.Controls.Add(this.CIUDAD);
            this.Controls.Add(this.FEMENINO);
            this.Controls.Add(this.MASCULINO);
            this.Controls.Add(this.MATERNO);
            this.Controls.Add(this.PATERNO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Curp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox PATERNO;
        private System.Windows.Forms.TextBox MATERNO;
        private System.Windows.Forms.RadioButton MASCULINO;
        private System.Windows.Forms.RadioButton FEMENINO;
        private System.Windows.Forms.ComboBox CIUDAD;
        private System.Windows.Forms.Button CONSULTA;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Dato;
        private System.Windows.Forms.Label Dato2;
    }
}

