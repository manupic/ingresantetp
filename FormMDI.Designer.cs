namespace PracticaForm
{
    partial class FormMDI
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            nuevoRegistroBtn = new ToolStripMenuItem();
            modificarEliminarRegistroToolStripMenuItem = new ToolStripMenuItem();
            exportacionesToolStripMenuItem = new ToolStripMenuItem();
            exportarXMLToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, exportacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoRegistroBtn, modificarEliminarRegistroToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoRegistroBtn
            // 
            nuevoRegistroBtn.Name = "nuevoRegistroBtn";
            nuevoRegistroBtn.Size = new Size(216, 22);
            nuevoRegistroBtn.Text = "Nuevo Registro";
            nuevoRegistroBtn.Click += nuevoRegistroBtn_Click;
            // 
            // modificarEliminarRegistroToolStripMenuItem
            // 
            modificarEliminarRegistroToolStripMenuItem.Name = "modificarEliminarRegistroToolStripMenuItem";
            modificarEliminarRegistroToolStripMenuItem.Size = new Size(216, 22);
            modificarEliminarRegistroToolStripMenuItem.Text = "Modificar/Eliminar registro";
            // 
            // exportacionesToolStripMenuItem
            // 
            exportacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarXMLToolStripMenuItem });
            exportacionesToolStripMenuItem.Name = "exportacionesToolStripMenuItem";
            exportacionesToolStripMenuItem.Size = new Size(93, 20);
            exportacionesToolStripMenuItem.Text = "Exportaciones";
            // 
            // exportarXMLToolStripMenuItem
            // 
            exportarXMLToolStripMenuItem.Name = "exportarXMLToolStripMenuItem";
            exportarXMLToolStripMenuItem.Size = new Size(180, 22);
            exportarXMLToolStripMenuItem.Text = "Exportar XML/JSON";
            exportarXMLToolStripMenuItem.Click += exportarXMLToolStripMenuItem_Click;
            // 
            // FormMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMDI";
            Text = "FormMDI";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem nuevoRegistroBtn;
        private ToolStripMenuItem modificarEliminarRegistroToolStripMenuItem;
        private ToolStripMenuItem exportacionesToolStripMenuItem;
        private ToolStripMenuItem exportarXMLToolStripMenuItem;
    }
}