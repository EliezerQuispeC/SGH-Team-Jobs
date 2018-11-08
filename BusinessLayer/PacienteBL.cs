using System;
using System.Collections.Generic;
using Entities;
using AccesoDatos;

namespace BusinessLayer
{
    public class PacienteBL
    {
        public static List<Paciente> Listpacientes;

        public List<Paciente> GetPacientes()
        {
            string path = PacientesDAL.ConexionPacientes();
            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Pacientes.txt");
            Listpacientes = new List<Paciente>();
            foreach (var item in lines)
            {
                string Dni = item.Split(',')[0];
                string Nombre = item.Split(',')[1];
                string Apellido = item.Split(',')[2];
                Paciente p = new Paciente(Dni, Nombre, Apellido);
                Listpacientes.Add(p);
            }
            return Listpacientes;
        }
    }
}
