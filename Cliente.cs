using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        internal class Cliente
        {
            private int idCliente;
            private int presupuesto;

            public int IdCliente { get => idCliente; set => idCliente = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }

            public string MostrarDetalles(int idCliente)
            {

            }
        }
    }

}
