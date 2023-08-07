using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tienda
{
    public class Categoria : ICatalogo
    {
        public int Id { get; set; }
        private List<ICatalogo> productos;

        public string Nombre { get; private set; }
        public int _id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Categoria(string nombre)
        {
            Nombre = nombre;
            productos = new List<ICatalogo>();
        }

        public Categoria(int id, string nombre, List<ICatalogo> lista)
        {
            Id = id;
            Nombre = nombre;
            productos = lista;
        }

        public void AgregarProducto(ICatalogo producto)
        {
            productos.Add(producto);
        }

        public List<ICatalogo> ObtenerProductos()
        {
            return productos;
        }

        public string MostrarInformacion()
        {
            return Nombre;
        }
    }
}
