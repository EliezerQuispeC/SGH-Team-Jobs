using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Cita
    {
        public string COD_Cita { get; set; }
        public string DNI_Paciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string COD_Especialidad { get; set; }
        public string COD_Doctor { get; set; }
        public string TipoCita { get; set; }
        public string Estado { get; set; }

        public Cita(string COD_Cita, string DNI_Paciente, string Nombres, string Apellidos, string COD_Especialidad, string COD_Doctor, string TipoCita , string Estado = "PENDIENTE")
        {
            this.COD_Cita = COD_Cita;
            this.DNI_Paciente = DNI_Paciente;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.COD_Especialidad = COD_Especialidad;
            this.COD_Doctor = COD_Doctor;
            this.TipoCita = TipoCita;
            this.Estado = Estado;
        }
    }
}
