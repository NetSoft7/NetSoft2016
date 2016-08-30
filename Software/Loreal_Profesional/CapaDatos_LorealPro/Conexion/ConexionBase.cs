using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaDatos_LorealPro
{
    public class ConexionBase
    {

        protected string cadenaConexion = ConexionSQL.LeerConexion();
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public DataTable Datos { get; set; }

    }
}
