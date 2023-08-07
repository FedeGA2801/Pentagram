using BE;
using SalasDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        private readonly IDB _acceso;

        public LoginDAL()
        {
            _acceso = new SqlDb();
        }



        public Credenciales ObtenerCredencialesCriptograficas(LoginUser user)
        {
            SqlParameter para1 = new SqlParameter("@username", user.Username);
            para1.SqlDbType = SqlDbType.NVarChar;

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                para1
            };

            DataTable datos = _acceso.Select("ObtenerCredencialesCriptograficas", parametros);
            if (datos.Rows.Count > 0)
            {
                try
                {
                    byte[] sal = datos.Rows[0].Field<byte[]>("sal");
                    int iteraciones = datos.Rows[0].Field<int>("iteraciones");
                    byte[] contra = Services.Encriptacion.CrearHashPBKDF2(user.Password, sal, iteraciones);
                    Credenciales cred = new Credenciales(contra, sal, iteraciones);
                    return cred;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
            {
                //error
                return null;
            }
        }

        public Usuario LoginUsuario(LoginUser user, Credenciales cred)
        {
            SqlParameter para1 = new SqlParameter("@username", user.Username);
            para1.SqlDbType = SqlDbType.NVarChar;
            SqlParameter para2 = new SqlParameter("@password", cred.Password);
            para2.SqlDbType = SqlDbType.VarBinary;

            var listaParams = new List<SqlParameter>
            {
                para1,
                para2
            };

            DataTable datos = _acceso.Select("AutenticarUsuario", listaParams);
            if (datos.Rows.Count == 1)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int iduser = fila.Field<int>("idUsuario");
                    int idtipo = fila.Field<int>("idtipousuario");
                    FactoryUsuarios factory = new FactoryUsuarios();
                    switch (idtipo)
                    {
                        case 1:
                            return factory.CrearUsuarioNormal(user.Username, iduser);
                        case 2:
                            return factory.CrearUsuarioNegocio(user.Username, iduser);
                    }
                }
                return null;
            }
            else
            {
                //error
                return null;
            }
        }
    }
}
