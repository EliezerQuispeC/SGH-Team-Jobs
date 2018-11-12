using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class HistorialClinico
    {//COD_Especialidad, Fecha de Apertura, Peso, Talla, DNI_Paciente
        public int CodigoHistorial { get; set; }
        public string COD_Especialidad { get; set; }
        public DateTime FechaApertura { get; set; }
        public double Peso { get; set; }
        public double Talla { get; set; }
        public string DNI_Paciente { get; set; }

        public HistorialClinico (int CodigoHistorial, string codEspecialidad, DateTime fechaApertura, double peso, double talla, string dni)
        {
            this.CodigoHistorial = CodigoHistorial;
            this.COD_Especialidad = codEspecialidad;
            this.FechaApertura = fechaApertura;
            this.Peso = peso;
            this.Talla = talla;
            this.DNI_Paciente = dni;
        }
    }
}
