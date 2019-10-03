using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAFCIC_V1._0.Forms
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }
        Clases.Temporales Temp_ins = new Clases.Temporales();
        Clases.Ficha Ficha_ins = new Clases.Ficha();
        BD_coneccion conn = new BD_coneccion();
        



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void Ficha_Load(object sender, EventArgs e)
        {
            btn_Conrol.Enabled = false;
            btn_ot.Enabled = false;

            int Id_Venta = Temp_ins.consultaIdVenta();//consulta por el id de venta almacenado en temporales

            if (Id_Venta != 0) // valida que temporales no este vacio
            {
                Cargar_datos(Id_Venta);
                btn_Conrol.Enabled = true;
                btn_ot.Enabled = true;
            }

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            if (txt_Dio_od.Text == "" || txt_Dio_Oi.Text == "" || txt_fab_od.Text == "" || txt_fab_oi.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los campos marcados");
            }
            else
            {
                BD_coneccion.Close();
                int Id_Venta = Temp_ins.consultaIdVenta();

                Ficha_ins.guardarDatos(txt_Dio_od.Text, txt_Dio_Oi.Text, txt_quer_od.Text, txt_quer_oi.Text, txt_fab_od.Text, txt_fab_oi.Text, txt_obs.Text, Id_Venta);

                btn_Conrol.Enabled = true;
                btn_ot.Enabled = true;
            }

        }


        public void Cargar_datos(int ID)
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql = "SELECT Ficha.Id_Ficha, Ficha.Dioptria_OD, Ficha.Dioptria_OI,Ficha.Querato_OD, Ficha.Lente_Fabricar_Oi, Ficha.Lente_Fabricar_OD, Ficha.Querato_OI, dbo.Ficha.observaciones FROM Ficha INNER JOIN Venta ON Ficha.Id_Venta = Venta.ID_venta WHERE Venta.ID_venta= " + ID + "";

            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader

            Llenado.Read(); // esta linea siempre debe ir, ya que esta es como si la inicializara, en los ciclos no es necesario  


            txt_Dio_od.Text = Llenado["Dioptria_OD"].ToString();
            txt_Dio_Oi.Text = Llenado["Dioptria_OI"].ToString();
            txt_quer_od.Text = Llenado["Querato_OD"].ToString();
            txt_quer_oi.Text = Llenado["Querato_OI"].ToString();
            txt_fab_od.Text = Llenado["Lente_fabricar_OD"].ToString();
            txt_fab_oi.Text = Llenado["Lente_fabricar_OI"].ToString();
            txt_obs.Text = Llenado["observaciones"].ToString();





            // se cargara la id de la ficha y se guardara en tabla temporal
            int ID_Ficha = Convert.ToInt32(Llenado["Id_Ficha"]);

            
            Llenado.Close();
            Temp_ins.guardarIDficha(ID_Ficha);
        }

        private void btn_Conrol_Click(object sender, EventArgs e)
        {
            BD_coneccion.Close(); 
             
            if ( Ficha_ins.CargarId_ficha().ToString()== "" )
            {
                MessageBox.Show("Debe guardar los datos de la ficha primero");
                
            }
            else { 

                 Forms.Control control = new Forms.Control();
                control.MdiParent = this.MdiParent;
                control.Show();
            }

            
        }

        private void btn_ot_Click(object sender, EventArgs e)
        {
            Forms.Orden_Trabajo ot = new Forms.Orden_Trabajo();
            ot.MdiParent = this.MdiParent;
            ot.Show();

        }

        private void txt_Dio_od_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 167 || e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void txt_Dio_Oi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 167 || e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
            

        private void txt_fab_od_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 167 || e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
            


        private void txt_fab_oi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 97 || e.KeyChar == 167 || e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
