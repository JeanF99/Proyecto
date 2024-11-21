using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal class Evento
        {
            enum tipo_estado
            {
                PLANEADO,
                EN_PROGRESO,
                FINALIZADO,
                CANCELADO
            }
            private int idEvento;
            private string nombre;
            private DateTime fecha;
            private int costo;
            private tipo_estado tipo;

            public int IdEvento { get => idEvento; set => idEvento = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public int Costo { get => costo; set => costo = value; }
            public tipo_estado Tipo { get => tipo; set => tipo = value; }

            public Evento(int evento, int costo, string nombre,
            DateTime fecha, tipo_estado tipo)
            {

            }

            public void MostrarDetalle(int idEvento)
            {

            }
        }
    }
}
