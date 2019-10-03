namespace SAFCIC_V1._0.Forms
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.grillacontrol = new System.Windows.Forms.DataGridView();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_fecha_mod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Mod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hora_mod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Combo_Estado = new System.Windows.Forms.ComboBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillacontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // grillacontrol
            // 
            this.grillacontrol.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grillacontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grillacontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grillacontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillacontrol.Location = new System.Drawing.Point(1, 88);
            this.grillacontrol.Name = "grillacontrol";
            this.grillacontrol.Size = new System.Drawing.Size(465, 150);
            this.grillacontrol.TabIndex = 0;
            this.grillacontrol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillacontrol_CellClick);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(122, 293);
            this.txt_num.MaxLength = 1;
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(19, 20);
            this.txt_num.TabIndex = 9;
            // 
            // txt_fecha_mod
            // 
            this.txt_fecha_mod.Location = new System.Drawing.Point(122, 319);
            this.txt_fecha_mod.MaxLength = 8;
            this.txt_fecha_mod.Name = "txt_fecha_mod";
            this.txt_fecha_mod.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_mod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Control";
            // 
            // btn_Mod
            // 
            this.btn_Mod.Location = new System.Drawing.Point(300, 316);
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(75, 23);
            this.btn_Mod.TabIndex = 3;
            this.btn_Mod.Text = "Modificar";
            this.btn_Mod.UseVisualStyleBackColor = true;
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modificar control";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(122, 19);
            this.txt_fecha.MaxLength = 8;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora";
            // 
            // Btn_add
            // 
            this.Btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_add.BackgroundImage")));
            this.Btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_add.Location = new System.Drawing.Point(316, 19);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(49, 48);
            this.Btn_add.TabIndex = 8;
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora";
            // 
            // txt_hora_mod
            // 
            this.txt_hora_mod.Location = new System.Drawing.Point(122, 345);
            this.txt_hora_mod.MaxLength = 5;
            this.txt_hora_mod.Name = "txt_hora_mod";
            this.txt_hora_mod.Size = new System.Drawing.Size(59, 20);
            this.txt_hora_mod.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado";
            // 
            // Combo_Estado
            // 
            this.Combo_Estado.FormattingEnabled = true;
            this.Combo_Estado.Location = new System.Drawing.Point(122, 372);
            this.Combo_Estado.Name = "Combo_Estado";
            this.Combo_Estado.Size = new System.Drawing.Size(121, 21);
            this.Combo_Estado.TabIndex = 13;
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(122, 42);
            this.txt_hora.MaxLength = 5;
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(59, 20);
            this.txt_hora.TabIndex = 2;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 434);
            this.Controls.Add(this.Combo_Estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_hora_mod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Mod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha_mod);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.grillacontrol);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillacontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillacontrol;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_fecha_mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hora_mod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Combo_Estado;
        private System.Windows.Forms.TextBox txt_hora;
    }
}