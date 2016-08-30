using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace CapaDatos_LorealPro
{
    public class SEG_Login:ConexionBase
    {
        public System.Nullable<int> IdUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Correo { get; set; }
        public System.Nullable<int> IsRestablecerContrasenia { get; set; }
        public string UltimoAcceso { get; set; }

        public void MtdSeleccionarUsuarioLogin()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_SEGLoginSeleccionar";
                _dato.CadenaTexto = Contrasenia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Contrasenia");
                _dato.CadenaTexto = Correo;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Correo");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        public void MtdModificarUsuarioFechaAcceso()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_SEGLoginFechaAccesoModificar";

                _dato.Entero = IdUsuario;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdUsuario");

                _conexion.EjecutarNonQuery();
                Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        public void MtdModificarUsuarioRestablecerContrasenia()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_SEGLoginContraseniaModificar";
                _dato.CadenaTexto = Contrasenia;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Contrasenia");
                _dato.Entero = IdUsuario;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdUsuario");
                _dato.Entero = IsRestablecerContrasenia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IsRestablecerContrasenia");

                _conexion.EjecutarNonQuery();
                Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
    }
}
