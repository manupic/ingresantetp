using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForm
{
    internal class Curso
    {
        string nombre;
        ArrayList lista_ingresantes = new ArrayList();

        public Curso() { }

        public Curso(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }


        public void agregarAlCurso(Ingresante ingresante)
        {
            lista_ingresantes.Add(ingresante); 
            //AGREGA AL TXT
        }

    }




}
