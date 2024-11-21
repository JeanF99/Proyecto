using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal class Concierto
        {
            private string generoMusical;
            private int duracionEstimada;
            private string elementosProhibidos;

            public string GeneroMusical { get => generoMusical; set => generoMusical = value; }
            public int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
            public string ElementosProhibidos { get => elementosProhibidos; set => elementosProhibidos = value; }

            public Concierto(int duracionEstimada, string generoMusical)
            {

            }
            public void MostrarElementosProhibidos(string elementosProhibidos)
            {

            }
        }
    }
}
