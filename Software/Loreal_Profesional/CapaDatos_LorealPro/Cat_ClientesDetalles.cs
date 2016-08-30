using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_LorealPro
{
    class Cat_ClientesDetalles : ConexionBase
    {
        public System.Nullable<int> IdCliente { get; set; }
        public decimal VentasAcumuladas { get; set; }
        public System.Nullable<int> ServiciosAcumulados { get; set; }
        public string FechaAlta { get; set; }
        public string FechaUModificacion { get; set; }
        public string FechaUVenta { get; set; }
        public string Notas { get; set; }
	
        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ClientesDetalles_Seleccionar";
                _dato.Entero = IdCliente;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCliente");
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
                _conexion.NombreProcedimiento = "SPR_ClientesDetalles_Insertar";
                _dato.Entero = IdCliente;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCliente");
                _dato.DecimalValor = VentasAcumuladas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "VentasAcumuladas");
                _dato.Entero = ServiciosAcumulados;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "ServiciosAcumulados");
                _dato.CadenaTexto = FechaAlta;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaAlta");
                _dato.CadenaTexto = FechaUModificacion;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaUModificacion");
                _dato.CadenaTexto = FechaUVenta;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaUVenta");
                _dato.CadenaTexto = Notas;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Notas");
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
                _conexion.NombreProcedimiento = "SPR_ClientesDetalles_Modificar";
                _dato.Entero = IdCliente;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCliente");
                _dato.DecimalValor = VentasAcumuladas;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "VentasAcumuladas");
                _dato.Entero = ServiciosAcumulados;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "ServiciosAcumulados");
                _dato.CadenaTexto = FechaAlta;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaAlta");
                _dato.CadenaTexto = FechaUModificacion;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaUModificacion");
                _dato.CadenaTexto = FechaUVenta;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "FechaUVenta");
                _dato.CadenaTexto = Notas;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Notas");
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
                _conexion.NombreProcedimiento = "SPR_ClientesDetalles_Eliminar";
                _dato.Entero = IdCliente;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdCliente");
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
