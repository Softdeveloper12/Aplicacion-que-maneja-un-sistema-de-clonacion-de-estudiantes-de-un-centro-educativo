using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea_3_Prog
{
    class Padres:ICloneable, Isaves
    {
        public string cedula;
        public string nombre;
        public string apellido;
        public string TipoSangre;
        public string SignoZodiacal;
        public string telefono;

        public object Clone()
        {
            return this.MemberwiseClone() as Padres;

        }
        public void Trabajar()
        {
            Console.WriteLine("Esta trabajando");

        }
        public void Comer()
        {
            Console.WriteLine("Esta comiendo");

        }
        public void Entretenimiento()
        {
            Console.WriteLine("Esta viendo Netflix");

        }
        public void save()
        {
            StreamWriter MiArchivo = File.AppendText("Prototypetxt");
            MiArchivo.WriteLine($"\nCedula:{this.cedula}\n-Nombre:{this.nombre}\n-Apellido:{this.apellido}\n-Tipo de Sangre:{this.TipoSangre}\n-Signo Zodiacal:{this.SignoZodiacal}\n-Telefono:{this.telefono}\n");
            MiArchivo.Close();

            Console.WriteLine("Listo");
            
        }



    }
}
