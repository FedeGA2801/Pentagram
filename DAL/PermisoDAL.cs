using BE.Permisos;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalasDAL;
using System.Data.SqlClient;

namespace DAL
{
    public class PermisoDAL
    {
        private readonly IDB _acceso;

        public PermisoDAL()
        {
            _acceso = new SqlDb();
        }

        public IList<Componente> GetComponentesPorUsuario(Usuario user)
        {
            var listaParams = new List<SqlParameter>();
            SqlParameter para1 = new SqlParameter("@idusuario", user.Id);
            para1.DbType = DbType.Int32;
            listaParams.Add(para1);
            List<Componente> listapermisos = new List<Componente>();
            DataTable datos = _acceso.Select("ObtenerPermisosRaizUsuario", listaParams);
            if (datos.Rows.Count > 0)
            {

                foreach (DataRow fila in datos.Rows)
                {
                    int idpermiso = fila.Field<int>("IdComponente");
                    string descripcionpermiso = fila.Field<string>("descripcion");
                    bool esFamilia = fila.Field<int>("esFamilia") == 0 ? false : true;
                    if (esFamilia)
                    {
                        //Creo familia
                        var familia = new Familia(idpermiso, descripcionpermiso);
                        GetComponentesRecursivo(familia);
                        listapermisos.Add(familia);
                    }
                    else
                    {
                        listapermisos.Add(new Patente(idpermiso, descripcionpermiso));
                    }
                }
                return listapermisos;
            }
            else
            {
                //error
                return listapermisos;
            }
        }

        public void GetComponentesRecursivo(Componente familia)
        {
            //Busco hijos (patente/familia) de la familia pasada por parametro
            IList<Componente> hijos = GetComponentesPorFamilia(familia);
            //Recorro la lista de hijos
            foreach (var hijo in hijos)
            {
                //Si un hijo es familia, tengo que ir a buscar a los hijos de este
                if (hijo is Familia)
                {
                    GetComponentesRecursivo(hijo);
                }
                familia.AgregarHijo(hijo);
            }
        }

        public IList<Componente> GetComponentesPorFamilia(Componente familia)
        {
            var listaParams = new List<SqlParameter>();
            SqlParameter para1 = new SqlParameter("@idpadre", familia.Codigo);
            para1.DbType = DbType.Int32;
            listaParams.Add(para1);

            DataTable datos = _acceso.Select("ObtenerComponentesPorFamilia", listaParams);
            List<Componente> listapermisos = new List<Componente>();
            if (datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int idpermiso = fila.Field<int>("idcomponente");
                    string descripcionpermiso = fila.Field<string>("descripcion");
                    bool esFamilia = fila.Field<int>("esFamilia") == 0 ? false : true;
                    if (esFamilia)
                    {
                        listapermisos.Add(new Familia(idpermiso, descripcionpermiso));
                    }
                    else
                    {
                        listapermisos.Add(new Patente(idpermiso, descripcionpermiso));
                    }
                }
                return listapermisos;
            }
            else
            {
                //error
                return listapermisos;
            }
        }
    }
}
