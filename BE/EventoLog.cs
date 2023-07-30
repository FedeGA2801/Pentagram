using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EventoLog : IDigitoVerificador
    {
        private int _id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Mensaje { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public long DVH { get; set; }

        public EventoLog(Usuario user, string msg, TipoEvento tipoEvento)
        {
            Usuario = user;
            FechaEvento = DateTime.Now;
            Mensaje = msg;
            TipoEvento = tipoEvento;
        }


        public int CalcularDigitoHorizontal()
        {
            //byte[] props = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes((Usuario != null ? Usuario.Id : -1) + FechaEvento.ToString() + Mensaje + (int)TipoEvento));
            //var valor = BitConverter.ToInt32(props, 0) % 1000000;
            return 0;
        }

        public string FechaEventoSt
        {
            get
            {
                return FechaEvento.ToShortDateString();
            }
        }

        public string TipoEventoSt
        {
            get
            {
                return Enum.GetName(typeof(TipoEvento), TipoEvento);
            }
        }
    }
}
