namespace PracticaForm
{
    partial class FormExportacion
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
            rbC = new RadioButton();
            rbCplus = new RadioButton();
            rbJs = new RadioButton();
            btn_exportar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbJson = new RadioButton();
            rbXml = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(14, 22);
            rbC.Name = "rbC";
            rbC.Size = new Size(40, 19);
            rbC.TabIndex = 0;
            rbC.TabStop = true;
            rbC.Text = "C#";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbCplus
            // 
            rbCplus.AutoSize = true;
            rbCplus.Location = new Point(14, 47);
            rbCplus.Name = "rbCplus";
            rbCplus.Size = new Size(49, 19);
            rbCplus.TabIndex = 1;
            rbCplus.TabStop = true;
            rbCplus.Text = "C++";
            rbCplus.UseVisualStyleBackColor = true;
            // 
            // rbJs
            // 
            rbJs.AutoSize = true;
            rbJs.Location = new Point(14, 72);
            rbJs.Name = "rbJs";
            rbJs.Size = new Size(77, 19);
            rbJs.TabIndex = 2;
            rbJs.TabStop = true;
            rbJs.Text = "JavaScript";
            rbJs.UseVisualStyleBackColor = true;
            // 
            // btn_exportar
            // 
            btn_exportar.Enabled = false;
            btn_exportar.Location = new Point(196, 285);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(75, 23);
            btn_exportar.TabIndex = 3;
            btn_exportar.Text = "Exportar";
            btn_exportar.UseVisualStyleBackColor = true;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbC);
            groupBox1.Controls.Add(rbCplus);
            groupBox1.Controls.Add(rbJs);
            groupBox1.Location = new Point(135, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cursos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJson);
            groupBox2.Controls.Add(rbXml);
            groupBox2.Location = new Point(135, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 78);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Location = new Point(14, 22);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(53, 19);
            rbJson.TabIndex = 0;
            rbJson.TabStop = true;
            rbJson.Text = "JSON";
            rbJson.UseVisualStyleBackColor = true;
            rbJson.CheckedChanged += rbJson_CheckedChanged;
            // 
            // rbXml
            // 
            rbXml.AutoSize = true;
            rbXml.Location = new Point(14, 47);
            rbXml.Name = "rbXml";
            rbXml.Size = new Size(49, 19);
            rbXml.TabIndex = 1;
            rbXml.TabStop = true;
            rbXml.Text = "XML";
            rbXml.UseVisualStyleBackColor = true;
            rbXml.CheckedChanged += rbXml_CheckedChanged;
            // 
            // FormExportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 368);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_exportar);
            Name = "FormExportacion";
            Text = "FormExportacion";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbC;
        private RadioButton rbCplus;
        private RadioButton rbJs;
        private Button btn_exportar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbJson;
        private RadioButton rbXml;
    }
}