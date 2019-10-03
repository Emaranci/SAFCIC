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
    class Ficha
    {
        int ID_Ficha;
        string Dioptria_od;
        string Dioptria_oi;
        string Querato_od;
        string Querato_oi;
        string Lente_fabricar_od;
        string Lente_fabricar_oi;
        string Observaciones;
        int ID_Venta;

        BD_coneccion conn = new BD_coneccion();
        Clases.Temporales Temp_ins = new Clases.Temporales();

        public void guardarDatos(string diop_Od, string diop_OI, string quera_Od, string quera_OI, string fabricar_OD, string fabricar_OI, string Obs, int IDventa)
        {
            Dioptria_od = diop_Od;
            Dioptria_oi = diop_OI;
            Querato_od = quera_Od;
            Querato_oi = quera_OI;
            Lente_fabricar_od = fabricar_OD;
            Lente_fabricar_oi = fabricar_OI;
            Observaciones = Obs;
            ID_Venta = IDventa;


            string agregar = "INSERT INTO Ficha VALUES ('" + Dioptria_od + "','" + Dioptria_oi + "','" + Querato_od + "','" + Querato_oi + "','" + Lente_fabricar_od + "','" + Lente_fabricar_oi + "','" + Observaciones + "'," + ID_Venta + ")";

            if (conn.insert(agregar))
            {
                MessageBox.Show("Datos de ficha agregado");
            }
            else
            {
                MessageBox.Show("Datos de ficha no agregado");
            }


        }

         public int CargarId_ficha()
        {

            int id = Temp_ins.consultaIdVenta();

            SqlDataReader Llenado;
            string con_String = "SELECT Id_Ficha FROM Ficha  WHERE Id_venta = " + id + "";//


            Llenado = BD_coneccion.GetDataReader(con_String);
            // BD_coneccion.GetDataReader(sql);
            Llenado.Read();

            if (Convert.ToInt32 (Llenado["Id_Ficha"])  == 0)
            {
                MessageBox.Show("Debe guardar datos de ficha antes");
            }
           


            int Idficha = Convert.ToInt32(Llenado["Id_Ficha"]);

            Llenado.Close();

            return Idficha;




        }
           


        }
    }

