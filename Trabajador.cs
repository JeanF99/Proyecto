using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        enum tipo_t
        {
            COORDINADOR,
            SERVICIO,
            TECNICO,
            DECORADOR
        }
        internal class Trabajador
        {
            private int idTrabajador;
            private string afp;
            private double sueldoBruto;
            private double pasaje;
            private double colacion;
            private double descuentoAfp;
            private double salud;
            private tipo_t tipoTrabajador;

            public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
            public double SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }
            public double Pasaje { get => pasaje; set => pasaje = value; }
            public double Colacion { get => colacion; set => colacion = value; }
            public double Salud { get => salud; set => salud = value; }
            public tipo_t TipoTrabajador { get => tipoTrabajador; set => tipoTrabajador = value; }

            public double Calcular_Sueldo(double sueldoBruto, double pasaje,
            double colacion, double descuentoAfp, double salud)
            {
                double sueldoLiquido;
                return sueldoLiquido;
            }

            public Trabajador(int idTrabajador, string afp, double sueldoBruto, double pasaje, double colacion, double descuentoAfp, double salud, tipo_t tipoTrabajador)
            {

            }

            public void MostrarDetalles(int idTrabajador)
            {

            }

            public void IngresarRegistro()
            {

            }

            public void ModificarRegistro()
            {

            }

            public void EliminarRegistro()
            {

            }
        }
    }

}
