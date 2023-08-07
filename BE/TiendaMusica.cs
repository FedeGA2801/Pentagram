using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TiendaMusica : Negocio
    {
        public TiendaMusica(int idneg, string cuit, string nombre, string rutalogo, string descripcion, string urlpag, int iddir) : base(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir)
        {
        }
    }
}
