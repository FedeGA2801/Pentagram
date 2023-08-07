using BE.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Usuario
    {
        private int _id { get; set; }
        private string _username { get; set; }
        private IList<Componente> _permisos { get; set; }

        public Usuario(int id, string username)
        {
            _id = id;
            _username = username;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void CargarPermisos(IList<Componente> permisos)
        {
            _permisos = permisos;
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }
    }
}
