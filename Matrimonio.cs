using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace  Proyecto
{
    namespace Proyecto.Eventos
    {
        enum matri_tipo
        {
            CLASICO,
            VINTAGE,
            MODERNO,
            MONOCROMATICO,
            COLORIDO
        }
        internal class Matrimonio
        {
            private int numeroInvitados;
            private string novio;
            private string novia;
            private string ubicacionCeremonia;
            private matri_tipo tipo;

            public int NumeroInvitados { get => numeroInvitados; set => numeroInvitados = value; }
            public string Novio { get => novio; set => novio = value; }
            public string Novia { get => novia; set => novia = value; }
            public string UbicacionCeremonia { get => ubicacionCeremonia; set => ubicacionCeremonia = value; }
            public matri_tipo Tipo { get => tipo; set => tipo = value; }

            public Matrimonio(int numeroInvitados, string novio,
            string novia, string ubicacionCeremonia, matri_tipo tipo)
            {

            }

            public void MostrarDetalles()
            {

            }
        }

    }
}
