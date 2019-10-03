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
    public partial class Admin_stock : Form
    {
        public Admin_stock()
        {
            InitializeComponent();
        }

        BD_coneccion conexion = new BD_coneccion();
        Clases.Stock stock_ins = new Clases.Stock();



        private void radio_conv_mod_CheckedChanged(object sender, EventArgs e)// valida que se seleccione radiobuttom convencional y cambia valores de los combo
        {

            string con_String_fuerza = "SELECT DISTINCT Fuerza FROM Lentes_desechables_conv order by Fuerza ";//String de conexion para cargar datos en la grilla

            conexion.consulta_LLenar_grilla(con_String_fuerza, "Lentes_desechables_conv");
            Combo_sel.DataSource = conexion.ds.Tables["Lentes_desechables_conv"];
            Combo_sel.DisplayMember = "Fuerza";
            Combo_sel.ValueMember = "Fuerza";


            string con_String_marca = "SELECT DISTINCT marca FROM Lentes_desechables_conv WHERE Fuerza = '"+Combo_sel.SelectedValue .ToString ()+"' order by marca ";//String de conexion para cargar datos en la grilla

            conexion.consulta_LLenar_grilla(con_String_marca, "Lentes_desechables_conv");
            combo_marca.DataSource = conexion.ds.Tables["Lentes_desechables_conv"];
            combo_marca.DisplayMember = "marca";
            combo_marca.ValueMember = "marca";


            combo_tipo_mod.Visible = false;
            lbl_tipo_mod.Visible = false;
            lbl_marca.Visible = true;
            combo_marca.Visible = true;
            BD_coneccion.Close();

        }

        private void radio_conv_add_CheckedChanged(object sender, EventArgs e)// valida que raddio buttom convensional en agregar producto este marcado
        {
            txt_dioptria.Visible = true;
            txt_color.Visible = false;
            txt_marca.Visible = true;
            txt_stock.Visible = true;
            txt_valor.Visible = true;
            Combo_tipo.Visible = false;
        }

        private void radio_col_add_CheckedChanged(object sender, EventArgs e)// valida que raddio buttom color en agregar producto este marcado
        {

            txt_dioptria.Visible = false;
            txt_color.Visible = true;
            txt_marca.Visible = true;
            txt_stock.Visible = true;
            txt_valor.Visible = true;
            Combo_tipo.Visible = true;



        }

        private void Admin_stock_Load(object sender, EventArgs e)
        {

            Combo_tipo.Items.Add("Tricolor");
            Combo_tipo.Items.Add("Bicolor");

            combo_tipo_mod.Items.Add("Tricolor");
            combo_tipo_mod.Items.Add("Bicolor");

        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_col_mod_CheckedChanged(object sender, EventArgs e)//valida que radiobuttom color este marcado en modificar stock
        {

            string con_String = "SELECT DISTINCT Color FROM Lentes_desechables_color order by Color ";//String de conexion para cargar datos en la grilla

            conexion.consulta_LLenar_grilla(con_String, "Lentes_desechables_color");
            Combo_sel.DataSource = conexion.ds.Tables["Lentes_desechables_color"];
            Combo_sel.DisplayMember = "color";
            Combo_sel.ValueMember = "color";

            combo_tipo_mod.Visible = true;
            lbl_tipo_mod.Visible = true;
            combo_marca.Visible = false;
            lbl_marca.Visible = false;
            BD_coneccion.Close();
        }

        private void btn_add_mod_Click(object sender, EventArgs e) // metodos que se ejecutan al presionar boton agregrar stock 
        {
            if (radio_conv_mod.Checked == true)
            {
                string fuerza= Combo_sel.SelectedValue.ToString();
                string marca = combo_marca.SelectedValue.ToString();
                stock_ins.guardar_datos_conv_mas(fuerza ,marca , Convert.ToInt32 (txt_cant.Text));
                MessageBox.Show("Valor agregado");
            }

            if (radio_col_mod.Checked == true)
            {
                stock_ins.guardar_datos_color_mas(Combo_sel.SelectedValue.ToString(), combo_tipo_mod.SelectedValue.ToString(), Convert.ToInt32(txt_cant.Text));

                MessageBox.Show("Valor agregado");
            }


        }

        private void Combo_sel_SelectedIndexChanged(object sender, EventArgs e)// valida cambio de seleccion en comobo dependiendo de radiobuttom seleccionado
        {
            if (radio_conv_mod.Checked == true)// si esta boton convencional marcado
            {
                string con_String_marca = "SELECT DISTINCT marca FROM Lentes_desechables_conv WHERE Fuerza = '" + Combo_sel.SelectedValue.ToString() + "' order by marca ";//String de conexion para cargar datos en la grilla

                conexion.consulta_LLenar_grilla(con_String_marca, "Lentes_desechables_conv");
                combo_marca.DataSource = conexion.ds.Tables["Lentes_desechables_conv"];
                combo_marca.DisplayMember = "marca";
                combo_marca.ValueMember = "marca";
                BD_coneccion.Close();
            }



            if (radio_col_mod.Checked == true)// si esta boton color marcado
            {
                string con_String_marca = "SELECT DISTINCT tipo FROM Lentes_desechables_color WHERE Color = '" + Combo_sel.SelectedValue.ToString()+"' "; //String de conexion para cargar datos en la grilla

                conexion.consulta_LLenar_grilla(con_String_marca, "Lentes_desechables_color");
                combo_tipo_mod.DataSource = conexion.ds.Tables["Lentes_desechables_color"];
                combo_tipo_mod.DisplayMember = "tipo";
                combo_tipo_mod.ValueMember = "tipo";
                BD_coneccion.Close();
            }
        }

        private void btn_del_mod_Click(object sender, EventArgs e)
        {
            if (radio_conv_mod.Checked == true)
            { 
                string fuerza= Combo_sel.SelectedValue.ToString();
                string marca = combo_marca.SelectedValue.ToString();
                stock_ins.guardar_datos_conv_menos(fuerza ,marca , Convert.ToInt32 (txt_cant.Text));
            }


            if (radio_col_mod.Checked == true)
            {
                stock_ins.guardar_datos_color_menos(Combo_sel.SelectedValue.ToString(), combo_tipo_mod.SelectedValue.ToString(), Convert.ToInt32(txt_cant.Text));

                MessageBox.Show("Valor agregado");
            }

        }//actualiza o elimina stock dependiendo de que radio esta seleccionado

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (radio_col_add.Checked == true)
            {
                stock_ins.guardar_datos_nuevo_color(txt_color.Text, Convert.ToInt32(txt_stock.Text), txt_marca.Text, Convert.ToInt32 (txt_valor.Text), Combo_tipo.SelectedItem.ToString());
                MessageBox.Show("Producto agregado");
            }

            if (radio_conv_add.Checked == true)
            { 
                  stock_ins.guardar_datos_nuevo_conv(txt_dioptria.Text,Convert.ToInt32( txt_stock.Text ),txt_marca.Text,Convert .ToInt32(txt_valor .Text ));
                  MessageBox.Show("Producto agregado");
            }
        } //agrega producto dependiendo de tipo seleccionado


            
    }

    
}
