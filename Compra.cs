using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Compras
    {
        internal class Compra
        {
            private int id;
            private DateTime fecha;

            public int Id { get => id; set => id = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }

            public Compra(int id, DateTime fecha)
            {

            }
            public void Compra(List<Entrada> entradas)
            {

            }
        }
    }
}
