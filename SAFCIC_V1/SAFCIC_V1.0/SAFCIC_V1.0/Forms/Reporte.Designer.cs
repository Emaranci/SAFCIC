namespace SAFCIC_V1._0.Forms
{
    partial class Reporte
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
            this.MCalReporte = new System.Windows.Forms.MonthCalendar();
            this.BtnCargaGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MCalReporte
            // 
            this.MCalReporte.Location = new System.Drawing.Point(18, 18);
            this.MCalReporte.Name = "MCalReporte";
            this.MCalReporte.TabIndex = 4;
            this.MCalReporte.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MCalReporte_DateChanged);
            // 
            // BtnCargaGrid
            // 
            this.BtnCargaGrid.Location = new System.Drawing.Point(299, 86);
            this.BtnCargaGrid.Name = "BtnCargaGrid";
            this.BtnCargaGrid.Size = new System.Drawing.Size(109, 23);
            this.BtnCargaGrid.TabIndex = 5;
            this.BtnCargaGrid.Text = "Cargar Datos";
            this.BtnCargaGrid.UseVisualStyleBackColor = true;
            this.BtnCargaGrid.Click += new System.EventHandler(this.BtnCargaGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 153);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SAFCIC_V1._0.Properties.Resources.imprimir;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(200, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 52);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCargaGrid);
            this.Controls.Add(this.MCalReporte);
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MCalReporte;
        private System.Windows.Forms.Button BtnCargaGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}