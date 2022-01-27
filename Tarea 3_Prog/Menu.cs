using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea_3_Prog
{
    class Menu
    {
        public void menu()
        {
            //Padre Original
            Padres padres = new Padres();
            padres.cedula = "402-2991929-5";
            padres.nombre = "Edward";
            padres.apellido = "Acosta";
            padres.SignoZodiacal = "Cancer";
            padres.TipoSangre = "A+";
            padres.telefono = "809-902-0256";



            //Estudiante Original
            Estudiantes est = new Estudiantes();
            est.ut = new Implementacion();
            est.matricula = "2019-9065";
            est.nombre = "Eduardo";
            est.apellido = "Acosta";
            est.edad = "20";
            est.TipoSangre = "A+";
            est.carrera = "Ingenieria de Software";
            est.ut.nomPadre = padres.nombre;
            est.ut.Telpadre = padres.telefono;



            //--------------------------Clones Superficiales Padres------------------------//

            Padres padreclon = (Padres)padres.Clone();
            padreclon.nombre = "Javier";
            padreclon.SignoZodiacal = "Capricornio";
            padreclon.TipoSangre = "A-";
            padreclon.telefono = "809-899-0157";


            Padres padreclon2 = (Padres)padres.Clone();
            padreclon2.nombre = "Rayner";
            padreclon2.SignoZodiacal = "Piscis";
            padreclon2.TipoSangre = "AB+";
            padreclon2.telefono = "809-889-0358";


            Padres padreclon3 = (Padres)padres.Clone();
            padreclon3.nombre = "Juan";
            padreclon3.SignoZodiacal = "Sagitario";
            padreclon3.TipoSangre = "AB-";
            padreclon3.telefono = "809-333-2121";
            //---------------------------------------------------------//

            //-------------------------------------Clones Profundos------------------------------//

            Estudiantes estclon = (Estudiantes)est.Clone();
            estclon.matricula = "100523948";
            estclon.nombre = "Liz";
            estclon.apellido = "Reynoso";
            estclon.ut.nomPadre = padreclon.nombre;
            estclon.ut.Telpadre = padreclon.telefono;



            Estudiantes estclon2 = (Estudiantes)est.Clone();
            estclon2.matricula = "100566898";
            estclon2.nombre = "Irianny";
            estclon2.apellido = "Zapata";
            estclon2.ut.nomPadre = padreclon2.nombre;
            estclon2.ut.Telpadre = padreclon2.telefono;




            Estudiantes estclon3 = (Estudiantes)est.Clone();
            estclon3.matricula = "100546999";
            estclon3.nombre = "Luis Daniel";
            estclon3.apellido = "Medina";
            estclon3.ut.nomPadre = padreclon3.nombre;
            estclon3.ut.Telpadre = padreclon3.telefono;

            //-----------------------------------------------------------------------------//


            Console.WriteLine("\nBienvenido al programa del sistema de Administracion de Centro Educativo:");
            Console.WriteLine("\nIngrese la fase que desea:");
            Console.WriteLine("1- Fase Padres");
            Console.WriteLine("2- Fase Alumnos");
            
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("\n1- Fase Padre original");
                    Console.WriteLine("\n2- Fase Clones superficiales");
                    Console.WriteLine("\n3- Fase Paquete Completo ");
                   
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                    {
                        Console.WriteLine("\n///Padre Original///");
                        Console.WriteLine($"\nCedula:{padres.cedula}\nNombre:{padres.nombre}\nApellido:{padres.apellido}\n Signo del Zodiaco:{padres.SignoZodiacal}\nTipo de sangre:{padres.TipoSangre}\nTelefono:{padres.telefono}");
                        Console.WriteLine("Presione Enter para volver al menu principal......");

                        Console.WriteLine("\nFunciones:");
                        padres.Trabajar();
                        Console.WriteLine("");
                        padres.Comer();
                        Console.WriteLine("");
                        padres.Entretenimiento();

                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else if (opt == 2)
                    {
                        Console.WriteLine("\n///Primer Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon.cedula}\nNombre:{padreclon.nombre}\nApellido:{padreclon.apellido}\n Signo del Zodiaco:{padreclon.SignoZodiacal}\nTipo de sangre:{padreclon.TipoSangre}\nTelefono:{padreclon.telefono}");

                        Console.WriteLine("\nFunciones:");

                        padreclon.Trabajar();
                        Console.WriteLine("");
                        padreclon.Comer();
                        Console.WriteLine("");
                        padreclon.Entretenimiento();

                        Console.WriteLine("\n///Segundo Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon2.cedula}\nNombre:{padreclon2.nombre}\nApellido:{padreclon2.apellido}\n Signo del Zodiaco:{padreclon2.SignoZodiacal}\nTipo de sangre:{padreclon2.TipoSangre}\nTelefono:{padreclon2.telefono}");

                        Console.WriteLine("\nFunciones:");
                        padreclon2.Trabajar();
                        Console.WriteLine("");
                        padreclon2.Comer();
                        Console.WriteLine("");
                        padreclon2.Entretenimiento();

                        Console.WriteLine("\n///Tercer Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon3.cedula}\nNombre:{padreclon3.nombre}\nApellido:{padreclon3.apellido}\n Signo del Zodiaco:{padreclon3.SignoZodiacal}\nTipo de sangre:{padreclon3.TipoSangre}\nTelefono:{padreclon3.telefono}");
                        Console.WriteLine("Presione Enter para volver al menu principal......");

                        Console.WriteLine("\nFunciones:");

                        padreclon3.Trabajar();
                        Console.WriteLine("");
                        padreclon3.Comer();
                        Console.WriteLine("");
                        padreclon3.Entretenimiento();


                        Console.ReadKey();
                        Console.Clear();
                        menu();

                    }
                    else if(opt== 3)
                    {
                        Console.WriteLine("\n ///Fase De Paquete Completo///");
                        Console.WriteLine("\n///Padre Original///");
                        Console.WriteLine($"\nCedula:{padres.cedula}\nNombre:{padres.nombre}\nApellido:{padres.apellido}\n Signo del Zodiaco:{padres.SignoZodiacal}\nTipo de sangre:{padres.TipoSangre}\nTelefono:{padres.telefono}");

                        Console.WriteLine("\nFunciones:");
                        padres.Trabajar();
                        Console.WriteLine("");
                        padres.Comer();
                        Console.WriteLine("");
                        padres.Entretenimiento();

                        Console.WriteLine("\n///Primer Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon.cedula}\nNombre:{padreclon.nombre}\nApellido:{padreclon.apellido}\n Signo del Zodiaco:{padreclon.SignoZodiacal}\nTipo de sangre:{padreclon.TipoSangre}\nTelefono:{padreclon.telefono}");

                        Console.WriteLine("\nFunciones:");

                        padreclon.Trabajar();
                        Console.WriteLine("");
                        padreclon.Comer();
                        Console.WriteLine("");
                        padreclon.Entretenimiento();

                        Console.WriteLine("\n///Segundo Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon2.cedula}\nNombre:{padreclon2.nombre}\nApellido:{padreclon2.apellido}\n Signo del Zodiaco:{padreclon2.SignoZodiacal}\nTipo de sangre:{padreclon2.TipoSangre}\nTelefono:{padreclon2.telefono}");

                        Console.WriteLine("\nFunciones:");
                        padreclon2.Trabajar();
                        Console.WriteLine("");
                        padreclon2.Comer();
                        Console.WriteLine("");
                        padreclon2.Entretenimiento();

                        Console.WriteLine("\n///Tercer Clon:///");
                        Console.WriteLine($"\nCedula:{padreclon3.cedula}\nNombre:{padreclon3.nombre}\nApellido:{padreclon3.apellido}\n Signo del Zodiaco:{padreclon3.SignoZodiacal}\nTipo de sangre:{padreclon3.TipoSangre}\nTelefono:{padreclon3.telefono}");

                        Console.WriteLine("\nFunciones:");

                        padreclon3.Trabajar();
                        Console.WriteLine("");
                        padreclon3.Comer();
                        Console.WriteLine("");
                        padreclon3.Entretenimiento();

                        Console.WriteLine("Presione cualquier tecla para guardar los datos...");
                        Console.ReadKey();
                        
                        padres.save();
                        padreclon.save();
                        padreclon2.save();
                        padreclon3.save();

                        Console.WriteLine("Presione Enter para volver al menu principal......");
                        Console.ReadKey();
                        Console.Clear();
                        menu();

                    }
                    else
                    {
                        menu();
                    }

                    break;
                case 2:
                    Console.WriteLine("1- Fase Estudiante original");
                    Console.WriteLine("2- Fase Clones Profundos");
                    Console.WriteLine("3- Fase Paquete Completo");
                    
                    int dec=int.Parse(Console.ReadLine());
                    if (dec == 1)
                    { Console.WriteLine("\n///Fase de Estudiante Original");

                        Console.WriteLine($"\nMatricula:{est.matricula}\nNombre:{est.nombre}\nApellido:{est.apellido}\nEdad::{est.edad}\nTipo de sangre:{est.TipoSangre}\nCarrera:{est.carrera}\n Nombre del padre:{est.ut.nomPadre}\nTelefono del padre:{est.ut.Telpadre}");
      
                        Console.WriteLine("\nFunciones:");

                        est.Estudiar();
                        est.Dormir();
                        est.Entretenimiento();

                        Console.WriteLine("\nPresione Enter para volver al menu principal......");

                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else if(dec== 2)
                    {
                        Console.WriteLine("\n///Fase de Clones Profundos///");

                        Console.WriteLine("\n//Primer Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon.matricula}\nNombre:{estclon.nombre}\nApellido:{estclon.apellido}\nEdad::{estclon.edad}\nTipo de sangre:{estclon.TipoSangre}\nCarrera:{estclon.carrera}\n Nombre del padre:{estclon.ut.nomPadre}\nTelefono del padre:{estclon.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon.Estudiar();
                        estclon.Dormir();
                        estclon.Entretenimiento();

                        Console.WriteLine("\n//Segundo Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon2.matricula}\nNombre:{estclon2.nombre}\nApellido:{estclon2.apellido}\nEdad::{estclon2.edad}\nTipo de sangre:{estclon2.TipoSangre}\nCarrera:{estclon2.carrera}\n Nombre del padre:{estclon2.ut.nomPadre}\nTelefono del padre:{estclon2.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon2.Estudiar();
                        estclon2.Dormir();
                        estclon2.Entretenimiento();

                        Console.WriteLine("\n//Tercer Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon3.matricula}\nNombre:{estclon3.nombre}\nApellido:{estclon3.apellido}\nEdad::{estclon3.edad}\nTipo de sangre:{estclon3.TipoSangre}\nCarrera:{estclon3.carrera}\n Nombre del padre:{estclon3.ut.nomPadre}\nTelefono del padre:{estclon3.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon3.Estudiar();
                        estclon3.Dormir();
                        estclon3.Entretenimiento();

                        Console.WriteLine("\nPresione Enter para volver al menu principal......");

                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else if (dec == 3)
                    {
                        Console.WriteLine("\n///Fase Paquete Completo///");

                        Console.WriteLine("\n//Fase de Estudiante Original");

                        Console.WriteLine($"\nMatricula:{est.matricula}\nNombre:{est.nombre}\nApellido:{est.apellido}\nEdad::{est.edad}\nTipo de sangre:{est.TipoSangre}\nCarrera:{est.carrera}\n Nombre del padre:{est.ut.nomPadre}\nTelefono del padre:{est.ut.Telpadre}");
                        Console.WriteLine("\nFunciones:");

                        est.Estudiar();
                        est.Dormir();
                        est.Entretenimiento();

                        Console.WriteLine("\n//Primer Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon.matricula}\nNombre:{estclon.nombre}\nApellido:{estclon.apellido}\nEdad::{estclon.edad}\nTipo de sangre:{estclon.TipoSangre}\nCarrera:{estclon.carrera}\n Nombre del padre:{estclon.ut.nomPadre}\nTelefono del padre:{estclon.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon.Estudiar();
                        estclon.Dormir();
                        estclon.Entretenimiento();

                        Console.WriteLine("\n//Segundo Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon2.matricula}\nNombre:{estclon2.nombre}\nApellido:{estclon2.apellido}\nEdad::{estclon2.edad}\nTipo de sangre:{estclon2.TipoSangre}\nCarrera:{estclon2.carrera}\n Nombre del padre:{estclon2.ut.nomPadre}\nTelefono del padre:{estclon2.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon2.Estudiar();
                        estclon2.Dormir();
                        estclon2.Entretenimiento();

                        Console.WriteLine("\n//Tercer Clon Profundo:");

                        Console.WriteLine($"\nMatricula:{estclon3.matricula}\nNombre:{estclon3.nombre}\nApellido:{estclon3.apellido}\nEdad::{estclon3.edad}\nTipo de sangre:{estclon3.TipoSangre}\nCarrera:{estclon3.carrera}\n Nombre del padre:{estclon3.ut.nomPadre}\nTelefono del padre:{estclon3.ut.Telpadre}");

                        Console.WriteLine("\nFunciones:");

                        estclon3.Estudiar();
                        estclon3.Dormir();
                        estclon3.Entretenimiento();

                        Console.WriteLine("\nPresione cualquier tecla para guardar los datos....");
                        Console.ReadKey();
                        est.save();
                        estclon.save();
                        estclon2.save();
                        estclon3.save();


                        Console.WriteLine("\nPresione Enter para volver al menu principal......");



                        Console.ReadKey();
                        Console.Clear();
                        menu();
                    }
                    else
                    {
                        menu();
                    }

                    break;
                default:
                    Console.WriteLine("Default Value!!");
                    Console.WriteLine("\nPresione Enter para volver al menu....");
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    
                    break;
                    
            }
        }
    }
}
