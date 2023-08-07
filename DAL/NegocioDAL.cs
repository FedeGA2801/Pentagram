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
    public class NegocioDAL
    {
        private readonly IDB _acceso;

        public NegocioDAL()
        {
            _acceso = new SqlDb();
        }

        public List<Negocio> ObtenerNegocios(int tipo)
        {
            SqlParameter para1 = new SqlParameter("@tipo", tipo);
            para1.SqlDbType = SqlDbType.Int;

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                para1
            };

            DataTable datos = _acceso.Select("ObtenerNegocios", parametros);
            List<Negocio> lista = new List<Negocio>();
            if (datos.Rows.Count > 0)
            {
                try
                {
                    FactoryNegocios factoryNegocios = new FactoryNegocios();
                    foreach (DataRow fila in datos.Rows)
                    {
                        int idneg = fila.Field<int>("idnegocio");
                        string cuit = fila.Field<string>("cuit");
                        string nombre = fila.Field<string>("nombre");
                        string rutalogo = fila.Field<string>("logo");
                        string descripcion = fila.Field<string>("descripcion");
                        int iddir = fila.Field<int>("iddireccion");
                        string urlpag = fila.Field<string>("urlpaginaoficial");
                        Negocio neg;
                        switch (tipo)
                        {
                            case 1:
                                lista.Add(factoryNegocios.CrearTiendaMusica(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir));
                                break;
                            case 2:
                                lista.Add(factoryNegocios.CrearNegocioSalas(idneg, cuit, nombre, rutalogo, descripcion, urlpag, iddir));
                                break;
                            default:
                                break;
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
            {
                //error
                return lista;
            }
        }

        public Direccion ObtenerDireccionNegocio (int iddireccion)
        {
            SqlParameter para1 = new SqlParameter("@iddireccion", iddireccion);
            para1.SqlDbType = SqlDbType.Int;

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                para1
            };

            DataTable datos = _acceso.Select("ObtenerDireccionNegocio", parametros);
            if (datos.Rows.Count > 0)
            {
                try
                {
                    DataRow fila = datos.Rows[0];
                    int iddir = Convert.ToInt16(fila["iddireccion"]);
                    int nrocalle = Convert.ToInt16(fila["nrocalle"]);
                    string calle = fila["calle"].ToString();
                    int piso = fila["piso"] != DBNull.Value ? Convert.ToInt32(fila["piso"]) : -1;
                    string departamento = fila["departamento"] != DBNull.Value ? fila["departamento"].ToString() : null;
                    int codpostal = Convert.ToInt32(fila["codpostal"]);
                    string extra = fila["extra"].ToString();
                    string localidad = fila["localidad"].ToString();
                    string provincia = fila["provincia"].ToString();
                    Direccion dir = new Direccion(iddir, nrocalle, calle, piso, departamento, codpostal, localidad, provincia, extra);
                    return dir;
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
    }
}