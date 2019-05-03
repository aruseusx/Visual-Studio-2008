using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text; /////////////////////////////
using System.Windows.Forms;
using Devart.Data.MySql;
using SharpPrueba2;

 
namespace SharpPrueba2
{

    public partial class Form1 : Form
    {
        // Variables Globales // Declaro los parametros de la conexion a la base de datos
        MySqlConnection Conectado; 
        string Escrito="";
        string Completado="";
        Boolean Aprobado=false;

        //Conexion a la base de datos
        public Form1()
        {
            // Se conecta a la base de datos apenas inicializa
            InitializeComponent();
            Conectado = Connection2DB.Conexion();
            MessageBox.Show("Tapir 590: Conectado a la base de datos Mascota");       
        }

        // El metodo Unificador listo para ser llamado en otros eventos con "Unificado(null,null);"
        private void Unificado(object sender, EventArgs e)
        {
            Escrito = textBox1.Text;
            textBox2.Text = "";
            Connection2DB.Unificador(Escrito, out Completado, out Aprobado);
            textBox1.Text = Completado;
            if (Aprobado == true)
            {
                textBox2.Text = Connection2DB.Lectura(Conectado, Completado);
            }
            
        }

        //Aca funciona presionando enter la busqueda, activa la bandera de buscado
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Unificado(null, null);
            }
        }

        // Aca busca al presionar el boton buscar, activa la bandera de buscado
        private void button1_Click(object sender, EventArgs e)
        {
            Unificado(null, null);
        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            Conectado.Close();
            Form0 myForm = new Form0();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        } 

        private void label1_ParentChanged_2(object sender, EventArgs e)
        {
            /*
            if (textBox3.Text != textBox2.Text)
            {
                label1.Text = "NO ENCONTRADO";
                label1.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(textBox3.Text)) 
            {
                label1.Text = "Esperando activo";
                label1.ForeColor = Color.DodgerBlue;
            }
            else if (textBox3.Text == textBox2.Text)
            {
                label1.Text = "ENCONTRADO";
                label1.ForeColor = Color.Green;
            }
             
             */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged_1(object sender, EventArgs e)
        {

        }

        private void Activo_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Distancia_Radial_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFID_Asociado_ParentChanged(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}