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

                if (rbJson.Checked)
                {
                    curso_c.exportarInfoJSON();
                }
                else if (rbXml.Checked)
                {
                    curso_c.exportarInfoXML();
                }                
            }
            if (rbCplus.Checked)
            {
                Curso curso_cplus = new Curso(rbCplus.Text.Trim());
                curso_cplus.cargarInfo(this);

                if (rbJson.Checked)
                {
                    curso_cplus.exportarInfoJSON();
                }
                else if (rbXml.Checked)
                {
                    curso_cplus.exportarInfoXML();
                }
            }
            if (rbJs.Checked)
            {
                Curso curso_js = new Curso(rbJs.Text.Trim());
                curso_js.cargarInfo(this);

                if (rbJson.Checked)
                {
                    curso_js.exportarInfoJSON();
                }
                else if (rbXml.Checked)
                {
                    curso_js.exportarInfoXML();
                }
            }
        }
        
    }
}
