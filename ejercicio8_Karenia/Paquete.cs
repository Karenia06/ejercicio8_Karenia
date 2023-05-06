using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_Karenia
{
    class Paquete
    {
        string codigo;
        string descripcion;
        string destinatario;
        string direccion;

        public Paquete(string codigo, string descripcion, string destinatario, string direccion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.destinatario = destinatario;
            this.direccion = direccion;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
