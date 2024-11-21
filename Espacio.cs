using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal class Espacio
        {
            private string ubicacion;
            private int puertas;
            private int salidas;
            private double area;
            private string empresaDuenia;

            public string Ubicacion { get => ubicacion; set => ubicacion = value; }
            public int Puertas { get => puertas; set => puertas = value; }
            public int Salidas { get => salidas; set => salidas = value; }
            public double Area { get => area; set => area = value; }
            public string EmpresaDuenia { get => empresaDuenia; set => empresaDuenia = value; }

            public Espacio(string ubicacion, string empresaDuenia, int puertas, int salidas, double area)
            {

            }
            public void RegistrarEspacio(string empresaDuenia, string ubicacion)
            {

            }
            public void ComunicarEvento(string mensaje)
            {

            }
        }
    }
}
