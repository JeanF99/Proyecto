using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal interface IProveedor
        {
            public void BuscarProveedorPorNombre();
            public void CantidadTrabajadores();
            public void MostrarProveedor();
        }
    }
}
