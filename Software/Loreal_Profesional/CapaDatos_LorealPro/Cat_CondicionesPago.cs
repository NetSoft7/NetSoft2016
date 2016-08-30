using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_LorealPro
{
    class Cat_CondicionesPago:ConexionBase
    {
        public System.Nullable<int> IdCondicionesPago { get; set; }
        public string Nombre { get; set; }
        public System.Nullable<int> Dias { get; set; }
        public System.Nullable<int> IdStatusPersona { get; set; }

        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            this.Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_CondicionesPago_Seleccionar";
                _dato.Entero = this.IdCondicionesPago;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCondicionesPago");
                _dato.CadenaTexto = this.Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = this.Dias;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Dias");
                _dato.Entero = this.IdStatusPersona;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdStatusPersona");
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
                _conexion.NombreProcedimiento = "SPR_CondicionesPago_Insertar";
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = Dias;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Dias");
                _dato.Entero = IdStatusPersona;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdStatusPersona");
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
                _conexion.NombreProcedimiento = "SPR_CondicionesPago_Modificar";
                _dato.Entero = IdCondicionesPago;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCondicionesPago");
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.Entero = Dias;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Dias");
                _dato.Entero = IdStatusPersona;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdStatusPersona");

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
                _conexion.NombreProcedimiento = "SPR_CondicionesPago_Eliminar";
                _dato.Entero = this.IdCondicionesPago;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCondicionesPago");
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
