using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NOMBRE_Leave(object sender, EventArgs e)
        {
            NOMBRE.Text = NOMBRE.Text.ToUpper();

        }

        private void PATERNO_Leave(object sender, EventArgs e)
        {
            PATERNO.Text = PATERNO.Text.ToUpper();

        }

        private void MATERNO_Leave(object sender, EventArgs e)
        {
            MATERNO.Text = MATERNO.Text.ToUpper();

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label10.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;         

        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {

            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
            Dato.Text = PATERNO.Text.Substring(0, 1);

            int x;
            for (x = 1; x < PATERNO.Text.Length; x++)
            {
                foreach (char c in vocales)                             
                {
                    if (c.ToString() == PATERNO.Text.Substring(x, 1))   
                    {
                        Dato.Text = Dato.Text + PATERNO.Text.Substring(x, 1);      
                        x = PATERNO.Text.Length + 1;                  
                        break;                                                  
                    }
                }
            }


            String var = CIUDAD.Text;
            int tam_var = var.Length;
            String ciudad = var.Substring((tam_var - 2), 2);

            String p = PATERNO.Text;
            int tp = p.Length;
            String t1 = p.Substring((tp - 4), 1);


            String m = MATERNO.Text;
            int tm = m.Length;
            String t2 = m.Substring((tm - 1), 1);

            String n = NOMBRE.Text;
            int tn = n.Length;
            String t3 = n.Substring((tn - 5), 1);




            label1.Text = t1;

            int n1;
            char l1;

            Random alea = new Random();
            n1 = alea.Next(48, 57);
            l1 = Convert.ToChar(n1);



            if (MASCULINO.Checked == true) {

                Dato.Text = Dato.Text + MATERNO.Text.Substring(0, 1) + NOMBRE.Text.Substring(0, 1);
                Dato.Text = Dato.Text + monthCalendar1.SelectionStart.ToString("yyMMdd") + "H" + ciudad+t1+t2+t3+"0"+ l1;



            } else if (FEMENINO.Checked == true)
            {

                Dato.Text = Dato.Text + MATERNO.Text.Substring(0, 1) + NOMBRE.Text.Substring(0, 1);
                Dato.Text = Dato.Text + monthCalendar1.SelectionStart.ToString("yyMMdd") + "M" + ciudad + t1 + t2 + t3 + "0" + l1;


            }




            Form2 f2 = new Form2();
            f2.CLAVE.Text = Dato.Text;

            f2.Show();
            this.Hide();

        }






        }
    }
    

