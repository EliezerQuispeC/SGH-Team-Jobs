using System;
using BusinessLayer;
using Entities;

namespace SGH
{
    class Program
    {
        static void Main(string[] args)
        {
            PacienteBL pacienteBL = new PacienteBL();
            var Pacientes = pacienteBL.GetPacientes();
            foreach (var item in Pacientes)
            {
                Console.WriteLine($"{item.DNI_Paciente},{item.Nombres},{item.Apellidos},{item.FechaNacimiento},{item.Tipo}");
                Console.Write("Probando ");
            }
            Console.ReadKey();
        }
    }
}
