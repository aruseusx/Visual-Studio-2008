using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Devart.Data.MySql;
using System.Windows.Forms;


namespace SharpPrueba2
{
    class Connection2DB
    {

        public static MySqlConnection Conexion()
        {
            // Declaro la conexion al MySQL
            MySqlConnection mySqlConnection1 = new MySqlConnection();
            mySqlConnection1.Host = "C060705";
            mySqlConnection1.Port = 3306;
            mySqlConnection1.UserId = "cristhian.jacinto";
            mySqlConnection1.Password = "mtk12345";
            mySqlConnection1.Open();
            // retorna el objeto de la conexion para ser usador en la lectura de datos
            return mySqlConnection1;
        }

        internal static Boolean Validador(string textBox)
        {
            if ((textBox.Length <= 6))
            {
                string input = textBox;
                int cantidad = input.Length;

                try
                {
                    int result = int.Parse(input);
                    return true;
                }

                catch
                {
                    return false;
                }
            }
            else
            { 
                return false;
            }
        }

        internal static string Completador(Boolean verificado,string textBox)
        {
            if (verificado == true)
            {
                string vari;
                int cantidad = textBox.Length;
                vari = textBox.ToString();

                if (6 - cantidad == 3)
                {
                    vari = vari.Insert(0, "000");
                }
                else if (6 - cantidad == 4)
                {
                    vari = vari.Insert(0, "0000");
                }
                else if (6 - cantidad == 2)
                {
                    vari = vari.Insert(0, "00");
                }
                else if (6 - cantidad == 1)
                {
                    vari = vari.Insert(0, "0");
                }
                MessageBox.Show("Entrada correcta para un activo");
                return vari; ////////////// Retorna el valor de activo corregido
            }
            else if (textBox == "pipo" || textBox == "Pipo")
            {
                MessageBox.Show("Pipo se la come");
                return "";
            }
            else if (textBox == "Cancha" || textBox == "cancha")
            {
                MessageBox.Show("Solo come helado de Chocochip");
                return "";
            }
            else if (textBox == "Jacinto" || textBox == "jacinto")
            {
                MessageBox.Show("Rico o Pobre?");
                return "";
            }
            else
            {
                MessageBox.Show("Tapir 590: Tu que vas a saber de activos PE");
                return ""; //Borra lo escrito en el textBox
            }

        }

        //Solo Unificador puede ser jalado, Validador y Completador son internos de la clase
        public static void Unificador (string textBox,out string completado,out Boolean aprobado)
        {
            Boolean bandera;
            bandera = Connection2DB.Validador(textBox);
            completado = Connection2DB.Completador(bandera,textBox);
            aprobado = bandera;
        }

        //Saco Informacion del activo, de la base de datos dti.activos
        public static string Lectura(MySqlConnection Connection, string completado)
        {
            //Descripcion debe cambiarse por el numero de RFID a futuro
            MessageBox.Show("Tapir 590: Buscando Informacion, mascota");
            string salida = "C000000";
            string intermedio1;
            intermedio1 = "C" + completado;
            string Querys = "SELECT Descripcion FROM dti.activos WHERE Activo=:intermedio";
            MySqlCommand MyCommand = new MySqlCommand(Querys, Connection);
            MySqlParameter MyParam = MyCommand.CreateParameter();
            MyParam.MySqlType = Devart.Data.MySql.MySqlType.Text;
            MyParam.Value = intermedio1;
            MyParam.ParameterName = "intermedio";
            MyCommand.Parameters.Add(MyParam);
            Connection.Open();
            MySqlDataReader myReader = null;
                

            try
            {
                myReader = MyCommand.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Encontrado");
                    salida = myReader.GetString(0);
                    myReader.Close();
                    return salida;
                }
                else
                {
                    MessageBox.Show("Activo no registrado en la base de datos");
                    myReader.Close();
                    return "";
                }         
            }

            catch
            {
                myReader.Close();
                return "No encontrado/Error";
            }

            finally
            {
                myReader.Close();
            }
            
        }

    }
}
