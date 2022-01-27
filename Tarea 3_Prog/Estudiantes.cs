using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Tarea_3_Prog
{
    class Estudiantes:ICloneable,Isaves
    {
        public string matricula;
        public string nombre;
        public string apellido;
        public string edad;
        public string TipoSangre;
        public string carrera;
        public Implementacion ut;

        public object Clone()
        {
            Estudiantes cloneable=this.MemberwiseClone() as Estudiantes;
            Implementacion implementacion = new Implementacion();
            implementacion.nomPadre = this.ut.nomPadre;
            implementacion.Telpadre = this.ut.Telpadre;
            cloneable.ut = implementacion;
            return cloneable;
        }
        public void Estudiar()
        {
            Console.WriteLine("Esta estudiando");

        }
        public void Dormir()
        {
            Console.WriteLine("Esta durmiendo");

        }
        public void Entretenimiento()
        {
            Console.WriteLine("Esta jugando videojuegos");

        }
        public void save()
        {
            StreamWriter MiArchivo = File.AppendText("txt");
            MiArchivo.WriteLine($"\nMatricula:{this.matricula}\n-Nombre:{this.nombre}\n-Apellido:{this.apellido}\n-Edad:{this.edad}\n-Tipo de Sangre:{this.TipoSangre}\n-Carrera:{this.carrera}\n");
            MiArchivo.Close();
            Console.WriteLine("Listo");
        }
    }
}
