using BE.Permisos;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermisoBLL
    {
        PermisoDAL permiDAL = new PermisoDAL();
        public IList<Componente> ObtenerPermisosUser(Usuario user)
        {
            return permiDAL.GetComponentesPorUsuario(user);
        }
    }
}
