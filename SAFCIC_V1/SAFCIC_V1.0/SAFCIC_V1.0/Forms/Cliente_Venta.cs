using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SAFCIC_V1._0.Forms
{
    public partial class Cliente_Venta : Form
    {

        BD_coneccion conn = new BD_coneccion();


        public Cliente_Venta()
        {
            InitializeComponent();

        }
        Clases.Cliente Cliente_ins = new Clases.Cliente(); // instancia de clase cliente
        Clases.Venta Venta_ins = new Clases.Venta(); // instancia de clase venta
        Clases.Temporales Temp_ins = new Clases.Temporales();


        private void Cliente_Venta_Load(object sender, EventArgs e)
        {


          //  // TODO: esta línea de código carga datos en la tabla 'sAFCIC_BDDataSet2.Tipo_Lente' Puede moverla o quitarla según sea necesario.
           this.tipo_LenteTableAdapter1.Fill(this.sAFCIC_BDDataSet2.Tipo_Lente);
          txt_Fecha.Text = DateTime.Now.ToShortDateString();
          txtTipo.Visible = false;
          label15.Visible = false;

            int id_cliente = Temp_ins.consultaIdCliente ();
            string fecha_temp = Temp_ins .consultaFecha ();
           int Id = Venta_ins.CargarId_venta_Busqueda(id_cliente, fecha_temp);



           if (Id != 0)
           {
               Cargar_datos(Id);
               txt_nom.ReadOnly = true;
               txt_rut.ReadOnly = true;
               txt_OT.ReadOnly = true;
               btn_guardar.Enabled = false;

           }//else
            
           //{ 
           //    this.tipo_LenteTableAdapter1.Fill(this.sAFCIC_BDDataSet2.Tipo_Lente);
           //    txt_Fecha.Text = DateTime.Now.ToShortDateString(); 
           //}

          
           



        }

        private void btn_guardar_Click(object sender, EventArgs e)// al presionar boton, guarda datos de nueva venta
        {

            if (txt_rut.Text == "" || txt_nom.Text == "" ||txt_Fecha .Text == "" || txt_fecha_entrega .Text == "" || txt_abono .Text =="" || txt_total.Text == "" )
            {
               MessageBox.Show("Debe ingresar los datos marcados con asterisco");

            }
            else 
            {
                Cliente_ins.guardarDatos(txt_nom.Text, txt_rut.Text, Convert.ToInt32(txt_tel.Text), Convert.ToInt32(txt_Edad.Text), txt_dir.Text); 

     int tipo_l = Convert.ToInt32(Combo_Tipo.SelectedIndex.ToString()); // convierte tipode lente en valor para agregarlo a la base de dtos



            Venta_ins.guardarDatos(txt_Fecha.Text, txt_fecha_entrega.Text, Convert.ToInt32(txt_total.Text), Convert.ToInt32(txt_abono.Text), Convert.ToInt32(txt_saldo.Text), txt_rut.Text, tipo_l, Convert.ToInt32(txt_OT.Text), chk_estado.Checked, Convert.ToInt32(txt_cajas.Text));


            // llenado de temporales
            int idcliente = Cliente_ins.CargarId_cliente(txt_rut.Text);
            Temp_ins.guardarIDcliente(idcliente);
            int idventa = Venta_ins.CargarId_venta(idcliente);
            Temp_ins.guardarIDventa(idventa);

            Temp_ins.guardarfecha(txt_Fecha.Text);
        }
            }

       
        public void Cargar_datos(int ID) // cargara datos de venta y cliente
        {
            SqlDataReader Llenado; //instancia de DataBindings reader
            string sql = "SELECT Cliente.Rut,Cliente.Nombre,Cliente.Edad,Cliente.Telefono,Cliente.Direccion,Venta.Fecha,Venta.Total,Venta.Fecha_Entrega,Venta.Abono,Venta.saldo,Venta.Id_cliente,Venta.Nro_OT,Venta.Estado, Venta.Cajas,Venta.ID_venta,Tipo_Lente.Descripcion FROM Cliente INNER JOIN Venta ON Cliente.ID_cliente = Venta.Id_cliente INNER JOIN Tipo_Lente ON Venta.Id_Tipo_l = Tipo_Lente.Id_Tipo WHERE Venta.ID_Venta = " + ID + "";

            Llenado = BD_coneccion.GetDataReader(sql); //Llenado de datatable con Datareader

            Llenado.Read(); // esta linea siempre debe ir, ya que esta es como si la inicializara, en los ciclos no es necesario  
            //// TODO: esta línea de código carga datos en la tabla 'sAFCIC_BDDataSet.Tipo_Lente' 
            this.tipo_LenteTableAdapter1.Fill(this.sAFCIC_BDDataSet2.Tipo_Lente);

            txt_rut.Text = Llenado["Rut"].ToString();
            txt_nom.Text = Llenado["Nombre"].ToString();
            txt_dir.Text = Llenado["Direccion"].ToString();
            txt_tel.Text = Llenado["Telefono"].ToString();
            txt_Edad.Text = Llenado["Edad"].ToString();
            txt_Fecha.Text = Llenado["Fecha"].ToString();
            txt_fecha_entrega.Text = Llenado["Fecha_Entrega"].ToString();
            txt_total.Text = Llenado["Total"].ToString();
            txt_abono.Text = Llenado["Abono"].ToString();
            txt_saldo.Text = Llenado["saldo"].ToString();
            txt_OT.Text = Llenado["Nro_OT"].ToString();
            txt_cajas.Text = Llenado["Cajas"].ToString();
            int estado = Convert.ToInt32(Llenado["Estado"]);

            if (estado == 1)
            {
                chk_estado.Checked = true;
            }
            else
            {
                chk_estado.Checked = false;
            }
            string tipo=Llenado["Descripcion"].ToString();

            txtTipo.Visible = true;
            label15.Visible = true;

            txtTipo.Text = tipo;
            //Combo_Tipo.SelectedItem = tipo;
            Combo_Tipo .Visible =false;
            Tipo_lbl.Visible = false;

            // se cargara la id de la venta y se guardara en tabla temporal
            int ID_Venta = Convert.ToInt32(Llenado["Id_venta"]);

            Llenado.Close();
            Temp_ins.guardarIDventa(ID_Venta);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_rut.Text == "" || txt_nom.Text == "" || txt_Fecha.Text == "" || txt_fecha_entrega.Text == "" || txt_abono.Text == "" || txt_total.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos marcados con asterisco");

            }
            else
            {
                Forms.Ficha Ficha = new Forms.Ficha();
                Ficha.MdiParent = this.MdiParent;
                Ficha.Show();
            }
        }


        #region // validacion de texbox

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 75 || e.KeyChar == 107 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar >= 65 && e.KeyChar <= 90))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_cajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_OT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 47 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_fecha_entrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 47 || e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        private void Box_Venta_Enter(object sender, EventArgs e)
        {

        }

        private void Box_Cliente_Enter(object sender, EventArgs e)
        {

        }

        private void txt_abono_TextChanged(object sender, EventArgs e)
        {
            int abono =Convert.ToInt32(txt_total.Text);
            int total=Convert.ToInt32(txt_abono.Text);
            txt_saldo.Text  =(abono  - total).ToString()  ; 
        }

        private void Btn_Upd_Click(object sender, EventArgs e)
        {
            
            int estado = 0;

            if ( chk_estado.Checked  == true) estado = 1 ;

            int idventa = Temp_ins.consultaIdVenta();

            string sql = "UPDATE Venta SET Estado ="+estado +" WHERE Id_venta = "+idventa +"";
            conn.insert(sql);
            BD_coneccion.Close();

            MessageBox.Show("Edtado actualizado!");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


    }
}
