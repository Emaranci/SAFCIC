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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }


        Clases.Temporales tem_ins = new Clases.Temporales();
        BD_coneccion conexion = new BD_coneccion();
        Clases.Ficha ficha_ins = new Clases.Ficha();
        Clases.Controles  control_ins = new Clases.Controles ();


       

        private void Control_Load(object sender, EventArgs e)
        {

           int Idficha= ficha_ins.CargarId_ficha();


           CargarControles(Idficha);

            Llenado_combo();
        }



        private void Llenado_combo()
        {
            Combo_Estado.Items.Add("Asistió");
            Combo_Estado.Items.Add("No Asistió");
            Combo_Estado.Items.Add("Pendiente");
        
        }

        public void CargarControles(int IdFicha)
        {

            
            string con_String = "SELECT Controles.Numero_control, Controles.Fecha, Controles.Hora, Controles.Estado FROM Controles INNER JOIN Ficha ON Controles.IdFicha = Ficha.Id_Ficha WHERE  Controles.IdFicha = " + IdFicha + "";//String de conexion para cargar datos en la grilla

            conexion.consulta_LLenar_grilla(con_String, "Controles");

            grillacontrol.DataSource = conexion.ds.Tables["Controles"];


            
        }

        private void grillacontrol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_num.Text = grillacontrol.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fecha_mod.Text = grillacontrol.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            txt_hora_mod.Text = grillacontrol.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            Combo_Estado.SelectedItem  = grillacontrol.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

            if (txt_fecha.Text == "" || txt_hora.Text == "")
            {
                MessageBox.Show("Debe ingresar fecha y hora de control");
            }
            else
            {
                control_ins.guardar_control(txt_fecha.Text, txt_hora.Text);
                int Idficha = ficha_ins.CargarId_ficha();
                CargarControles(Idficha);
            }
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {


            control_ins.Modificar_controles(Convert.ToInt32(txt_num.Text),txt_fecha_mod.Text , txt_hora_mod.Text ,Combo_Estado.SelectedItem.ToString());
            int Idficha = ficha_ins.CargarId_ficha();
            CargarControles(Idficha);
        }
    }
}
