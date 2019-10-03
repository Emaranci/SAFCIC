namespace SAFCIC_V1._0.Forms
{
    partial class Consulta_stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dioptria = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.grilla_resultado = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Dioptria a buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese color a buscar";
            // 
            // txt_dioptria
            // 
            this.txt_dioptria.Location = new System.Drawing.Point(196, 55);
            this.txt_dioptria.Name = "txt_dioptria";
            this.txt_dioptria.Size = new System.Drawing.Size(58, 20);
            this.txt_dioptria.TabIndex = 2;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(196, 94);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(99, 20);
            this.txt_color.TabIndex = 3;
            // 
            // grilla_resultado
            // 
            this.grilla_resultado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grilla_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grilla_resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grilla_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_resultado.Location = new System.Drawing.Point(12, 192);
            this.grilla_resultado.Name = "grilla_resultado";
            this.grilla_resultado.Size = new System.Drawing.Size(414, 150);
            this.grilla_resultado.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.package_add_256;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(343, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.Stock;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(288, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consulta_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grilla_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_dioptria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta stock";
            this.Load += new System.EventHandler(this.Consulta_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dioptria;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grilla_resultado;
        private System.Windows.Forms.Button button2;
    }
}