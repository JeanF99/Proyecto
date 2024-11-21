using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        internal interface IPersonal
        {
            public int Rut();
            public int Verificador();
            public string Nombre();
            public string ApellidoPaterno();
            public string ApellidoMaterno();
            public DateTime FechaNacimiento();
            public int Telefono();

            public void IngresarRegistro()
            {

            }
            public void ModificarRegistro()
            {

            }
            public void EliminarRegistro()
            {

            }
            public void MostrarDetalles()
            {

            }
        }
    }
}
