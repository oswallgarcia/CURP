﻿namespace CURP
{
    partial class Form2
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
            this.CLAVE = new System.Windows.Forms.TextBox();
            this.ATRAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURP";
            // 
            // CLAVE
            // 
            this.CLAVE.Location = new System.Drawing.Point(75, 39);
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.Size = new System.Drawing.Size(212, 22);
            this.CLAVE.TabIndex = 1;
            // 
            // ATRAS
            // 
            this.ATRAS.Location = new System.Drawing.Point(12, 96);
            this.ATRAS.Name = "ATRAS";
            this.ATRAS.Size = new System.Drawing.Size(75, 23);
            this.ATRAS.TabIndex = 2;
            this.ATRAS.Text = "atrás ";
            this.ATRAS.UseVisualStyleBackColor = true;
            this.ATRAS.Click += new System.EventHandler(this.ATRAS_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 131);
            this.Controls.Add(this.ATRAS);
            this.Controls.Add(this.CLAVE);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ATRAS;
        public System.Windows.Forms.TextBox CLAVE;
    }
}