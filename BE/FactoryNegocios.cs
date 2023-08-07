using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FactoryNegocios
    {
        public Negocio CrearTiendaMusica(int idneg, string cuit, string nombre, string rutalogo, string descripcion, string urlpag, int iddir)
        {
            var negocio = new TiendaMusica(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir);
            return negocio;
        }

        // El método Factory Method para crear usuarios premium
        public Negocio CrearNegocioSalas(int idneg, string cuit, string nombre, string rutalogo, string descripcion, string urlpag, int iddir)
        {
            var negocio = new AlquilerSalas(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir);
            return negocio;
        }
    }
}
