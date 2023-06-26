namespace Prueba
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
			this.btn_FMV = new System.Windows.Forms.Button();
			this.btn_desconectarse = new System.Windows.Forms.Button();
			this.btn_conectarse = new System.Windows.Forms.Button();
			this.dgv_consulta = new System.Windows.Forms.DataGridView();
			this.btn_FMI = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_FMV
			// 
			this.btn_FMV.Location = new System.Drawing.Point(12, 125);
			this.btn_FMV.Name = "btn_FMV";
			this.btn_FMV.Size = new System.Drawing.Size(173, 82);
			this.btn_FMV.TabIndex = 0;
			this.btn_FMV.Text = "Mostrar Fecha Mas Ventas Por Cantidad";
			this.btn_FMV.UseVisualStyleBackColor = true;
			this.btn_FMV.Click += new System.EventHandler(this.Btn_FMV_Click);
			// 
			// btn_desconectarse
			// 
			this.btn_desconectarse.Location = new System.Drawing.Point(12, 63);
			this.btn_desconectarse.Name = "btn_desconectarse";
			this.btn_desconectarse.Size = new System.Drawing.Size(173, 45);
			this.btn_desconectarse.TabIndex = 2;
			this.btn_desconectarse.Text = "Desconectarse";
			this.btn_desconectarse.UseVisualStyleBackColor = true;
			this.btn_desconectarse.Click += new System.EventHandler(this.Btn_desconectarse_Click);
			// 
			// btn_conectarse
			// 
			this.btn_conectarse.Location = new System.Drawing.Point(12, 12);
			this.btn_conectarse.Name = "btn_conectarse";
			this.btn_conectarse.Size = new System.Drawing.Size(173, 45);
			this.btn_conectarse.TabIndex = 4;
			this.btn_conectarse.Text = "Conectarse";
			this.btn_conectarse.UseVisualStyleBackColor = true;
			this.btn_conectarse.Click += new System.EventHandler(this.Btn_conectarse_Click);
			// 
			// dgv_consulta
			// 
			this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_consulta.Location = new System.Drawing.Point(204, 12);
			this.dgv_consulta.Name = "dgv_consulta";
			this.dgv_consulta.Size = new System.Drawing.Size(1155, 292);
			this.dgv_consulta.TabIndex = 5;
			// 
			// btn_FMI
			// 
			this.btn_FMI.Location = new System.Drawing.Point(12, 222);
			this.btn_FMI.Name = "btn_FMI";
			this.btn_FMI.Size = new System.Drawing.Size(175, 82);
			this.btn_FMI.TabIndex = 6;
			this.btn_FMI.Text = "Mostrar Fecha Mas Ventas Por Importe";
			this.btn_FMI.UseVisualStyleBackColor = true;
			this.btn_FMI.Click += new System.EventHandler(this.Btn_FMI_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 317);
			this.Controls.Add(this.btn_FMI);
			this.Controls.Add(this.dgv_consulta);
			this.Controls.Add(this.btn_conectarse);
			this.Controls.Add(this.btn_desconectarse);
			this.Controls.Add(this.btn_FMV);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FMV;
        private System.Windows.Forms.Button btn_desconectarse;
        private System.Windows.Forms.Button btn_conectarse;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.Button btn_FMI;
    }
}

