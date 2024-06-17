using System.Text;

namespace BibliotecaDeClases
{
    public class Ingresante
    {
        string nombre;
        string direccion;
        int edad;
        string cuit;
        string genero;
        string pais;
        string[] curso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public Ingresante(string nombre, string direccion, int edad, string cuit, string genero, string pais, string[] curso)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Curso = curso;
            this.Pais = pais;
        }
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Nombre: {Nombre}\n");
            str.Append($"Direccion: {Direccion}\n");
            str.Append($"Edad: {Edad}\n");
            str.Append($"Cuit: {Cuit}\n");
            str.Append($"Genero: {Genero}\n");
            str.Append($"Pais: {Pais}\n");
            return str.ToString();
        }
        public string MostrarCursos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cursos: ");

            foreach (var item in Curso)
            {
                sb.Append($"{item}\n");
            }

            return sb.ToString();
        }

        public List<string> Guardar()
        {
            List<string> respuesta = new List<string>();
            string ubicacion = Directory.GetCurrentDirectory();
            string archivoCSharp = ubicacion + "\\CSharp.txt";
            string archivoCPlus = ubicacion + "\\CPlus.txt";
            string archivoJavaScript = ubicacion + "\\JavaScript.txt";

            foreach (var item in Curso)
            {
                if (item == "C#")
                {
                    int contadorEstudiantes = 0;
                    string line;
                    bool ingresanteExistente = false;
                    if (File.Exists(archivoCSharp))
                    {
                        using StreamReader reader = new StreamReader(archivoCSharp);
                        while ((line = reader.ReadLine()) != null)
                        {
                            contadorEstudiantes++;
                            var array = line.Split("|");
                            if (array[3] == Cuit)
                            {
                                ingresanteExistente = true;
                                respuesta.Add($"El usuario {Cuit} ya existe en c#");
                            }
                        }
                    }

                    if (contadorEstudiantes >= 40)
                    {
                        respuesta.Add("El archivo de C# ya está lleno con 3 estudiantes.");
                    }
                    else if (!ingresanteExistente)
                    {
                        using (StreamWriter csharp = new StreamWriter(archivoCSharp, true))
                        {
                            csharp.WriteLine(string.Concat(Nombre, "|", Direccion, "|", Edad, "|", Cuit, "|", Genero, "|", Pais));
                            respuesta.Add($"El usuario {Cuit} fue agregado a C#");
                        }
                    }

                    continue;
                }



                if (item == "C++")
                {
                    string line;
                    bool ingresanteExistente = false;
                    int contadorEstudiantes = 0;
                    if (File.Exists(archivoCPlus))
                    {
                        using StreamReader reader = new StreamReader(archivoCPlus);

                        while ((line = reader.ReadLine()) != null)
                        {
                            contadorEstudiantes++;
                            var array = line.Split("|");
                            if (array[3] == Cuit)
                            {
                                ingresanteExistente = true;
                                respuesta.Add($"El usuario {Cuit} ya existe en c++");
                            }
                        }
                    }

                    if (contadorEstudiantes >= 40)
                    {
                        respuesta.Add("El archivo de C++ ya está lleno con 3 estudiantes.");
                    }
                    else if (!ingresanteExistente)
                    {
                        using (StreamWriter cplus = new StreamWriter(archivoCPlus, true))
                        {
                            cplus.WriteLine(string.Concat(Nombre, "|", Direccion, "|", Edad, "|", Cuit, "|", Genero, "|", Pais));
                            respuesta.Add($"El usuario {Cuit} fue agregado a C++");
                        }
                    }

                    continue;
                }

                if (item == "JavaScript")
                {
                    string line;
                    bool ingresanteExistente = false;
                    int contadorEstudiantes = 0;


                    if (File.Exists(archivoJavaScript))
                    {
                        using StreamReader reader = new StreamReader(archivoJavaScript);
                        while ((line = reader.ReadLine()) != null)
                        {
                            contadorEstudiantes++;
                            var array = line.Split("|");
                            if (array[3] == Cuit)
                            {
                                ingresanteExistente = true;
                                respuesta.Add($"El usuario {Cuit} ya existe en JavaScript");
                            }
                        }
                    }

                    if (contadorEstudiantes >= 40)
                    {
                        respuesta.Add("El archivo de JavaScript ya está lleno con 3 estudiantes.");
                    }
                    else if (!ingresanteExistente)
                    {
                        using (StreamWriter js = new StreamWriter(archivoJavaScript, true))
                        {
                            js.WriteLine(string.Concat(Nombre, "|", Direccion, "|", Edad, "|", Cuit, "|", Genero, "|", Pais));
                            respuesta.Add($"El usuario {Cuit} fue agregado a JavaScript");
                        }
                    }

                    continue;
                }
            }
            return respuesta;
        }
    }

}

