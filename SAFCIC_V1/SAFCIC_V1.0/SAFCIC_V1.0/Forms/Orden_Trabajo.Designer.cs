namespace SAFCIC_V1._0.Forms
{
    partial class Orden_Trabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombrelbl = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.Label();
            this.Odlbl = new System.Windows.Forms.Label();
            this.Oilbl = new System.Windows.Forms.Label();
            this.fechalbl = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_od = new System.Windows.Forms.TextBox();
            this.txt_oi = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ot = new System.Windows.Forms.TextBox();
            this.otlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quera_od_lbl = new System.Windows.Forms.Label();
            this.quera_oi_lbl = new System.Windows.Forms.Label();
            this.txt_quera_od = new System.Windows.Forms.TextBox();
            this.txt_quera_oi = new System.Windows.Forms.TextBox();
            this.tipo_lbl = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.cajas_lbl = new System.Windows.Forms.Label();
            this.txt_cajas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(115, 49);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 0;
            this.nombrelbl.Text = "Nombre";
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.Enabled = false;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(54, 134);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(152, 16);
            this.Datos.TabIndex = 1;
            this.Datos.Text = "Datos de fabricacion";
            // 
            // Odlbl
            // 
            this.Odlbl.AutoSize = true;
            this.Odlbl.Location = new System.Drawing.Point(131, 224);
            this.Odlbl.Name = "Odlbl";
            this.Odlbl.Size = new System.Drawing.Size(23, 13);
            this.Odlbl.TabIndex = 2;
            this.Odlbl.Text = "OD";
            // 
            // Oilbl
            // 
            this.Oilbl.AutoSize = true;
            this.Oilbl.Location = new System.Drawing.Point(136, 250);
            this.Oilbl.Name = "Oilbl";
            this.Oilbl.Size = new System.Drawing.Size(18, 13);
            this.Oilbl.TabIndex = 3;
            this.Oilbl.Text = "OI";
            // 
            // fechalbl
            // 
            this.fechalbl.AutoSize = true;
            this.fechalbl.Location = new System.Drawing.Point(63, 324);
            this.fechalbl.Name = "fechalbl";
            this.fechalbl.Size = new System.Drawing.Size(91, 13);
            this.fechalbl.TabIndex = 4;
            this.fechalbl.Text = "Fecha de entrega";
            // 
            // txt_nom
            // 
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(178, 49);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(180, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_od
            // 
            this.txt_od.Enabled = false;
            this.txt_od.Location = new System.Drawing.Point(178, 217);
            this.txt_od.Name = "txt_od";
            this.txt_od.Size = new System.Drawing.Size(180, 20);
            this.txt_od.TabIndex = 5;
            // 
            // txt_oi
            // 
            this.txt_oi.Enabled = false;
            this.txt_oi.Location = new System.Drawing.Point(178, 243);
            this.txt_oi.Name = "txt_oi";
            this.txt_oi.Size = new System.Drawing.Size(180, 20);
            this.txt_oi.TabIndex = 5;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(178, 320);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(82, 20);
            this.txt_fecha.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.imprimir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(295, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 56);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ot
            // 
            this.txt_ot.Enabled = false;
            this.txt_ot.Location = new System.Drawing.Point(178, 75);
            this.txt_ot.Name = "txt_ot";
            this.txt_ot.Size = new System.Drawing.Size(180, 20);
            this.txt_ot.TabIndex = 5;
            // 
            // otlbl
            // 
            this.otlbl.AutoSize = true;
            this.otlbl.Location = new System.Drawing.Point(73, 75);
            this.otlbl.Name = "otlbl";
            this.otlbl.Size = new System.Drawing.Size(86, 13);
            this.otlbl.TabIndex = 0;
            this.otlbl.Text = "Orden de trabajo";
            this.otlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos de Cliente";
            // 
            // quera_od_lbl
            // 
            this.quera_od_lbl.AutoSize = true;
            this.quera_od_lbl.Location = new System.Drawing.Point(67, 173);
            this.quera_od_lbl.Name = "quera_od_lbl";
            this.quera_od_lbl.Size = new System.Drawing.Size(92, 13);
            this.quera_od_lbl.TabIndex = 2;
            this.quera_od_lbl.Text = "Queratometria OD";
            // 
            // quera_oi_lbl
            // 
            this.quera_oi_lbl.AutoSize = true;
            this.quera_oi_lbl.Location = new System.Drawing.Point(67, 199);
            this.quera_oi_lbl.Name = "quera_oi_lbl";
            this.quera_oi_lbl.Size = new System.Drawing.Size(87, 13);
            this.quera_oi_lbl.TabIndex = 3;
            this.quera_oi_lbl.Text = "Queratometria OI";
            // 
            // txt_quera_od
            // 
            this.txt_quera_od.Enabled = false;
            this.txt_quera_od.Location = new System.Drawing.Point(178, 166);
            this.txt_quera_od.Name = "txt_quera_od";
            this.txt_quera_od.Size = new System.Drawing.Size(180, 20);
            this.txt_quera_od.TabIndex = 5;
            // 
            // txt_quera_oi
            // 
            this.txt_quera_oi.Enabled = false;
            this.txt_quera_oi.Location = new System.Drawing.Point(178, 192);
            this.txt_quera_oi.Name = "txt_quera_oi";
            this.txt_quera_oi.Size = new System.Drawing.Size(180, 20);
            this.txt_quera_oi.TabIndex = 5;
            // 
            // tipo_lbl
            // 
            this.tipo_lbl.AutoSize = true;
            this.tipo_lbl.Location = new System.Drawing.Point(85, 273);
            this.tipo_lbl.Name = "tipo_lbl";
            this.tipo_lbl.Size = new System.Drawing.Size(69, 13);
            this.tipo_lbl.TabIndex = 4;
            this.tipo_lbl.Text = "Tipo de lente";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Enabled = false;
            this.txt_tipo.Location = new System.Drawing.Point(178, 269);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(180, 20);
            this.txt_tipo.TabIndex = 5;
            // 
            // cajas_lbl
            // 
            this.cajas_lbl.AutoSize = true;
            this.cajas_lbl.Location = new System.Drawing.Point(63, 298);
            this.cajas_lbl.Name = "cajas_lbl";
            this.cajas_lbl.Size = new System.Drawing.Size(92, 13);
            this.cajas_lbl.TabIndex = 4;
            this.cajas_lbl.Text = "Cantidad de cajas";
            // 
            // txt_cajas
            // 
            this.txt_cajas.Enabled = false;
            this.txt_cajas.Location = new System.Drawing.Point(178, 294);
            this.txt_cajas.Name = "txt_cajas";
            this.txt_cajas.Size = new System.Drawing.Size(34, 20);
            this.txt_cajas.TabIndex = 5;
            // 
            // Orden_Trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_cajas);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_quera_oi);
            this.Controls.Add(this.txt_oi);
            this.Controls.Add(this.txt_quera_od);
            this.Controls.Add(this.txt_od);
            this.Controls.Add(this.txt_ot);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.tipo_lbl);
            this.Controls.Add(this.quera_oi_lbl);
            this.Controls.Add(this.cajas_lbl);
            this.Controls.Add(this.fechalbl);
            this.Controls.Add(this.quera_od_lbl);
            this.Controls.Add(this.Oilbl);
            this.Controls.Add(this.Odlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.otlbl);
            this.Controls.Add(this.nombrelbl);
            this.Name = "Orden_Trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orden de trabajo";
            this.Load += new System.EventHandler(this.Orden_Trabajo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label Datos;
        private System.Windows.Forms.Label Odlbl;
        private System.Windows.Forms.Label Oilbl;
        private System.Windows.Forms.Label fechalbl;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_od;
        private System.Windows.Forms.TextBox txt_oi;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ot;
        private System.Windows.Forms.Label otlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quera_od_lbl;
        private System.Windows.Forms.Label quera_oi_lbl;
        private System.Windows.Forms.TextBox txt_quera_od;
        private System.Windows.Forms.TextBox txt_quera_oi;
        private System.Windows.Forms.Label tipo_lbl;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label cajas_lbl;
        private System.Windows.Forms.TextBox txt_cajas;
    }
}