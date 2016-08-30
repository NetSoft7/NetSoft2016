using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_LorealPro
{
    class Cat_RegistroTributario : ConexionBase
    {
        public System.Nullable<int> IdRegistroTributario { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }

        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_RegistroTributario_Seleccionar";
                _dato.Entero = this.IdRegistroTributario;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdRegistroTributario");
                _dato.CadenaTexto = this.Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.CadenaTexto = this.Siglas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Siglas");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    this.Datos = _conexion.Datos;
                }
                else
                {
                    this.Mensaje = _conexion.Mensaje;
                    this.Exito = false;
                }
            }
            catch (Exception e)
            {
                this.Mensaje = e.Message;
                this.Exito = false;
            }

        }
        public void MtdInsertar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_RegistroTributario_Insertar";
                _dato.CadenaTexto = this.Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.CadenaTexto = this.Siglas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Siglas");
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
                this.Mensaje = e.Message;
                this.Exito = false;
            }
        }
        public void MtdModificar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_RegistroTributario_Modificar";
                _dato.Entero = this.IdRegistroTributario;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdRegistroTributario");
                _dato.CadenaTexto = this.Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.CadenaTexto = this.Siglas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Siglas");
                _conexion.EjecutarNonQuery();
                this.Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                this.Mensaje = e.Message;
                this.Exito = false;
            }

        }
        public void MtdEliminar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_RegistroTributario_Eliminar";
                _dato.Entero = this.IdRegistroTributario;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdRegistroTributario");
                _conexion.EjecutarNonQuery();
                this.Exito = _conexion.Exito;
            }
            catch (Exception e)
            {
                this.Mensaje = e.Message;
                this.Exito = false;
            }

        }
    }
}
