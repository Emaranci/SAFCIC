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
    public partial class Consulta_stock : Form
    {
        public Consulta_stock()
        {
            InitializeComponent();
        }
        BD_coneccion conexion = new BD_coneccion();
        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Admin_stock Admin_Stock = new Forms.Admin_stock();
            Admin_Stock.MdiParent = this.MdiParent;
            Admin_Stock.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dioptria.Text ) && (!string.IsNullOrEmpty(txt_color.Text )))
            {
                string color = txt_color.Text;

                string con_String = "SELECT Color, stock, marca, valor, tipo FROM Lentes_desechables_color  WHERE  color = '" + color + "'";//String de conexion para cargar datos en la grilla

                conexion.consulta_LLenar_grilla(con_String, "Lentes_desechables_color");

                grilla_resultado.DataSource = conexion.ds.Tables["Lentes_desechables_color"];

                if (conexion.ds.Tables["Lentes_desechables_color"].Rows.Count == 0)
                { MessageBox.Show("color no encontrado"); }

                txt_color.Text = "";

            }

            if (!string.IsNullOrEmpty(txt_dioptria.Text) && (string.IsNullOrEmpty(txt_color.Text)))
            {
                string fuerza = txt_dioptria.Text;

                string con_String = "SELECT Fuerza, stock, marca, valor FROM Lentes_desechables_conv  WHERE  fuerza = '" + fuerza + "'";//String de conexion para cargar datos en la grilla

                conexion.consulta_LLenar_grilla(con_String, "Lentes_desechables_conv");

                grilla_resultado.DataSource = conexion.ds.Tables["Lentes_desechables_conv"];

                if (conexion.ds.Tables["Lentes_desechables_conv"].Rows.Count == 0)
                { MessageBox.Show("dioptria no encontrada"); }
                txt_dioptria.Text = "";

            }


            if (!string.IsNullOrEmpty(txt_dioptria.Text) && (!string.IsNullOrEmpty(txt_color.Text)))
            {
                MessageBox.Show("Debe buscar color o dioptria");

                txt_color.Text = "";
                txt_dioptria.Text = "";

            }
        }

        private void Consulta_stock_Load(object sender, EventArgs e)
        {

        }
    }
}

