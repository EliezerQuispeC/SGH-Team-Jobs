using System;
using System.Reflection;


namespace AccesoDatos
{
    public class PacientesDAL
    {
        public static string ConexionPacientes()
        {
            string pathBDPacientes = System.IO.Path.GetDirectoryName(
                Assembly.GetEntryAssembly().Location);//GetEntryAssembly():Obtiene el ejecutable del proceso en el dominio de aplicación predeterminado.
            return pathBDPacientes;
        }
    }
}
    
