using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WServiceZHuasteca.Models
{
    public class cAlumno
    {
        public string ClaveUnica { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public string CURP { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string ClaveEntidad { get; set; }
        public string Entidad { get; set; }
        public string ClaveCarrera { get; set; }
        public string Carrera { get; set; }

    }

}