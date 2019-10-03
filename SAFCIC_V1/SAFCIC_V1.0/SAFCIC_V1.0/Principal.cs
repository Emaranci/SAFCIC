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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        Clases.Temporales Temp_ins = new Clases.Temporales();


        BD_coneccion conn =new BD_coneccion();

        //************************* INICIO METODOS PARA MDI ***************
        private void Principal_Load(object sender, EventArgs e)
        {
            Temp_ins.Limpiar_temp();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temp_ins.Limpiar_temp(); //  llma a metod de clase temporales para invocar metodo limpia tabla temporales para ingresar nueva venta
            Cliente_Venta newMDIChild = new Cliente_Venta();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Temp_ins.Limpiar_temp(); //  llma a metod de clase temporales para invocar metodo limpia tabla temporales para ingresar nueva busqueda

            Buscar newMDIChild = new Buscar();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void consultarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_stock newMDIChild = new Consulta_stock();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

       

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte newMDIChild = new Reporte();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        //************************* FIN METODOS PARA MDI ***************

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
