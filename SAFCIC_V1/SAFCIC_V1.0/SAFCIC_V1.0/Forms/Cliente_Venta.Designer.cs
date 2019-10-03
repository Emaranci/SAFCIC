namespace SAFCIC_V1._0.Forms
{
    partial class Cliente_Venta
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
            this.components = new System.ComponentModel.Container();
            this.Box_Venta = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Upd = new System.Windows.Forms.Button();
            this.txt_cajas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.lbl_OT = new System.Windows.Forms.Label();
            this.txt_OT = new System.Windows.Forms.TextBox();
            this.txt_fecha_entrega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_abono = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.Saldo_lbl = new System.Windows.Forms.Label();
            this.Abono_lbl = new System.Windows.Forms.Label();
            this.Val_tot_lbl = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.Combo_Tipo = new System.Windows.Forms.ComboBox();
            this.tipoLenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAFCIC_BDDataSet2 = new SAFCIC_V1._0.SAFCIC_BDDataSet2();
            this.Tipo_lbl = new System.Windows.Forms.Label();
            this.Fecha_lbl = new System.Windows.Forms.Label();
            this.tipoLenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_ficha = new System.Windows.Forms.Button();
            this.Box_Cliente = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.Direccion_lbl = new System.Windows.Forms.Label();
            this.Tel_lbl = new System.Windows.Forms.Label();
            this.Rut_lbl = new System.Windows.Forms.Label();
            this.Nombre_lbl = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tipo_LenteTableAdapter1 = new SAFCIC_V1._0.SAFCIC_BDDataSet2TableAdapters.Tipo_LenteTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.Box_Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLenteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAFCIC_BDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLenteBindingSource)).BeginInit();
            this.Box_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_Venta
            // 
            this.Box_Venta.Controls.Add(this.txtTipo);
            this.Box_Venta.Controls.Add(this.label13);
            this.Box_Venta.Controls.Add(this.label12);
            this.Box_Venta.Controls.Add(this.Btn_Upd);
            this.Box_Venta.Controls.Add(this.txt_cajas);
            this.Box_Venta.Controls.Add(this.label7);
            this.Box_Venta.Controls.Add(this.label6);
            this.Box_Venta.Controls.Add(this.label8);
            this.Box_Venta.Controls.Add(this.label5);
            this.Box_Venta.Controls.Add(this.label2);
            this.Box_Venta.Controls.Add(this.chk_estado);
            this.Box_Venta.Controls.Add(this.lbl_OT);
            this.Box_Venta.Controls.Add(this.txt_OT);
            this.Box_Venta.Controls.Add(this.txt_fecha_entrega);
            this.Box_Venta.Controls.Add(this.label1);
            this.Box_Venta.Controls.Add(this.txt_saldo);
            this.Box_Venta.Controls.Add(this.txt_abono);
            this.Box_Venta.Controls.Add(this.txt_total);
            this.Box_Venta.Controls.Add(this.Saldo_lbl);
            this.Box_Venta.Controls.Add(this.Abono_lbl);
            this.Box_Venta.Controls.Add(this.Val_tot_lbl);
            this.Box_Venta.Controls.Add(this.txt_Fecha);
            this.Box_Venta.Controls.Add(this.Combo_Tipo);
            this.Box_Venta.Controls.Add(this.label15);
            this.Box_Venta.Controls.Add(this.Tipo_lbl);
            this.Box_Venta.Controls.Add(this.Fecha_lbl);
            this.Box_Venta.Location = new System.Drawing.Point(12, 197);
            this.Box_Venta.Name = "Box_Venta";
            this.Box_Venta.Size = new System.Drawing.Size(620, 196);
            this.Box_Venta.TabIndex = 0;
            this.Box_Venta.TabStop = false;
            this.Box_Venta.Text = "Venta";
            this.Box_Venta.Enter += new System.EventHandler(this.Box_Venta_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(489, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 9);
            this.label13.TabIndex = 18;
            this.label13.Text = "DD/MM/AAAA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 9);
            this.label12.TabIndex = 18;
            this.label12.Text = "DD/MM/AAAA";
            // 
            // Btn_Upd
            // 
            this.Btn_Upd.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.refresh_128;
            this.Btn_Upd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Upd.Location = new System.Drawing.Point(421, 125);
            this.Btn_Upd.Name = "Btn_Upd";
            this.Btn_Upd.Size = new System.Drawing.Size(27, 23);
            this.Btn_Upd.TabIndex = 18;
            this.Btn_Upd.UseVisualStyleBackColor = true;
            this.Btn_Upd.Click += new System.EventHandler(this.Btn_Upd_Click);
            // 
            // txt_cajas
            // 
            this.txt_cajas.Location = new System.Drawing.Point(366, 55);
            this.txt_cajas.MaxLength = 1;
            this.txt_cajas.Name = "txt_cajas";
            this.txt_cajas.Size = new System.Drawing.Size(21, 20);
            this.txt_cajas.TabIndex = 11;
            this.txt_cajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cajas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cajas";
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(331, 127);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(75, 17);
            this.chk_estado.TabIndex = 14;
            this.chk_estado.Text = "Entregado";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // lbl_OT
            // 
            this.lbl_OT.AutoSize = true;
            this.lbl_OT.Location = new System.Drawing.Point(255, 105);
            this.lbl_OT.Name = "lbl_OT";
            this.lbl_OT.Size = new System.Drawing.Size(98, 13);
            this.lbl_OT.TabIndex = 11;
            this.lbl_OT.Text = "N° Orden dr trabajo";
            // 
            // txt_OT
            // 
            this.txt_OT.Location = new System.Drawing.Point(366, 102);
            this.txt_OT.Name = "txt_OT";
            this.txt_OT.Size = new System.Drawing.Size(100, 20);
            this.txt_OT.TabIndex = 13;
            this.txt_OT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OT_KeyPress);
            // 
            // txt_fecha_entrega
            // 
            this.txt_fecha_entrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_fecha_entrega.Location = new System.Drawing.Point(366, 78);
            this.txt_fecha_entrega.MaxLength = 10;
            this.txt_fecha_entrega.Name = "txt_fecha_entrega";
            this.txt_fecha_entrega.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_entrega.TabIndex = 12;
            this.txt_fecha_entrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_entrega_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de entrega";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(99, 101);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo.TabIndex = 9;
            this.txt_saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_saldo_KeyPress);
            // 
            // txt_abono
            // 
            this.txt_abono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_abono.Location = new System.Drawing.Point(99, 77);
            this.txt_abono.Name = "txt_abono";
            this.txt_abono.Size = new System.Drawing.Size(100, 20);
            this.txt_abono.TabIndex = 8;
            this.txt_abono.TextChanged += new System.EventHandler(this.txt_abono_TextChanged);
            this.txt_abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_abono_KeyPress);
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_total.Location = new System.Drawing.Point(99, 52);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 7;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress);
            // 
            // Saldo_lbl
            // 
            this.Saldo_lbl.AutoSize = true;
            this.Saldo_lbl.Location = new System.Drawing.Point(58, 101);
            this.Saldo_lbl.Name = "Saldo_lbl";
            this.Saldo_lbl.Size = new System.Drawing.Size(34, 13);
            this.Saldo_lbl.TabIndex = 6;
            this.Saldo_lbl.Text = "Saldo";
            // 
            // Abono_lbl
            // 
            this.Abono_lbl.AutoSize = true;
            this.Abono_lbl.Location = new System.Drawing.Point(54, 77);
            this.Abono_lbl.Name = "Abono_lbl";
            this.Abono_lbl.Size = new System.Drawing.Size(38, 13);
            this.Abono_lbl.TabIndex = 5;
            this.Abono_lbl.Text = "Abono";
            // 
            // Val_tot_lbl
            // 
            this.Val_tot_lbl.AutoSize = true;
            this.Val_tot_lbl.Location = new System.Drawing.Point(38, 52);
            this.Val_tot_lbl.Name = "Val_tot_lbl";
            this.Val_tot_lbl.Size = new System.Drawing.Size(54, 13);
            this.Val_tot_lbl.TabIndex = 4;
            this.Val_tot_lbl.Text = "Valor total";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Fecha.Location = new System.Drawing.Point(99, 26);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha.TabIndex = 6;
            this.txt_Fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fecha_KeyPress);
            // 
            // Combo_Tipo
            // 
            this.Combo_Tipo.DataSource = this.tipoLenteBindingSource1;
            this.Combo_Tipo.DisplayMember = "Descripcion";
            this.Combo_Tipo.FormattingEnabled = true;
            this.Combo_Tipo.Location = new System.Drawing.Point(366, 27);
            this.Combo_Tipo.Name = "Combo_Tipo";
            this.Combo_Tipo.Size = new System.Drawing.Size(234, 21);
            this.Combo_Tipo.TabIndex = 10;
            this.Combo_Tipo.ValueMember = "Id_Tipo";
            // 
            // tipoLenteBindingSource1
            // 
            this.tipoLenteBindingSource1.DataMember = "Tipo_Lente";
            this.tipoLenteBindingSource1.DataSource = this.sAFCIC_BDDataSet2;
            // 
            // sAFCIC_BDDataSet2
            // 
            this.sAFCIC_BDDataSet2.DataSetName = "SAFCIC_BDDataSet2";
            this.sAFCIC_BDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tipo_lbl
            // 
            this.Tipo_lbl.AutoSize = true;
            this.Tipo_lbl.Location = new System.Drawing.Point(284, 30);
            this.Tipo_lbl.Name = "Tipo_lbl";
            this.Tipo_lbl.Size = new System.Drawing.Size(69, 13);
            this.Tipo_lbl.TabIndex = 1;
            this.Tipo_lbl.Text = "Tipo de lente";
            // 
            // Fecha_lbl
            // 
            this.Fecha_lbl.AutoSize = true;
            this.Fecha_lbl.Location = new System.Drawing.Point(55, 26);
            this.Fecha_lbl.Name = "Fecha_lbl";
            this.Fecha_lbl.Size = new System.Drawing.Size(37, 13);
            this.Fecha_lbl.TabIndex = 1;
            this.Fecha_lbl.Text = "Fecha";
            // 
            // tipoLenteBindingSource
            // 
            this.tipoLenteBindingSource.DataMember = "Tipo_Lente";
            // 
            // Btn_ficha
            // 
            this.Btn_ficha.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.registro;
            this.Btn_ficha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ficha.Location = new System.Drawing.Point(526, 87);
            this.Btn_ficha.Name = "Btn_ficha";
            this.Btn_ficha.Size = new System.Drawing.Size(55, 45);
            this.Btn_ficha.TabIndex = 16;
            this.Btn_ficha.UseVisualStyleBackColor = true;
            this.Btn_ficha.Click += new System.EventHandler(this.button1_Click);
            // 
            // Box_Cliente
            // 
            this.Box_Cliente.Controls.Add(this.label11);
            this.Box_Cliente.Controls.Add(this.label10);
            this.Box_Cliente.Controls.Add(this.label4);
            this.Box_Cliente.Controls.Add(this.label3);
            this.Box_Cliente.Controls.Add(this.txt_Edad);
            this.Box_Cliente.Controls.Add(this.lbl_Edad);
            this.Box_Cliente.Controls.Add(this.txt_rut);
            this.Box_Cliente.Controls.Add(this.txt_tel);
            this.Box_Cliente.Controls.Add(this.txt_dir);
            this.Box_Cliente.Controls.Add(this.txt_nom);
            this.Box_Cliente.Controls.Add(this.Direccion_lbl);
            this.Box_Cliente.Controls.Add(this.Tel_lbl);
            this.Box_Cliente.Controls.Add(this.Rut_lbl);
            this.Box_Cliente.Controls.Add(this.Nombre_lbl);
            this.Box_Cliente.Controls.Add(this.Btn_ficha);
            this.Box_Cliente.Location = new System.Drawing.Point(12, 24);
            this.Box_Cliente.Name = "Box_Cliente";
            this.Box_Cliente.Size = new System.Drawing.Size(606, 154);
            this.Box_Cliente.TabIndex = 0;
            this.Box_Cliente.TabStop = false;
            this.Box_Cliente.Text = "Cliente";
            this.Box_Cliente.Enter += new System.EventHandler(this.Box_Cliente_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Sin puntos ni guion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ficha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(456, 52);
            this.txt_Edad.MaxLength = 2;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(33, 20);
            this.txt_Edad.TabIndex = 5;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(418, 55);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_Edad.TabIndex = 5;
            this.lbl_Edad.Text = "Edad";
            // 
            // txt_rut
            // 
            this.txt_rut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_rut.Location = new System.Drawing.Point(99, 52);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(128, 20);
            this.txt_rut.TabIndex = 2;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(456, 21);
            this.txt_tel.MaxLength = 8;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(109, 20);
            this.txt_tel.TabIndex = 4;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(99, 84);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(209, 20);
            this.txt_dir.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_nom.Location = new System.Drawing.Point(99, 20);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(268, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);
            // 
            // Direccion_lbl
            // 
            this.Direccion_lbl.AutoSize = true;
            this.Direccion_lbl.Location = new System.Drawing.Point(40, 87);
            this.Direccion_lbl.Name = "Direccion_lbl";
            this.Direccion_lbl.Size = new System.Drawing.Size(52, 13);
            this.Direccion_lbl.TabIndex = 3;
            this.Direccion_lbl.Text = "Direccion";
            // 
            // Tel_lbl
            // 
            this.Tel_lbl.AutoSize = true;
            this.Tel_lbl.Location = new System.Drawing.Point(401, 21);
            this.Tel_lbl.Name = "Tel_lbl";
            this.Tel_lbl.Size = new System.Drawing.Size(49, 13);
            this.Tel_lbl.TabIndex = 2;
            this.Tel_lbl.Text = "Telefono";
            // 
            // Rut_lbl
            // 
            this.Rut_lbl.AutoSize = true;
            this.Rut_lbl.Location = new System.Drawing.Point(68, 55);
            this.Rut_lbl.Name = "Rut_lbl";
            this.Rut_lbl.Size = new System.Drawing.Size(24, 13);
            this.Rut_lbl.TabIndex = 1;
            this.Rut_lbl.Text = "Rut";
            // 
            // Nombre_lbl
            // 
            this.Nombre_lbl.AutoSize = true;
            this.Nombre_lbl.Location = new System.Drawing.Point(48, 20);
            this.Nombre_lbl.Name = "Nombre_lbl";
            this.Nombre_lbl.Size = new System.Drawing.Size(44, 13);
            this.Nombre_lbl.TabIndex = 0;
            this.Nombre_lbl.Text = "Nombre";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.Guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(538, 397);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(55, 51);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Los campos marcados deben ser ingresados y no pueden quedar en blanco.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(545, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Guardar";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // tipo_LenteTableAdapter1
            // 
            this.tipo_LenteTableAdapter1.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tipo de lente";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(366, 162);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(234, 20);
            this.txtTipo.TabIndex = 19;
            // 
            // Cliente_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 460);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Box_Cliente);
            this.Controls.Add(this.Box_Venta);
            this.Name = "Cliente_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de venta";
            this.Load += new System.EventHandler(this.Cliente_Venta_Load);
            this.Box_Venta.ResumeLayout(false);
            this.Box_Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLenteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAFCIC_BDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLenteBindingSource)).EndInit();
            this.Box_Cliente.ResumeLayout(false);
            this.Box_Cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Box_Venta;
        private System.Windows.Forms.GroupBox Box_Cliente;
        private System.Windows.Forms.Label Nombre_lbl;
        private System.Windows.Forms.Button Btn_ficha;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label Direccion_lbl;
        private System.Windows.Forms.Label Tel_lbl;
        private System.Windows.Forms.Label Rut_lbl;
        private System.Windows.Forms.TextBox txt_fecha_entrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.TextBox txt_abono;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label Saldo_lbl;
        private System.Windows.Forms.Label Abono_lbl;
        private System.Windows.Forms.Label Val_tot_lbl;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.ComboBox Combo_Tipo;
        private System.Windows.Forms.Label Tipo_lbl;
        private System.Windows.Forms.Label Fecha_lbl;
        private System.Windows.Forms.Button btn_guardar;
        private SAFCIC_BDDataSet sAFCIC_BDDataSet;
        private System.Windows.Forms.BindingSource tipoLenteBindingSource;
        private SAFCIC_BDDataSetTableAdapters.Tipo_LenteTableAdapter tipo_LenteTableAdapter;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label lbl_OT;
        private System.Windows.Forms.TextBox txt_OT;
        private System.Windows.Forms.TextBox txt_cajas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Upd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private SAFCIC_BDDataSet2 sAFCIC_BDDataSet2;
        private System.Windows.Forms.BindingSource tipoLenteBindingSource1;
        private SAFCIC_BDDataSet2TableAdapters.Tipo_LenteTableAdapter tipo_LenteTableAdapter1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label15;
    }
}