﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForm
{
    public class Ingresante
    {
        public string nombre;
        public string direccion;
        public int edad;
        public string cuit;
        public string genero;
        public string pais;
        public string[] curso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public Ingresante() { }

        public Ingresante(string nombre, string direccion, int edad,string cuit, string genero, string pais, string[] curso)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Curso = curso;
            this.Pais = pais;
        }

        public Ingresante(string nombre, string cuit, string genero, int edad, string pais, string direccion)
        {
            this.Nombre = nombre;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Edad = edad;
            this.Pais = pais;
            this.Direccion = direccion;
        }

        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Dirección: {Direccion}");
            stringBuilder.AppendLine($"Edad: {Edad}");
            stringBuilder.AppendLine($"Cuit: {Cuit}");
            stringBuilder.AppendLine($"Género: {Genero}");
            stringBuilder.AppendLine($"País: {Pais}");
            
            return stringBuilder.ToString();
        }

        public String ToStringCursos() {
            return "Los cursos seleccionados son: \n" + curso[0] + "\n" + curso[1] + "\n" + curso[2];
        }


        public void Guardar()
        {
            //guardar en archivo 
            Console.WriteLine("ASDASD");
        }


    }
}
