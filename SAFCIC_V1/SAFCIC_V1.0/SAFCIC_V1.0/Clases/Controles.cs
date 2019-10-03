using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SAFCIC_V1._0.Clases
{
    class Controles
    {
        private int numero;
        private string fecha;
        private string hora;
        private  string estado;
        Clases.Cliente Cliente_ins = new Clases.Cliente(); // instancia de clase cliente
        Clases.Venta Vensta_ins = new Clases.Venta(); // instancia de clase venta
        BD_coneccion conn = new BD_coneccion();
        Clases.Ficha ficha_ins = new Clases.Ficha();





        public void guardar_control(string fecha2, string hora2)
        {

            numero = 1;
            fecha = fecha2;
            hora = hora2;
            estado = "Pendiente";

            int Idficha = ficha_ins.CargarId_ficha();

            string con_String = "SELECT Numero_control FROM Controles WHERE  IdFicha = " + Idficha + "";//String de conexion para cargar datos en la grilla

            conn.consulta_LLenar_grilla(con_String, "Controles");

           int contador_controles = conn.ds.Tables["Controles"].Rows.Count;

           

           switch (contador_controles)
           {
               case 0:
                   numero = 1;
                   break;


               case 1:
                      numero = 2;
                  
                   break;
               case 2:
                   numero =3;

                   break;
               case 3:
                   numero = 4;
                   break;
               default:
                  
                   break;
           }

           if (numero < 4)
           {
               string agregar = "INSERT INTO Controles VALUES (" + numero + ",'" + fecha + "','" + hora + "','" + estado + "'," + Idficha + ")";
               if (conn.insert(agregar))
               {
                   MessageBox.Show("Control agregado");
               }
               else
               {
                   MessageBox.Show("Control no agregado");
               }
           }
           else
           { MessageBox.Show("Ya se utilizaron todos los controles"); }


        }



        public void Modificar_controles(int numero2, string fecha2, string hora2, string estado2)
        {
            int numero = numero2;
            fecha = fecha2;
            hora = hora2;
            estado = estado2;

            int Idficha = ficha_ins.CargarId_ficha();

            string con_String = "UPDATE Controles Set Numero_control =" +numero+" ,Fecha ='"+fecha+"' ,Hora= '"+hora+"' ,estado= '"+estado+"' WHERE IdFicha ="+Idficha+" and Numero_control = "+numero+ "";

            conn.insert(con_String);
            MessageBox.Show("Datos de control actualizados");
            
        }
       
    }



}
