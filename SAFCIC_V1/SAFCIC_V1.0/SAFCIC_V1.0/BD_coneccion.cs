using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SAFCIC_V1._0
{
    class BD_coneccion
    {
        // Objetos de la conexion
        public static SqlConnection conn = new SqlConnection("Data Source=THINKPAD-NTBK\\SQLEXPRESS;Initial Catalog=SAFCIC_BD;Integrated Security=True");
        
        public SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;


        //public void conexion() // abre y cierra conexion
        //{
        //    try
        //    {
        //        conn.Open();
        //        MessageBox.Show("Conecatdo");
        //    }
        //    catch
        //    {
        //         MessageBox.Show("No se pudo conectar");
        //    }
        //    finally
        //    {
        //            conn.Close();
        //    }
        //}

        public void consulta_LLenar_grilla(string sql, string tabla) // Metodo para LLenar grillas, requiere string de conexion y tabla de busqueda
        {

            Open();
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
            Close();

        }


        public bool insert(string sql)// Metodo para insertar datos, requiere string de conexion
        {
            Open();
            comando = new SqlCommand(sql, conn);
            int i = comando.ExecuteNonQuery();
            Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void consulta(string sql, string tabla) // Metodo para buscar
        {
            Open();
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conn); // requiere string de consulta y conexion
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla); // llena el sqladapter con datos
            Close();



        }
        public static DataTable GetDataTable(string sql)
        {
            Open();
            DataTable lDataTable = new DataTable();
            SqlDataAdapter lAdaptador;

            lAdaptador = new SqlDataAdapter(sql, conn);
            lAdaptador.Fill(lDataTable);
            Close();
            

            return lDataTable;
        }
        public static SqlDataReader GetDataReader(string sql)
        {
            Open();
            SqlCommand lCommand;
            SqlDataReader lDataReader;

            lCommand = new SqlCommand(sql, conn);

            lDataReader = lCommand.ExecuteReader();

           
            return lDataReader;
        }
        
        public static void Open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                //MsgBox("Error: " & err.Message, MsgBoxStyle.Critical, "Error")
            }
        }

        public static void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception err)
            {
                //MsgBox("Error: " & err.Message, MsgBoxStyle.Critical, "Error")
            }
        }
        

    }
}
 