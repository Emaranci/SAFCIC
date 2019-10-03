using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SAFCIC_V1._0.Clases
{
    class Cliente
    {
        //atributos
        private string Nombre;
        private string Rut;
        private int Telefono;
        private int Edad;
        private string Direccion;
        private int id_cliente;

        // contructores

        BD_coneccion conn = new BD_coneccion();

        public Cliente()
        {
            
        }



        //Metodos
        public void guardarDatos(String Nom2, string rut2, int Tel2, int Edad2, String Dir) // invoca a metodo de la clase BD_conxion que inerta datos en BD
        {
            Nombre = Nom2;
            Rut = rut2;
            Telefono = Tel2;
            Edad = Edad2;
            Direccion = Dir;

            string agregar = "INSERT INTO Cliente VALUES ('" + Rut + "','" + Nombre + "'," + Edad + "," + Telefono + ",'" + Direccion + "')";
            if (conn.insert(agregar))
            {
                MessageBox.Show("Cliente agregado");
            }
            else
            {
                MessageBox.Show("Cliente no agregado");
            }
            

        }
        public int CargarId_cliente(string rut)
        {

            SqlDataReader Llenado;
            string con_String = "SELECT ID_Cliente FROM Cliente  WHERE Rut = " + rut + "";//


            Llenado = BD_coneccion.GetDataReader(con_String);
            // BD_coneccion.GetDataReader(sql);
            Llenado.Read();


            int IdCliente = Convert.ToInt32(Llenado["ID_Cliente"]);
            Llenado.Close();

            return IdCliente;




        }
       
    
    
    
    
    }
        

    }

