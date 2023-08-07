using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FactoryUsuarios
    {
        public Usuario CrearUsuarioNormal(string nombre, int id)
        {
            var usuario = new UsuarioNormal(id, nombre);
            return usuario;
        }

        // El método Factory Method para crear usuarios premium
        public Usuario CrearUsuarioNegocio(string nombre, int id)
        {
            var usuario = new UsuarioNegocio(id, nombre);
            return usuario;
        }
    }
}
