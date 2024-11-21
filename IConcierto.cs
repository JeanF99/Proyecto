using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal interface IConcierto
        {
            public string Ubicacion();
            public int Puertas();
            public int Salidas();

            public void RegistrarEspacio()
            {

            }
            public void ComunicarEvento()
            {

            }
        }
    }
}
