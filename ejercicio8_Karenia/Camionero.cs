using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_Karenia
{
    class Camionero
    {
        string nombre;
        float poblacion;
        string telefono;
        string direccion;
        float salario;
        float rfc;

        public Camionero(string nombre, float poblacion, string telefono, string direccion, float salario, float rfc)
        {
            this.nombre = nombre;
            this.poblacion = poblacion;
            this.telefono = telefono;
            this.direccion = direccion;
            this.salario = salario;
            this.rfc = rfc;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Poblacion { get => poblacion; set => poblacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Salario { get => salario; set => salario = value; }
        public float Rfc { get => rfc; set => rfc = value; }
    }
}
