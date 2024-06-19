using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForm
{
    public partial class FormExportacion : Form
    {
        public FormExportacion()
        {
            InitializeComponent();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (rbC.Checked)
            {
                Curso curso_c = new Curso(rbC.Text.Trim());
                curso_c.cargarInfo(this);
                curso_c.exportarInfoXML();
            }
            if (rbCplus.Checked)
            {
                Curso curso_c = new Curso(rbCplus.Text.Trim());
                Console.WriteLine("Exporto el del curso c ++");
            }
            if (rbJs.Checked)
            {
                Curso curso_c = new Curso(rbJs.Text.Trim());
                Console.WriteLine("Exporto el de JS");
            }
        }
        
    }
}
