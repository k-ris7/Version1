using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negProveedor
    {
        #region singleton
        private static readonly negProveedor _intancia = new negProveedor();
        public static negProveedor Instancia
        {
            get { return negProveedor._intancia; }
        }
        #endregion singleton

        #region metodos

        public int MantenimientoProveedor(entProveedor pr, int tipoedicion)
        {
            try
            {
                String cadXml = "";
                cadXml += "<proveedor ";
                cadXml += "idprove='" + pr.Id_Proveedor + "' ";
                cadXml += "razonsocial='" + pr.RazSocial_Proveedor + "' ";
                cadXml += "ruc='" + pr.Ruc_Proveedor + "' ";
                cadXml += "direccion='" + pr.Direccion_Proveedor + "' ";
                cadXml += "telefono='" + pr.Telefono_Proveedor + "' ";
                cadXml += "celular='" + pr.Celular_Proveedor + "' ";
                cadXml += "correo='" + pr.Correo_Proveedor + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int i = datProducto.Instancia.MantenimientoProveedor(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public entProveedor BuscarProveedor(int id_Prove)
        {
            try
            {
                entProveedor pr = null;
                pr = datProducto.Instancia.BuscarProveedor(id_Prove);
                if (pr == null) throw new ApplicationException("No se encontro registro en la BD");
                return pr;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProveedor> ListarProveedor()
        {
            try
            {
                List<entProveedor> Lista = null;
                Lista = datProducto.Instancia.ListarProveedor();
                //        if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion metodos
    }
}
