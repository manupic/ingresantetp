using System;
using System.Drawing.Text;
using System.Net.NetworkInformation;
using System.Text;

namespace PracticaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nupEdad.Value;
            string cuit = mtbCUIT.Text.Trim();
            if (Funciones.ValidaCuit(cuit))
            {
                string genero = "";
                if (rbFemenino.Checked) genero = rbFemenino.Text.Trim();
                if (rbMasculino.Checked) genero = rbMasculino.Text.Trim();
                if (rbNoBinario.Checked) genero = rbNoBinario.Text.Trim();

                //Se inicializan los nombres de los cursos con stringBuilder
                StringBuilder curso_c = new StringBuilder("");
                StringBuilder curso_cplus = new StringBuilder("");
                StringBuilder curso_js = new StringBuilder("");                

                if (chkc.Checked)
                {
                    curso_c.Append(chkc.Text.Trim()); 
                }
                if (chkCplus.Checked)
                {
                    curso_cplus.Append(chkCplus.Text.Trim());
                }
                if (chkJavaScript.Checked)
                {
                    curso_js.Append(chkJavaScript.Text.Trim());
                }
               
                string[] curso = new string[3];

                if (curso_c.Equals("") && curso_cplus.Equals("") && curso_js.Equals(""))
                {
                    MessageBox.Show("Seleccione una opci�n para curso");
                }
                else
                {
                    curso[0] = curso_c.ToString();
                    curso[1] = curso_cplus.ToString();
                    curso[2] = curso_js.ToString();

                    string pais = lbPais.Text.Trim();

                    Ingresante ing = new Ingresante(nombre, direccion, edad, cuit, genero, pais, curso);

                    this.confirmarSubmit(ing);
                }
                                                               

            }
            else
            {
                MessageBox.Show("Ingrese un Cuit Valido");
            }

        }

        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nupEdad.Value = 18;
            mtbCUIT.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkc.Checked = false;
            chkCplus.Checked = false;
            chkJavaScript.Checked = false;
            lbPais.Text = "";
        }        

        internal void confirmarSubmit(Ingresante ingresante)
        {
            if (Funciones.mConsulta(this, "Datos Ingresante \n" + ingresante.ToString()))
            {
                if (MessageBox.Show(ingresante.ToStringCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (string curso_str in ingresante.Curso)
                    {
                        Curso curso = new Curso(curso_str);
                        curso.cargarInfo();
                        curso.agregarAlCurso(ingresante);
                    }
                    //curso1.agregarAlCurso(ing);
                    this.Vaciar();
                }
                else
                {
                    MessageBox.Show("verifique los datos e intente nuevamente");
                }

            }
            else
            {
                MessageBox.Show("Datos Descartados");

                this.Vaciar();

            }
        }

    }
}