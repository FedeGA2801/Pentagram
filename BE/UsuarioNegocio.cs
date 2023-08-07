using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioNegocio : Usuario
    {
        private int _idNegocio { get; set; }
        public UsuarioNegocio(int id, string username) : base(id, username)
        {
        }

        public int NegocioPadre
        {
            get { return _idNegocio;}
        }
    }
}
