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

        public void cargarInfo(Ingresante ingresante)
        {
            // Obtener la ruta de la carpeta Descargas del usuario
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, this.nombre+".txt");

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                // Si el archivo no existe, agregar el ingresante
                File.WriteAllText(filePath, formatoIngresante(ingresante));
            }
            else
            {
                // using garantiza que se elimina la variable writer al final del ámbito en el que se utiliza. 
                // agrega el ingresante al archivo
                agregarAlCurso(filePath, ingresante);
                
                /*using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(formatoIngresante(ingresante));
                }*/
            }            
        }

        public string formatoIngresante(Ingresante ingresante)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ingresante.Nombre).Append("|");
            sb.Append(ingresante.Cuit.Replace("-", "")).Append("|");
            sb.Append(ingresante.Genero).Append("|");
            sb.Append(ingresante.Edad).Append("|");
            sb.Append(ingresante.Pais).Append("|");
            sb.Append(ingresante.Direccion);
            return sb.ToString();
        }

        public void agregarAlCurso(string path, Ingresante ingresante)
        {
            // Leemos todas las líneas del archivo y las guardamos en un arreglo de cadenas
            string[] lista_ingresantes = File.ReadAllLines(path);

            if(lista_ingresantes.Length < 40)
            {            
                // Inicializamos una variable booleana para indicar si el ingresante ya existe en el archivo
                bool ingresanteExiste = false;
                StringBuilder cursos_success = new StringBuilder();

                // Recorremos cada registro en el archivo
                foreach (string registro in lista_ingresantes)
                {
                    // Dividimos el registro en partes usando el carácter "|" como separador
                    string[] partes = registro.Split('|');

                    // Extraemos el CUIT de cada registro
                    string cuit = partes[1];

                    // Comparamos el DNI con el Cuit del ingresante
                    if (ingresante.Cuit.Replace("-","") == cuit)
                    {
                        // Si el Cuit ya existe en el archivo, seteamos la variable existe a true
                        ingresanteExiste = true;
                        string message_error = "El ingresante con CUIT " + ingresante.Cuit + " ya existe en el curso: " + this.Nombre;
                        MessageBox.Show(message_error, "Error: Ingresante Duplicado", MessageBoxButtons.OK);
                        break;
                    }                                                                
                    
                }

                // Si el Cuit no existe en el archivo, agregamos el nuevo ingresante
                if (!ingresanteExiste)
                {
                    // Abrimos el archivo en modo de agregar texto
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        // Escribimos el nuevo registro en el archivo

                        try
                        {
                            writer.WriteLine(formatoIngresante(ingresante));
                        }                        
                        catch (Exception e)
                        {
                            Console.Write(e.ToString());
                        }
                    }

                    cursos_success.AppendLine(this.Nombre);
                    MessageBox.Show("Se anoto con exito a: \n" + cursos_success.ToString());
                }                
            }
            else
            {
                MessageBox.Show("Hay 40 o más registros para este curso");
            }
        }
    }
}
