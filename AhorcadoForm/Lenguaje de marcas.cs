using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AhorcadoForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string seleccionada = "";
        private char letra;
        private string s = "";
        private char[] c;
        private string ss;
        private int tamaño = 0;
        private int contador = 5;
        private bool letraEncontrada = false;

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;//esta imagen va a true porque empieza por aquí

            label4.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            letraEncontrada = false;
            label2.Visible = true;
            label3.Visible = true;

            contador = 6;//numero de oportunidades
            label3.Text = contador.ToString();

            ss = "";
            s = "";
            textBox1.Focus();
            string[] lista = { "Etiqueta", "elemento", "atributo", "seccion", "validacion", "cuerpo ", "cabecera", "formato", "selectores", "comentario", "agregadores", "creadores", "marca", "bloque", "linea", "css", "pseudoclases", "ocurrencias", "valores", "html" };
            Random azar = new Random();
            int x = azar.Next(0, lista.Length);
            //seleccion de una palabra de la lista
            seleccionada = lista[x];
            tamaño = seleccionada.Length;
            c = new char[tamaño + tamaño - 1];
            //for para para saber que tamaño tiene la palabra seleccionada recorre una a una las letras
            for (int i = 0; i < tamaño; i++)
            {
                s = s + (char.ToUpper(seleccionada[i])); //la palabra seleccionada se guarda en la variable s y la primera letra de la palabra seleccionada se convierte a mayúscula
            }
            for (int i = 0; i < tamaño + tamaño - 3; i++)
            {
                c[i] = '_';
                c[i + 1] = ' ';
                i++;
            }
            //para saber cuantos espacios coge la palabra completa
            for (int k = 0; k < seleccionada.Length; k++)
            {

                if (seleccionada[k] == ' ')
                {
                    c[k + k] = ' ';
                }
            }
            c[0] = s[0];
            c[c.Length - 1] = s[s.Length - 1];
            //Para colocar la primera letra de la palabra como pista recorrer cada posicion de la palabra es decir cada letra y colocar la ultima letra de la palabra como pista también
            for (int i = 0; i < (tamaño + tamaño - 1); i++)
            {
                ss = ss + c[i];
            }
            label4.Text = ss;

        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            letraEncontrada = false;
            //Si la letra introducida no es correcta y se da intro  se sale y se vuelve a introducir otra letra
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "" && textBox1.Text != " ")
                {
                    letra = char.Parse(textBox1.Text);
                    letra = (Char.ToUpper(letra));
                    //MessageBox.Show(letra.ToString());
                    //MessageBox.Show(s); //Enseñar palabra oculta
                    textBox1.Text = "";
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == letra)
                        {
                            letraEncontrada = true;
                            int q = 0;
                            for (int j = 0; j < s.Length; j++)
                            {
                                if (s[j] == letra)
                                {
                                    c[q] = s[j];
                                }
                                q += 2;
                            }
                            ss = "";
                            for (int k = 0; k < (tamaño + tamaño - 1); k++)
                            {
                                ss = ss + c[k];
                            }
                            label4.Text = ss;
                        }
                    }
                    if (letraEncontrada == false)
                    {
                        contador--;
                        label3.Text = contador.ToString();
                        if (contador == 5) { pictureBox1.Visible = false; pictureBox2.Visible = true; }
                        if (contador == 4) { pictureBox2.Visible = false; pictureBox3.Visible = true; }
                        if (contador == 3) { pictureBox3.Visible = false; pictureBox4.Visible = true; }
                        if (contador == 2) { pictureBox4.Visible = false; pictureBox5.Visible = true; }
                        if (contador == 1) { pictureBox5.Visible = false; pictureBox6.Visible = true; }
                        if (contador == 0) { pictureBox6.Visible = false; pictureBox7.Visible = true; }
                        letraEncontrada = false;
                    }
                    if (contador == 0)
                    {
                        MessageBox.Show("Lo siento\n\nHAS PERDIDO");
                        label4.Visible = false;
                        textBox1.Visible = false;
                        button1.Visible = true;
                        button2.Visible = true;
                        label3.Visible = false;
                        label2.Visible = false;
                        label1.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox1.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("No ha introducido nada");
                }


                //Comprobar si la frase se ha completado
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == '_')
                    {
                        break;
                    }
                    if (i == c.Length - 1)
                    {
                        MessageBox.Show("HA GANADO EL JUEGO\n¡¡¡FELICIDADES!!!");
                        label4.Visible = false;
                        textBox1.Visible = false;
                        button1.Visible = true;
                        button2.Visible = true;
                        label3.Visible = false;
                        label2.Visible = false;
                        label1.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox4.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox1.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form3_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1(); // creamos el objeto formulario
            principal.Visible = true;//Lo hacemos visible para que aparezca
            Close();//Cerramos esta ventana
        }
    }
}
