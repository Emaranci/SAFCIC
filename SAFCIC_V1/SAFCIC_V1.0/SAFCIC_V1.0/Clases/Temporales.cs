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
    class Temporales
    {
        //atributos
        public int Id_cliente;
        public int Id_venta;
        public int Id_ficha;


        BD_coneccion conn = new BD_coneccion();

        //metodos
        public int consultaIdCliente()
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql="SELECT Id_Cliente from temp";
            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader
            Llenado.Read();
            int IDcliente = Convert.ToInt32 ( Llenado["Id_cliente"]);
            Llenado.Close();
            return IDcliente;
            

      }         

        public int consultaIdVenta()
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql = "SELECT Id_Venta from temp";
            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader
            Llenado.Read();
            int IDventa = Convert.ToInt32(Llenado["Id_Venta"]);
            Llenado.Close();
            return IDventa;
            
        }


        public int consultaIdFicha()
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql = "SELECT Id_Ficha from temp";
            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader
            Llenado.Read();
            int IDficha = Convert.ToInt32(Llenado["Id_ficha"]);
            Llenado.Close();
            return IDficha;
            
        }



        public void guardarIDcliente(int Idcliente) // invoca a metodo de la clase BD_conxion que inerta datos en BD
        {
           
            int  Id_cliente= Idcliente ;
            string agregar = "UPDATE Temp SET Id_Cliente = " + Id_cliente + " WHERE Id_Cliente = 0";
            conn.insert(agregar);
            BD_coneccion.Close();

        }

        public void guardarIDventa(int Idventa) // invoca a metodo de la clase BD_conxion que inerta datos en BD
        {

            int Id_venta = Idventa;
            string agregar = "UPDATE Temp SET Id_venta ="+Id_venta+" WHERE Id_venta = 0";
            conn.insert(agregar);
            BD_coneccion.Close();
            

        }

        public void guardarIDficha(int Idficha) // invoca a metodo de la clase BD_conxion que inerta datos en BD
        {

            //int Id_ficha = Idficha;
            string agregar = "UPDATE Temp SET Id_Ficha = "+Idficha+" WHERE Id_Ficha = 0";
            conn.insert(agregar);


        }

        public void Limpiar_temp() // limpia los registros almacenado y deja en 0 todos los campos para que sean almacenados nuevos registros de Id al momento de buscar
        {

            BD_coneccion.Close();
            string agregar = "UPDATE Temp SET Id_cliente = 0,Id_Ficha=0, Id_Venta=0, Fecha= '0' WHERE Id_Cliente > 0";
            conn.insert(agregar);
            

        }

        public void guardarfecha(string fecha) // invoca a metodo de la clase BD_conxion que inerta datos en BD
        {

            
            string agregar = "UPDATE Temp SET Fecha = '" + fecha + "' WHERE Fecha = 0";
            conn.insert(agregar);
            BD_coneccion.Close();

        }

        public string consultaFecha()
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql = "SELECT Fecha from temp";
            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader
            Llenado.Read();
            string Fecha = Llenado["Fecha"].ToString ();
            Llenado.Close();
            return Fecha;

        }
    
    
    } 
}
