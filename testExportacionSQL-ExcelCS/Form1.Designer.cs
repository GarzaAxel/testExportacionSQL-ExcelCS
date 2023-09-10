namespace testExportacionSQL_ExcelCS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConectarSQL = new System.Windows.Forms.Button();
            this.bntExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConectarSQL
            // 
            this.btnConectarSQL.Location = new System.Drawing.Point(243, 395);
            this.btnConectarSQL.Name = "btnConectarSQL";
            this.btnConectarSQL.Size = new System.Drawing.Size(116, 23);
            this.btnConectarSQL.TabIndex = 1;
            this.btnConectarSQL.Text = "Conectar BD";
            this.btnConectarSQL.UseVisualStyleBackColor = true;
            this.btnConectarSQL.Click += new System.EventHandler(this.btnConectarSQL_Click);
            // 
            // bntExportarExcel
            // 
            this.bntExportarExcel.Location = new System.Drawing.Point(423, 395);
            this.bntExportarExcel.Name = "bntExportarExcel";
            this.bntExportarExcel.Size = new System.Drawing.Size(116, 23);
            this.bntExportarExcel.TabIndex = 2;
            this.bntExportarExcel.Text = "Exportar a Excel";
            this.bntExportarExcel.UseVisualStyleBackColor = true;
            this.bntExportarExcel.Click += new System.EventHandler(this.bntExportarExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntExportarExcel);
            this.Controls.Add(this.btnConectarSQL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConectarSQL;
        private System.Windows.Forms.Button bntExportarExcel;
    }
}

