using System;
using System.Collections.Generic;
using Entities;
using AccesoDatos;

namespace BusinessLayer
{
    public class PacienteBL
    {
        public static List<Paciente> Listpacientes;

        public void GuardarPaciente(Paciente persona)
        {

        }
        public List<Paciente> GetPacientes()
        {
            string path = PacientesDAL.ConexionPacientes();//Devuelve LA siguiente ruta del debug: C:\Users\eliez\Documents\GitHub\SGH-Team-Jobs\SGH\bin\Debug\netcoreapp2.1

            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Pacientes.txt");
            Listpacientes = new List<Paciente>();
            foreach (var item in lines)
            {
                string Dni = item.Split(',')[0];
                string Nombre = item.Split(',')[1];
                string Apellido = item.Split(',')[2];
                string FechaNacimiento = item.Split(',')[3];
                string Tipo = item.Split(',')[4];
                Paciente p = new Paciente(Dni, Nombre, Apellido, FechaNacimiento, Tipo);
                Listpacientes.Add(p);
            }
            return Listpacientes;
        }

    }
}
