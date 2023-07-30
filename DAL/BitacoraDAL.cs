using SalasDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraDAL
    {
        IDB acceso = new SqlDb();
        /*
        public List<EventoLog> ObtenerBitacora(DateTime desde, DateTime hasta, int user, int tipoEv)
        {
            var listaParams = new List<SqlParameter>();
            SqlParameter para1 = new SqlParameter("@desde", desde);
            para1.DbType = DbType.DateTime;
            SqlParameter para2 = new SqlParameter("@hasta", hasta);
            para2.DbType = DbType.DateTime;
            SqlParameter para3 = new SqlParameter("@idUsuario", user);
            para3.DbType = DbType.Int32;
            SqlParameter para4 = new SqlParameter("@tipoEvento", tipoEv);
            para4.DbType = DbType.Int16;

            listaParams.Add(para1);
            listaParams.Add(para2);
            listaParams.Add(para3);
            listaParams.Add(para4);

            DataTable datos = acceso.Select("ObtenerBitacora", listaParams);
            List<EventoLog> ret = new List<EventoLog>();
            if (datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int idEvento = fila.Field<int>("idEvento");
                    TipoEvento idTipoEvento = (TipoEvento)fila.Field<int>("idTipoEvento");
                    DateTime fechaEvento = fila.Field<DateTime>("fechaEvento");
                    int idUsuario = fila.Field<int>("idUsuario");
                    string username = fila.Field<string>("username");
                    string mensaje = fila.Field<string>("mensaje");

                    Usuario use = new Usuario(idUsuario, username);
                    EventoLog evento = new EventoLog(use, mensaje, idTipoEvento);
                    evento.Id = idEvento;
                    evento.FechaEvento = fechaEvento;
                    ret.Add(evento);
                }
            }
            return ret;
        }

        public void RegistrarActividad(EventoLog evento)
        {
            var listaParams = new List<IParametroDB>();
            ParametroDB<int> para1 = new ParametroDB<int>("@idUsuario", evento.Usuario != null ? evento.Usuario.Id : -1);
            ParametroDB<DateTime> para2 = new ParametroDB<DateTime>("@fechaevento", evento.FechaEvento);
            ParametroDB<string> para3 = new ParametroDB<string>("@mensaje", evento.Mensaje);
            ParametroDB<int> para4 = new ParametroDB<int>("@tipoEvento", (int)evento.TipoEvento);
            ParametroDB<long> para5 = new ParametroDB<long>("@dvh", evento.DVH);

            listaParams.Add(para1);
            listaParams.Add(para2);
            listaParams.Add(para3);
            listaParams.Add(para4);
            listaParams.Add(para5);

            int datos = acceso.Insert("RegistrarEvento", listaParams);

        }*/
    }
}
