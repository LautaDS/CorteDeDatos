using System;
using System.IO;
using System.Collections.Generic;

namespace CorteDeDatos
{
    // El ejercicio era complejo e interesante, pero fuimos recibiendo tanta tarea que opte por concentrarme en descubrir 
    // como hacer para levantar un csv y procesar sus datos e irme a hacer los ejercicios de clases y objetos por que me hace falta
    // la practica.
    class ReadingCSV
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"D:\Bootcamp\Dia3\CorteDeDatos\Datos.csv"));
            List<EmpleadoLegajo> legajosEmpleados = new List<EmpleadoLegajo>();
            

            while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    EmpleadoLegajo _tempEmpleado = new EmpleadoLegajo();

                    _tempEmpleado.ID = values[0];
                    _tempEmpleado.Nombre = values[1];
                    _tempEmpleado.nSueldos = values[2];
                    _tempEmpleado.fecha = values[3];

                    legajosEmpleados.Add(_tempEmpleado);  

                }


            foreach (EmpleadoLegajo empleado in legajosEmpleados)
                {
                    Console.WriteLine("ID: " + empleado.ID);
                    Console.WriteLine("Nombre de empleado: " + empleado.Nombre);
                    Console.WriteLine("Sueldos a cobrar: "+ empleado.nSueldos);
                    Console.WriteLine("Fecha de ingreso de datos: " + empleado.fecha);
                 }
                Console.ReadLine();
        }
    }

    class EmpleadoLegajo
    {
        public string ID;
        public string Nombre;
        public string nSueldos;
        public string fecha;

      
    }
}
