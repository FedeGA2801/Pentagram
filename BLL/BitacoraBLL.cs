using DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraBLL
    {
        BitacoraDAL bitadal = new BitacoraDAL();
        /*
        public void ExportarArchivo(string archivo, List<EventoLog> listaEventos)
        {
            try
            {
                string json = JsonConvert.SerializeObject(listaEventos);
                File.WriteAllText(archivo, json);
                FormBLL formbll = new FormBLL();
                formbll.DarMensaje("OK_OperacionExitosa", 1);
            }
            catch (Exception ex)
            {
            }
        }

        public List<EventoLog> ObtenerBitacora(DateTime desde, DateTime hasta, int user, int tipoEv)
        {
            return bitadal.ObtenerBitacora(desde, hasta, user, tipoEv);
        }

        public void RegistrarActividad(string mensaje, TipoEvento tipo)
        {
            EventoLog evento = new EventoLog(SesionUsuario.GetInstance.Usuario, mensaje, tipo);
            evento.DVH = evento.CalcularDigitoHorizontal();
            bitadal.RegistrarActividad(evento);
            //Tengo que actualizar el DVV correspondiente
            DigitoBLL digitoBLL = new DigitoBLL();
            digitoBLL.ActualizarDVV("Bitacora");
        }

        internal void RegistrarActividadSinUser(string mensaje, TipoEvento tipo)
        {
            EventoLog evento = new EventoLog(null, mensaje, tipo);
            evento.DVH = evento.CalcularDigitoHorizontal();
            bitadal.RegistrarActividad(evento);
            //Tengo que actualizar el DVV correspondiente
            DigitoBLL digitoBLL = new DigitoBLL();
            digitoBLL.ActualizarDVV("Bitacora");
        }*/
    }
}
