using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos_LorealPro
{
    class Cat_ProveedoresContactos : ConexionBase
    {
        public System.Nullable<int> ContactosProveedoresReg { get; set; }
        public System.Nullable<int> IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }

        public void MtdSeleccionar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ProveedoresContactos_Seleccionar";
                _dato.Entero = ContactosProveedoresReg;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "ContactosProveedoresReg");
                _dato.Entero = IdProveedor;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdProveedor");
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.CadenaTexto = Puesto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Puesto");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
                _dato.CadenaTexto = Email;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Email");
                _dato.CadenaTexto = FechaNacimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaNacimiento");
                
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
                _conexion.NombreProcedimiento = "SPR_ProveedoresContactos_Insertar";
                _dato.Entero = ContactosProveedoresReg;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "ContactosProveedoresReg");
                _dato.Entero = IdProveedor;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdProveedor");
                _dato.CadenaTexto = Nombre;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Nombre");
                _dato.CadenaTexto = Puesto;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Puesto");
                _dato.CadenaTexto = Telefono;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Telefono");
                _dato.CadenaTexto = Email;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Email");
                _dato.CadenaTexto = FechaNacimiento;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaNacimiento");

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
        public void MtdEliminar()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SPR_ProveedoresContactos_Eliminar";
                _dato.Entero = IdProveedor;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdProveedor");
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
