using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WServiceZHuasteca.Models;

namespace WServiceZHuasteca.Controllers
{
    public class DatosAlController : ApiController
    {
        //Se crea un metodo para el controlador DatosAlController de tipo IEnumerable de tipo cAlumno
        public IEnumerable<cAlumno> GetDatosGenerales(string claveunica, string facultad)
        {
            //Se crea un objeto de la clase CServicios.cs
            CServicios servicios = new CServicios();

            //se pasa la informacion que nos regresa el metodo Datos Generales a la variable queryDG que es la que va a traer la informacion final y puede consumirse
            var queryDG = servicios.DatosGenerales(claveunica, facultad);

            //Una vez que lo ejecutes uedes utilizar el postman o el navegador para probar el servicio web
            /*La URL seria algo asi: https://localhost:44336/api/DatosAl?idacceso={idacceso}&claveunica={claveunica}&facultad={facultad} */
            //La parte del localhost cambiaria a tu servidor donde los publicaria por ejemplo en mi caso seria https://sescolares.uaslp.mx/WebService/api/DatosAlExterno?claveunica=343434 

            return queryDG;
        }
    }
}
