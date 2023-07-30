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

         

        public bool ObtenerCredencialesCriptograficas(Usuario user)
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
                    user.CargarCredencialesCriptograficas(contra, sal, iteraciones);
                    return true;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
            {
                //error
                return false;
            }
        }

        public void LoginUsuario(Usuario user)
        {
            SqlParameter para1 = new SqlParameter("@username", user.Username);
            para1.DbType = DbType.String;
            SqlParameter para2 = new SqlParameter("@password", user.PasswordCifrada);
            para2.DbType = DbType.Binary;

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
                    user.Id = iduser;
                }
            }
            else
            {
                //error
            }
        }
    }
}
