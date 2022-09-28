using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WServiceZHuasteca.Models
{
    public class CServicios
    {
        private string CadenaConexion()
        {
            //Cadeba de Conexion
            string cadena = "data source=148.***.***.***;initial catalog=usuario;user id=usuario;password=*******;database=Salinas";

            return cadena;
        }

        public IEnumerable<cAlumno> DatosGenerales(string claveunica, string facultad)
        {
            DataTable dtDG = new DataTable();
                     

            try
            {
                SqlConnection conexion = new SqlConnection(CadenaConexion());
                SqlDataAdapter sdaDatosGral;

                conexion.Open();

                string consulta = "SELECT * " +
                                    "FROM " +
                                    "WHERE ";

                // o mandar llamar el objeto que se genero en la base de datos con la consulta ej [Esquema].[Objeto]
                sdaDatosGral = new SqlDataAdapter(consulta, conexion);
                sdaDatosGral.Fill(dtDG);
                conexion.Close();
            }
            catch (SqlException error)
            {
                throw new ArgumentException("Error en la Base de Datos", error);
            }
      

            //Se pasn los valores al objeto cAlumno para despues mandar lo al controlador
            var idg = dtDG.AsEnumerable().Select(row =>
                new cAlumno
                {
                    ClaveUnica = row["cclave"].ToString(),
                    ApellidoPaterno = row["cpaterno"].ToString(),
                    ApellidoMaterno = row["cmaterno"].ToString(),
                    Nombre = row["cnombre"].ToString(),
                    ClaveEntidad = row["cclave"].ToString(),
                    Entidad = row["cdescripcio"].ToString(),
                    ClaveCarrera = row["ccarr"].ToString(),
                    Carrera = row["cconcepto"].ToString(),
                    Sexo = row["csexo"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(row["dfechanac"]),
                    CURP = row["ccurp"].ToString(),
                    Correo = row["cdircorreo"].ToString()
                });

            return idg;

        }

    }
}