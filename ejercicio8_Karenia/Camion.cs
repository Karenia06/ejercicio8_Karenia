using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_Karenia
{
    class Camion
    {
        float potencia;
        string matricula;
        string modelo;
        string tipo;

        public Camion(float potencia, string matricula, string modelo, string tipo)
        {
            this.potencia = potencia;
            this.matricula = matricula;
            this.modelo = modelo;
            this.tipo = tipo;
        }

        public float Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
