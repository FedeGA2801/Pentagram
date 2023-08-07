using BE;
using SalasDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        private readonly IDB _acceso;

        public UsuarioDAL()
        {
            _acceso = new SqlDb();
        }

        public void AltaUsuario(LoginUser loginUser, Credenciales cred)
        {
            SqlParameter para1 = new SqlParameter("@username", loginUser.Username);
            para1.SqlDbType = SqlDbType.NVarChar;
            SqlParameter para2 = new SqlParameter("@password", cred.Password);
            para2.SqlDbType = SqlDbType.VarBinary;
            SqlParameter para3 = new SqlParameter("@iteraciones", cred.Iteraciones);
            para3.SqlDbType = SqlDbType.Int;
            SqlParameter para4 = new SqlParameter("@sal", cred.Sal);
            para4.SqlDbType = SqlDbType.VarBinary;
            SqlParameter para5 = new SqlParameter("@tipo", 1);
            para5.SqlDbType = SqlDbType.Int;

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                para1,
                para2,
                para3,
                para4,
                para5
            };

            _acceso.Insert("AltaUsuario", parametros);
        }
    }
}
