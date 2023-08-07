using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NegociosBLL
    {
        NegocioDAL negDAL = new NegocioDAL();
        public List<TiendaMusica> ObtenerTiendasMusica()
        {
            List<TiendaMusica> lista = negDAL.ObtenerNegocios(1).Cast<TiendaMusica>().ToList();
            foreach (var negocio in lista)
            {
                Direccion dir = negDAL.ObtenerDireccionNegocio(negocio.Direccion.Id);
                negocio.CargarDireccion(dir);
            }
            return lista;
        }
    }
}
