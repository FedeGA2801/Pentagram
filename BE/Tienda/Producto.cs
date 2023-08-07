using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.Tienda.Producto;

namespace BE.Tienda
{
    public class Producto : ICatalogo
    {
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public string MostrarInformacion()
        {
            return (Nombre + " - Precio: " + Precio);
        }
    }
}
