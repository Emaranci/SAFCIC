using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;


namespace SAFCIC_V1._0.Forms
{
    public partial class Reporte : Form
    {

        public string fecha;
        BD_coneccion conexion = new BD_coneccion();
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        private void BtnCargaGrid_Click(object sender, EventArgs e)
        {
            {
                string con_String = "SELECT dbo.Venta.Fecha, dbo.Tipo_Lente.Descripcion, SUM(dbo.Venta.Total) AS TOTALVENTA FROM dbo.Tipo_Lente INNER JOIN dbo.Venta ON dbo.Tipo_Lente.Id_Tipo = dbo.Venta.Id_Tipo_l WHERE fecha= CONVERT(datetime,'" + fecha + "',103) GROUP BY dbo.Venta.Fecha, dbo.Tipo_Lente.Descripcion";//String de conexion para cargar datos en la grilla

                conexion.consulta_LLenar_grilla(con_String, "Venta");

                dataGridView1.DataSource = conexion.ds.Tables["Venta"];

                BD_coneccion.Close();

                if (conexion.ds.Tables["Venta"].Rows.Count == 0)
                {

                    MessageBox.Show("No existen ventas en el dia seleccioado");

                }
            }
        }

        private void To_pdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "PDF";
            saveFileDialog1.Filter = "pdf Files (*.pdf) |*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                filename = saveFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Document document = new Document();

            fecha = fecha.Replace("/", "-");
            var nombreArchivo = "C:\\PDFs\\Reportes\\reporte_" + fecha + ".pdf";
            PdfWriter.GetInstance(document, new FileStream(nombreArchivo, FileMode.OpenOrCreate));

            document.Open();




            Chunk Titulo = new Chunk("Reporte", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));

            document.Add(new Paragraph(Titulo));

            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph("***********************************************"));
            document.Add(new Paragraph(dataGridView1.Columns[0].Name.ToString().PadRight(23, ' ') + dataGridView1.Columns[1].Name.ToString().PadRight(63, ' ') + dataGridView1.Columns[2].Name.ToString()));

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                document.Add(new Paragraph(dataGridView1.Rows[i].Cells[0].Value.ToString().PadRight(20, ' ') + dataGridView1.Rows[i].Cells[1].Value.ToString().PadRight(50, ' ') + dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }


            document.Close();


            MessageBox.Show("el reporte solicitado ha sido creado, ya puede imprimir");
            System.Diagnostics.Process.Start(nombreArchivo);
            

            
        }

        private void MCalReporte_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha = MCalReporte.SelectionEnd.ToShortDateString().Replace("-", "/");
        }
    }
}
