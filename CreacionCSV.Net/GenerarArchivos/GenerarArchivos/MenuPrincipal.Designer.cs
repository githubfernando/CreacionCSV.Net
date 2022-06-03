
namespace GenerarArchivos
{
    partial class MenuPrincipal
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
            this.menuArchivo = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.menuArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuArchivo
            // 
            this.menuArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuArchivo.Location = new System.Drawing.Point(0, 0);
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(800, 24);
            this.menuArchivo.TabIndex = 0;
            this.menuArchivo.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarCSVToolStripMenuItem,
            this.exportarTXTToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // exportarCSVToolStripMenuItem
            // 
            this.exportarCSVToolStripMenuItem.Name = "exportarCSVToolStripMenuItem";
            this.exportarCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarCSVToolStripMenuItem.Text = "Exportar CSV";
            // 
            // exportarTXTToolStripMenuItem
            // 
            this.exportarTXTToolStripMenuItem.Name = "exportarTXTToolStripMenuItem";
            this.exportarTXTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarTXTToolStripMenuItem.Text = "Exportar TXT";
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Location = new System.Drawing.Point(684, 248);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportarCSV.TabIndex = 1;
            this.btnExportarCSV.Text = "ExportarCSV";
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.menuArchivo);
            this.MainMenuStrip = this.menuArchivo;
            this.Name = "Form1";
            this.Text = "Archivos";
            this.menuArchivo.ResumeLayout(false);
            this.menuArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarTXTToolStripMenuItem;
        private System.Windows.Forms.Button btnExportarCSV;
    }
}

