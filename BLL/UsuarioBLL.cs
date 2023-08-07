using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL userDAL = new UsuarioDAL();
        public void AltaUsuario(LoginUser loginUser, Credenciales credenciales)
        {
            userDAL.AltaUsuario(loginUser, credenciales);
        }
    }
}
