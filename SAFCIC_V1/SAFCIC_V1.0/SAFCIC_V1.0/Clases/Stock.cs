using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAFCIC_V1._0.Clases
{
    class Stock
    {
        private string fuerza;
        private string color;
        private string marca;
        private string tipo;
        private int valor;
        private int cantidad_color;
        private int cantidad_conv;


        BD_coneccion conexion = new BD_coneccion();


        public void guardar_datos_conv_mas(string fuerza2, string marca2, int cantidad)// valida y guarda nuevo valor el lente convencional al agregar
        { 
             fuerza = fuerza2;
             marca = marca2;
             cantidad_conv = cantidad;

             SqlDataReader Llenado;
             string con_string1 = " SELECT stock FROM Lentes_desechables_conv WHERE Fuerza = '" + fuerza + "' and marca = '" + marca + "'";

            Llenado = BD_coneccion.GetDataReader(con_string1);

            Llenado.Read();

            int cant_ant = Convert.ToInt32 (Llenado["stock"]);
             Llenado.Close();


            int nueva_cant = cant_ant + cantidad_conv;
           
                string con_string_update = "UPDATE Lentes_desechables_conv SET stock = " + nueva_cant + " WHERE Fuerza = '" + fuerza + "' and marca = '" + marca + "'";
                conexion.insert(con_string_update);

               

        }

        public void guardar_datos_conv_menos(string fuerza2, string marca2, int cantidad)// valida y guarda nuevo valor el lente convencional al eliminar
        {
            fuerza = fuerza2;
            marca = marca2;
            cantidad_conv = cantidad;

            SqlDataReader Llenado;
            string con_string1 = " SELECT stock FROM Lentes_desechables_conv WHERE Fuerza = '" + fuerza + "' and marca = '" + marca + "'";

            Llenado = BD_coneccion.GetDataReader(con_string1);

            Llenado.Read();

            int cant_ant = Convert.ToInt32(Llenado["stock"]);
            Llenado.Close();

            int nueva_cant = cant_ant - cantidad_conv;
            if (nueva_cant >= 0)
            {
                string con_string_update = "UPDATE Lentes_desechables_conv SET stock = " + nueva_cant + " WHERE Fuerza = '" + fuerza + "' and marca = '" + marca + "'";
                conexion.insert(con_string_update);
                MessageBox .Show ("stock eliminado");
            }
            else 
            {
                MessageBox.Show("mo se puede realizar la operacion ya que el valor no es valido o el stock de lentes no puede ser menor a 0, le recomndamos revisar el stock del producto");
            }

        }

        public void guardar_datos_color_mas(string color2, string tipo2, int cantidad)// valida y guarda nuevo valor el lente color al agregar
        {
            color = color2;
            tipo = tipo2;
            cantidad_conv = cantidad;

            SqlDataReader Llenado;
            string con_string1 = " SELECT stock FROM Lentes_desechables_color WHERE Color = '" + color + "' and tipo = '" + tipo + "'";

            Llenado = BD_coneccion.GetDataReader(con_string1);

            Llenado.Read();

            int cant_ant = Convert.ToInt32(Llenado["stock"]);
            Llenado.Close();


            int nueva_cant = cant_ant + cantidad_conv;

            string con_string_update = "UPDATE Lentes_desechables_Color SET stock = " + nueva_cant + " WHERE Color = '" + color + "' and tipo = '" + tipo + "'";
            conexion.insert(con_string_update);



        }

        public void guardar_datos_color_menos(string color2, string tipo2, int cantidad)// valida y guarda nuevo valor el lente color al eliminar
        {
            color = color2;
            tipo = tipo2;
            cantidad_color = cantidad;

            SqlDataReader Llenado;
            string con_string1 = " SELECT stock FROM Lentes_desechables_color WHERE Color = '" + color + "' and tipo = '" + tipo + "'";

            Llenado = BD_coneccion.GetDataReader(con_string1);

            Llenado.Read();

            int cant_ant = Convert.ToInt32(Llenado["stock"]);
            Llenado.Close();


            int nueva_cant = cant_ant - cantidad_color;

            string con_string_update = "UPDATE Lentes_desechables_Color SET stock = " + nueva_cant + " WHERE Color = '" + color + "' and tipo = '" + tipo + "'";
            conexion.insert(con_string_update);



        }


        public void guardar_datos_nuevo_color(string color2,int cantidad,string marca2, int valor2, string tipo2 )// valida y guarda nuevo producto lente de color
        {
            color = color2;
            cantidad_color = cantidad;
            marca = marca2;
            valor = valor2;
            tipo = tipo2;
          

           string con_string_update = "INSERT INTO Lentes_desechables_Color VALUES( '" + color +  "' ," +cantidad+ " ,'" + marca + "',"+valor+",'"+tipo+"')";
            conexion.insert(con_string_update);

        }


        public void guardar_datos_nuevo_conv(string fuerza2, int cantidad, string marca2, int valor2)// valida y guarda nuevo producto lente convencional
        {
            fuerza = fuerza2;
            cantidad_color = cantidad;
            marca = marca2;
            valor = valor2;
            


            string con_string_update = "INSERT INTO Lentes_desechables_conv VALUES( '" + fuerza + "' ," + cantidad + " ,'" + marca + "'," + valor + ")";
            conexion.insert(con_string_update);

        }
    }
}
