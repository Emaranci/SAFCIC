using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO ;


namespace SAFCIC_V1._0.Forms
{
    public partial class Orden_Trabajo : Form
    {
        public Orden_Trabajo()
        {
            InitializeComponent();
        }

        BD_coneccion conn = new BD_coneccion();
        Clases.Ficha Ficha_ins = new Clases.Ficha();

        private void Orden_Trabajo_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        public void cargardatos()
        {
            int Idficha = Ficha_ins.CargarId_ficha();
            string string_sql = "SELECT Cliente.Nombre, Venta.Nro_OT, Ficha.Querato_OD, Ficha.Querato_OI, Ficha.Lente_Fabricar_OD, Ficha.Lente_Fabricar_OI, Tipo_Lente.Descripcion, Venta.Cajas, Venta.Fecha_Entrega FROM Cliente INNER JOIN Venta ON Cliente.ID_cliente = Venta.Id_cliente INNER JOIN Ficha ON Venta.ID_venta = Ficha.Id_Venta INNER JOIN Tipo_Lente ON Venta.Id_Tipo_l = Tipo_Lente.Id_Tipo WHERE Ficha.Id_Ficha = "+Idficha+"";


            SqlDataReader Llenado;
            Llenado = BD_coneccion.GetDataReader(string_sql);
            // BD_coneccion.GetDataReader(sql);
            Llenado.Read();

            txt_nom.Text = Llenado["Nombre"].ToString();
            txt_ot.Text = Llenado["Nro_OT"].ToString();
            txt_quera_od.Text = Llenado["Querato_OD"].ToString();
            txt_quera_oi.Text = Llenado["querato_oi"].ToString();
            txt_od.Text = Llenado["Lente_Fabricar_OD"].ToString();
            txt_oi.Text = Llenado["Lente_Fabricar_OI"].ToString();
            txt_tipo.Text = Llenado["Descripcion"].ToString();
            txt_cajas.Text = Llenado["Cajas"].ToString();
            txt_fecha.Text = Llenado["Fecha_Entrega"].ToString();


            
            Llenado.Close();
        }


      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document document = new Document();

            string fecha = DateTime.Today.ToString ("d");
            fecha = fecha.Replace("/", "-");


            string ruta = "C:\\PDFs\\OT\\" + fecha + "_OT_" + txt_ot.Text + ".pdf";

            PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.OpenOrCreate));

            document.Open();

           
            Chunk titulo = new Chunk("Orden de trabajo",FontFactory.GetFont("ARIAL",20,iTextSharp.text.Font.BOLD));
            Chunk logo = new Chunk("TECNO-LENS", FontFactory.GetFont("ARIAL", 30, iTextSharp.text.Font.BOLD));


            document.Add(new Paragraph(logo)); 
            document.Add(new Paragraph(titulo)); 

            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph("DATOS DE CLIENTE"));
            document.Add(new Paragraph(nombrelbl.Text + ": " + txt_nom.Text ));
            document.Add(new Paragraph(otlbl.Text  + ": " + txt_ot.Text));
            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph("DATOS DE FABRICACION"));
            document.Add(new Paragraph(quera_od_lbl .Text+ ": "+ txt_quera_od.Text));
            document.Add(new Paragraph(quera_oi_lbl.Text + ": " + txt_quera_oi.Text));
            document.Add(new Paragraph(Odlbl.Text  + ": " + txt_od .Text ));
            document.Add(new Paragraph(Oilbl.Text + ": " + txt_oi.Text));
            document.Add(new Paragraph(tipo_lbl.Text  + ": " +txt_tipo.Text ));
            document.Add(new Paragraph(cajas_lbl .Text  + ": " + txt_cajas .Text) );
            document.Add(new Paragraph( "solicitado a laboratotio: ________________________________________ "  ));
            document.Add(new Paragraph( "Fecha de solicitud: ______________________ "));
            document.Add(new Paragraph(fechalbl.Text  + ": " + txt_fecha .Text ));



            document.Close();

            MessageBox.Show("La orden de trabajo a sido creada, ya puede imprimirla");
            System.Diagnostics.Process.Start(ruta);
        }
    }
}
