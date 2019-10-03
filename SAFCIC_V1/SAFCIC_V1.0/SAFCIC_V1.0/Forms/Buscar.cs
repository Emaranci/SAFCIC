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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();

            
        }
        Clases.Cliente Cliente_ins = new Clases.Cliente();
        Clases.Venta Venta_ins = new Clases.Venta();
        Clases.Temporales temp_isn = new Clases.Temporales();
         string rut;
        BD_coneccion conn = new BD_coneccion(); // instancia de conexion


        private void Buscar2_Load(object sender, EventArgs e)
        {
             
        }



        public void BuscarDataCliente(string rut)
        {

            
            string con_String = "SELECT Cliente.Rut, Cliente.Nombre, Venta.Fecha, Tipo_Lente.Descripcion FROM Cliente INNER JOIN Venta  ON Cliente.ID_cliente = Venta.Id_cliente  INNER JOIN Tipo_Lente ON Venta.Id_Tipo_l = Tipo_Lente.Id_Tipo WHERE Cliente.Rut = " + rut + "";//String de conexion para cargar datos en la grilla


            conn.consulta_LLenar_grilla(con_String, "Venta");



            if (conn.ds.Tables["Venta"].Rows .Count == 0)
            {
            
                MessageBox.Show("Paciente no encontrado");
                textBox1.Text = "";
            }
            else{
                Cliente_Grilla.DataSource = conn.ds.Tables["Venta"];
            }

            BD_coneccion.Close();
        }



        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                temp_isn.Limpiar_temp();
                Cliente_Grilla.DataSource = null;
                Cliente_Grilla.Rows.Clear();
                 rut = textBox1 .Text ;
                BuscarDataCliente(textBox1.Text); //valida rut a ser buscado

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un rut a buscar");
            }
        }




        private void Cliente_Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 75 || e.KeyChar == 107 || e.KeyChar == 8|| e.KeyChar >= 48 && e.KeyChar <= 57  ))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void Cliente_Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp_isn.Limpiar_temp();
            int ID = Cliente_ins.CargarId_cliente(rut);
            temp_isn.guardarIDcliente(ID);

            int idcliente = temp_isn.consultaIdCliente();
            string fecha = Cliente_Grilla.CurrentRow.Cells["Fecha"].Value.ToString ();

            int idventa = Venta_ins.CargarId_venta_Busqueda(idcliente, fecha);
            temp_isn.guardarIDventa(idventa);
            temp_isn.guardarfecha(fecha);


            
            Cliente_Venta Venta = new Cliente_Venta();
            Venta.MdiParent = this.MdiParent;
            Venta.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        } 
    }

