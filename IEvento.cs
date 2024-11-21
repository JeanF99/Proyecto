using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal interface IEvento
        {
            public void IngresarEvento();
            public void ModificarEvento();
            public void EliminarEvento();
        }
    }
}
