using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AlquilerSalas : Negocio
    {
        public AlquilerSalas(int idneg, string cuit, string nombre, string rutalogo, string descripcion, string urlpag, int iddir) : base(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir)
        {
        }
    }
}
