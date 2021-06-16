namespace proyectoRovere.Vista
{
    partial class frmVerpedidos
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
            this.dgvverPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvverPedidos
            // 
            this.dgvverPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvverPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvverPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvverPedidos.Location = new System.Drawing.Point(286, 191);
            this.dgvverPedidos.Name = "dgvverPedidos";
            this.dgvverPedidos.RowHeadersWidth = 51;
            this.dgvverPedidos.RowTemplate.Height = 24;
            this.dgvverPedidos.Size = new System.Drawing.Size(889, 275);
            this.dgvverPedidos.TabIndex = 0;
            // 
            // frmVerpedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1372, 616);
            this.Controls.Add(this.dgvverPedidos);
            this.Name = "frmVerpedidos";
            this.Text = "frmVerpedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvverPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvverPedidos;
    }
}