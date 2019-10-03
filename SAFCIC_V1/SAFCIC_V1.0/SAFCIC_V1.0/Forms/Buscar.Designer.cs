namespace SAFCIC_V1._0.Forms
{
    partial class Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cliente_Grilla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.Buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Location = new System.Drawing.Point(181, 101);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(65, 59);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(54, 59);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(101, 13);
            this.lbl_rut.TabIndex = 1;
            this.lbl_rut.Text = "Ingrese rut a buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 51);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Cliente_Grilla
            // 
            this.Cliente_Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cliente_Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cliente_Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Cliente_Grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Cliente_Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cliente_Grilla.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cliente_Grilla.Location = new System.Drawing.Point(12, 195);
            this.Cliente_Grilla.Name = "Cliente_Grilla";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.NullValue = null;
            this.Cliente_Grilla.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Cliente_Grilla.Size = new System.Drawing.Size(487, 119);
            this.Cliente_Grilla.TabIndex = 3;
            this.Cliente_Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cliente_Grilla_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese RUT sin puntos ni guion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cliente_Grilla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_rut);
            this.Controls.Add(this.btn_Buscar);
            this.Name = "Buscar";
            this.Text = "Busqueda de paciente";
            this.Load += new System.EventHandler(this.Buscar2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cliente_Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Cliente_Grilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}