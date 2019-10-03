using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SAFCIC_V1._0.Clases
{
    class Venta
    {
        // atributos
        private int Id_Venta;
        private String Fecha;
        private String Fecha_Entrega;
        private int Total;
        private int Abono;
        private int Saldo;
        private int Id_cliente;
        private int Id_tipo_L;
        private string rut;
        private int OT;
        private bool estado;
        private int Cajas;


        //constructores 
        BD_coneccion conn = new BD_coneccion();
        Cliente Cliente_ist = new Cliente ();
        // Metodos

        public void guardarDatos(String Fecha2, string Fecha_ent2, int Total2, int Abono2, int Saldo2,string Rut2, int Id_tipo_L2,int OT2, bool estado, int cajas2)
        {
            Fecha=Fecha2;
            Fecha_Entrega=Fecha_ent2;
            Total=Total2;
            Abono = Abono2;
            Saldo = Saldo2;
            Id_cliente = Cliente_ist.CargarId_cliente(Rut2) ;
            Id_tipo_L = Id_tipo_L2;
            OT = OT2;
            int estado2 = 0;
            Cajas = cajas2;


            if (estado == true)
            {
                estado2 = 1;
            }
            else {
                estado2 = 0;
            }
            



            string agregar = "INSERT INTO Venta VALUES ('" + Fecha + "','" + Fecha_Entrega + "'," + Total + "," + Abono + "," + Saldo + "," + Id_cliente + ","+Id_tipo_L +","+OT+","+estado2+",'"+Cajas+"')";
                
            if (conn.insert(agregar))
            {
                MessageBox.Show("Datos de venta agregado");
                BD_coneccion.Close();
            }
            else
            {
                MessageBox.Show("Datos de venta no agregado");
                BD_coneccion.Close();
            }
            
           

        }


        public int CargarId_venta(int id)
        {

            SqlDataReader Llenado;
            string con_String = "SELECT ID_venta FROM venta  WHERE Id_cliente = " + id + "";//


            Llenado = BD_coneccion.GetDataReader(con_String);
            // BD_coneccion.GetDataReader(sql);
            Llenado.Read();


            int Idventa = Convert.ToInt32(Llenado["ID_venta"]);
            Llenado.Close();

            return Idventa;


        }

        public int CargarId_venta_Busqueda(int id,string fecha)
        {

            SqlDataReader Llenado;
            string con_String = "SELECT ID_venta FROM venta  WHERE Id_cliente = " + id + " AND Fecha = '" +fecha+ "'";//


            Llenado = BD_coneccion.GetDataReader(con_String);
            // BD_coneccion.GetDataReader(sql);
            Llenado.Read();


            int Idventa = Convert.ToInt32(Llenado["ID_venta"]);
            Llenado.Close();

            return Idventa;


        }

        //public int CargarId_venta_Busqueda(int id,string Fecha)
        //{

        //    SqlDataReader Llenado;
        //    string con_String = "SELECT Venta.ID_venta FROM Cliente INNER JOIN Venta ON Cliente.ID_cliente = Venta.Id_cliente WHERE (Venta.Id_cliente = "+ id +") AND (Venta.Fecha = "+Fecha +")";//


        //    Llenado = BD_coneccion.GetDataReader(con_String);
        //    // BD_coneccion.GetDataReader(sql);
        //    Llenado.Read();


        //    int Idventa = Convert.ToInt32(Llenado["ID_venta"]);
        //    Llenado.Close();

        //    return Idventa;

        //}
    }
}
