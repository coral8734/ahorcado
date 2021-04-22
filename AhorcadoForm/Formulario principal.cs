using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IniciarJuego();

            
        }

        private void IniciarJuego()
        {
            string tema = "";

            if (radioButton1.Checked == true)
            {
                tema = radioButton1.Text;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

                Programación ventana2 = new Programación();//para enlazar una ventana con otra
                ventana2.Show();//para que se muestre la venta

            }
            else if (radioButton2.Checked == true)
            {
                tema = radioButton2.Text;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

                Form3 ventana3 = new Form3();
                ventana3.Show();

            }

            else if (radioButton3.Checked == true)
            {
                tema = radioButton3.Text;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

                Form4 ventana4 = new Form4();
                ventana4.Show();


            }
            else if (radioButton4.Checked == true)
            {
                tema = radioButton4.Text;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton5.Enabled = false;

                Form5 ventana5 = new Form5();
                ventana5.Show();

            }
            else if (radioButton5.Checked == true)
            {
                tema = radioButton5.Text;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;

                Form6 ventana6 = new Form6();
                ventana6.Show();
            }
            else
            {
                MessageBox.Show(" ***Error*** No ha escogido ninguna opción, elija una opción");
            }

            button1.Visible = false;
        }

        
    }
}
