using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        enum tipo_proveedor
        {
            MUSICA,
            CATERING,
            SEGURIDAD,
            INFRAESTRUCTURA
        }
        internal class Proveedor
        {
            private int idProveedor;
            private string nombre;
            private string servicio;
            private tipo_proveedor proveedor;

            public int IdProveedor { get => idProveedor; set => idProveedor = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Servicio { get => servicio; set => servicio = value; }
            internal tipo_proveedor Proveedor { get => proveedor; set => proveedor = value; }

            public Proveedor(string nombre, string servicio,
            int cantidadTrabajadores, tipo_proveedor proveedor)
            {

            }

            public void BuscarProveedorPorNombree(string nombre)
            {

            }
            public void CantidadTrabajadores()
            {

            }
            public void MostrarProveedor(int idProveedor)
            {

            }
        }
    }
}
