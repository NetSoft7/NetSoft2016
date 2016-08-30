using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_LorealPro
{
    class Cat_ClientesOrganizador : ConexionBase
    {
        public System.Nullable<int> IdOrganizador { get; set; }
        public string Nombre { get; set; }
        public System.Nullable<int> TieneHijos { get; set; }
        public System.Nullable<int> IdOrganizadorPadre { get; set; }

        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ClientesOrganizador_Seleccionar";
                _dato.Entero = IdOrganizador;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizador");
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = TieneHijos;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "TieneHijos");
                _dato.Entero = IdOrganizadorPadre;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizadorPadre");
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
        public void MtdInsertar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ClientesOrganizador_Insertar";
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = TieneHijos;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "TieneHijos");
                _dato.Entero = IdOrganizadorPadre;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizadorPadre");
                _conexion.EjecutarDataset();
                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Exito = _conexion.Exito;
                    Mensaje = _conexion.Mensaje;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
        public void MtdModificar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ClientesOrganizador_Modificar";
                _dato.Entero = IdOrganizador;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizador");
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = TieneHijos;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "TieneHijos");
                _dato.Entero = IdOrganizadorPadre;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizadorPadre");
                _conexion.EjecutarNonQuery();
                Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        public void MtdEliminar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ClientesOrganizador_Eliminar";
                _dato.Entero = IdOrganizador;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdOrganizador");
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
