﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Persona
    {
        private int rut;
        private int verificador;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private int telefono;

        public int Rut { get => rut; set => rut = value; }
        public int Verificador { get => verificador; set => verificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Persona(int rut, int verificador, int telefono, string nombre, string apellidPaterno, string apellidoMaterno, DateTime fechaNacimiento)
        {

        }
        public void MostrarDetalles()
        {

        }
    }
}