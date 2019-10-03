namespace SAFCIC_V1._0.Forms
{
    partial class Admin_stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_del_mod = new System.Windows.Forms.Button();
            this.btn_add_mod = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_conv_mod = new System.Windows.Forms.RadioButton();
            this.radio_col_mod = new System.Windows.Forms.RadioButton();
            this.Combo_sel = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Combo_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dioptria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_col_add = new System.Windows.Forms.RadioButton();
            this.radio_conv_add = new System.Windows.Forms.RadioButton();
            this.lbl_tipo_mod = new System.Windows.Forms.Label();
            this.combo_tipo_mod = new System.Windows.Forms.ComboBox();
            this.combo_marca = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_marca);
            this.groupBox1.Controls.Add(this.combo_tipo_mod);
            this.groupBox1.Controls.Add(this.btn_del_mod);
            this.groupBox1.Controls.Add(this.btn_add_mod);
            this.groupBox1.Controls.Add(this.txt_cant);
            this.groupBox1.Controls.Add(this.lbl_marca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_tipo_mod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radio_conv_mod);
            this.groupBox1.Controls.Add(this.radio_col_mod);
            this.groupBox1.Controls.Add(this.Combo_sel);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar o quitar stock";
            // 
            // btn_del_mod
            // 
            this.btn_del_mod.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.icono_Quitar;
            this.btn_del_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_mod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_mod.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_del_mod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_del_mod.Location = new System.Drawing.Point(215, 150);
            this.btn_del_mod.Name = "btn_del_mod";
            this.btn_del_mod.Size = new System.Drawing.Size(40, 31);
            this.btn_del_mod.TabIndex = 5;
            this.btn_del_mod.UseVisualStyleBackColor = true;
            this.btn_del_mod.Click += new System.EventHandler(this.btn_del_mod_Click);
            // 
            // btn_add_mod
            // 
            this.btn_add_mod.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.icono_agregar;
            this.btn_add_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_mod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_mod.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_mod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_mod.Location = new System.Drawing.Point(169, 150);
            this.btn_add_mod.Name = "btn_add_mod";
            this.btn_add_mod.Size = new System.Drawing.Size(40, 31);
            this.btn_add_mod.TabIndex = 5;
            this.btn_add_mod.UseVisualStyleBackColor = true;
            this.btn_add_mod.Click += new System.EventHandler(this.btn_add_mod_Click);
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(304, 116);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(28, 20);
            this.txt_cant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuerza o color";
            // 
            // radio_conv_mod
            // 
            this.radio_conv_mod.AutoSize = true;
            this.radio_conv_mod.Location = new System.Drawing.Point(6, 41);
            this.radio_conv_mod.Name = "radio_conv_mod";
            this.radio_conv_mod.Size = new System.Drawing.Size(90, 17);
            this.radio_conv_mod.TabIndex = 0;
            this.radio_conv_mod.TabStop = true;
            this.radio_conv_mod.Text = "Convencional";
            this.radio_conv_mod.UseVisualStyleBackColor = true;
            this.radio_conv_mod.CheckedChanged += new System.EventHandler(this.radio_conv_mod_CheckedChanged);
            // 
            // radio_col_mod
            // 
            this.radio_col_mod.AutoSize = true;
            this.radio_col_mod.Location = new System.Drawing.Point(6, 64);
            this.radio_col_mod.Name = "radio_col_mod";
            this.radio_col_mod.Size = new System.Drawing.Size(49, 17);
            this.radio_col_mod.TabIndex = 0;
            this.radio_col_mod.TabStop = true;
            this.radio_col_mod.Text = "Color";
            this.radio_col_mod.UseVisualStyleBackColor = true;
            this.radio_col_mod.CheckedChanged += new System.EventHandler(this.radio_col_mod_CheckedChanged);
            // 
            // Combo_sel
            // 
            this.Combo_sel.FormattingEnabled = true;
            this.Combo_sel.Location = new System.Drawing.Point(305, 29);
            this.Combo_sel.Name = "Combo_sel";
            this.Combo_sel.Size = new System.Drawing.Size(135, 21);
            this.Combo_sel.TabIndex = 1;
            this.Combo_sel.SelectedIndexChanged += new System.EventHandler(this.Combo_sel_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.txt_marca);
            this.groupBox2.Controls.Add(this.txt_stock);
            this.groupBox2.Controls.Add(this.txt_color);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Combo_tipo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_dioptria);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radio_col_add);
            this.groupBox2.Controls.Add(this.radio_conv_add);
            this.groupBox2.Location = new System.Drawing.Point(23, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar nuevo producto ";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(243, 111);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(57, 20);
            this.txt_valor.TabIndex = 1;
            this.txt_valor.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.icono_agregar;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(400, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(40, 31);
            this.btn_add.TabIndex = 5;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(243, 86);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(57, 20);
            this.txt_marca.TabIndex = 1;
            this.txt_marca.Visible = false;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(243, 63);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(57, 20);
            this.txt_stock.TabIndex = 1;
            this.txt_stock.Visible = false;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(305, 27);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(57, 20);
            this.txt_color.TabIndex = 1;
            this.txt_color.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Combo_tipo
            // 
            this.Combo_tipo.FormattingEnabled = true;
            this.Combo_tipo.Location = new System.Drawing.Point(243, 137);
            this.Combo_tipo.Name = "Combo_tipo";
            this.Combo_tipo.Size = new System.Drawing.Size(89, 21);
            this.Combo_tipo.TabIndex = 1;
            this.Combo_tipo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            // 
            // txt_dioptria
            // 
            this.txt_dioptria.Location = new System.Drawing.Point(168, 27);
            this.txt_dioptria.Name = "txt_dioptria";
            this.txt_dioptria.Size = new System.Drawing.Size(57, 20);
            this.txt_dioptria.TabIndex = 1;
            this.txt_dioptria.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dioptria";
            // 
            // radio_col_add
            // 
            this.radio_col_add.AutoSize = true;
            this.radio_col_add.Location = new System.Drawing.Point(6, 71);
            this.radio_col_add.Name = "radio_col_add";
            this.radio_col_add.Size = new System.Drawing.Size(49, 17);
            this.radio_col_add.TabIndex = 0;
            this.radio_col_add.TabStop = true;
            this.radio_col_add.Text = "Color";
            this.radio_col_add.UseVisualStyleBackColor = true;
            this.radio_col_add.CheckedChanged += new System.EventHandler(this.radio_col_add_CheckedChanged);
            // 
            // radio_conv_add
            // 
            this.radio_conv_add.AutoSize = true;
            this.radio_conv_add.Location = new System.Drawing.Point(6, 48);
            this.radio_conv_add.Name = "radio_conv_add";
            this.radio_conv_add.Size = new System.Drawing.Size(90, 17);
            this.radio_conv_add.TabIndex = 0;
            this.radio_conv_add.TabStop = true;
            this.radio_conv_add.Text = "Convencional";
            this.radio_conv_add.UseVisualStyleBackColor = true;
            this.radio_conv_add.CheckedChanged += new System.EventHandler(this.radio_conv_add_CheckedChanged);
            // 
            // lbl_tipo_mod
            // 
            this.lbl_tipo_mod.AutoSize = true;
            this.lbl_tipo_mod.Location = new System.Drawing.Point(270, 55);
            this.lbl_tipo_mod.Name = "lbl_tipo_mod";
            this.lbl_tipo_mod.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo_mod.TabIndex = 2;
            this.lbl_tipo_mod.Text = "Tipo";
            this.lbl_tipo_mod.Visible = false;
            // 
            // combo_tipo_mod
            // 
            this.combo_tipo_mod.FormattingEnabled = true;
            this.combo_tipo_mod.Location = new System.Drawing.Point(305, 57);
            this.combo_tipo_mod.Name = "combo_tipo_mod";
            this.combo_tipo_mod.Size = new System.Drawing.Size(86, 21);
            this.combo_tipo_mod.TabIndex = 6;
            this.combo_tipo_mod.Visible = false;
            // 
            // combo_marca
            // 
            this.combo_marca.FormattingEnabled = true;
            this.combo_marca.Location = new System.Drawing.Point(304, 85);
            this.combo_marca.Name = "combo_marca";
            this.combo_marca.Size = new System.Drawing.Size(121, 21);
            this.combo_marca.TabIndex = 7;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(249, 88);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 3;
            this.lbl_marca.Text = "Marca";
            // 
            // Admin_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_stock";
            this.Text = "Admin_stock";
            this.Load += new System.EventHandler(this.Admin_stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_conv_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_col_add;
        private System.Windows.Forms.Button btn_del_mod;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_tipo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_add_mod;
        private System.Windows.Forms.RadioButton radio_conv_mod;
        private System.Windows.Forms.RadioButton radio_col_mod;
        private System.Windows.Forms.ComboBox Combo_sel;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dioptria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_tipo_mod;
        private System.Windows.Forms.Label lbl_tipo_mod;
        private System.Windows.Forms.ComboBox combo_marca;
        private System.Windows.Forms.Label lbl_marca;
    }
}