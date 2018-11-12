using System;

namespace Entities
{
    public class Paciente
    {//Cada atributo se creó con la clave prop más doble tab|<->|
        public string DNI_Paciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Tipo { get; set; }

        public Paciente(string dni, string nombre, string apellido, string fechaNacimiento, string tipo)
        {
            this.DNI_Paciente = dni;
            this.Nombres = nombre;
            this.Apellidos = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Tipo = tipo;
        }

        public Paciente RegistrarPaciente()
        {
            Console.WriteLine("INGRESE SU DNI");
            string dni = Console.ReadLine();

            Console.WriteLine("INGRESE SU NOMBRE");
            string Nombre = Console.ReadLine();

            Console.WriteLine("INGRESE SU APELLIDO");
            string Apellido = Console.ReadLine();

            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO");
            string FechaNacimiento = Console.ReadLine();

            Console.WriteLine("ES USTED ASEGURADO S/N");
            string Tipo = Console.ReadLine();
            if(Tipo == "si")
            {
                Tipo = "ASEGURADO";
            }
            else
            {
                Tipo = "PARTICULAR";
            }
            Paciente persona = new Paciente(dni, Nombre, Apellido, FechaNacimiento, Tipo);
            Console.WriteLine("EL PACIENTE SE HA CREADO EXITOSAMENTE");
            return persona;
        }


    }
}
