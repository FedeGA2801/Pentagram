using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Negocio
    {
        private int _id { get;set; }
        private string _nombre { get;set; }
        private string _cuit { get; set; }
        private string _urlLogo { get; set; }
        private string _descripcion { get; set; }
        private string _urlPagina { get; set; }

        private Direccion _direccion { get; set; }

        public void CargarDireccion(Direccion dir)
        {
            _direccion = dir;
        }


        public Negocio(int idneg, string cuit, string nombre, string rutalogo, string descripcion, string urlpag, int iddir)
        {
            _id = idneg;
            _nombre = nombre;
            _cuit = cuit;
            _urlLogo = rutalogo;
            _descripcion = descripcion;
            _urlPagina = urlpag;
            _direccion = new Direccion(iddir);
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string UrlLogo
        {
            get
            {
                return "LogosNegocios/" + _urlLogo;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }

        public Direccion Direccion
        {
            get
            {
                return _direccion;
            }
        }

        public string PaginaOficial
        {
            get
            {
                return _urlPagina;
            }
        }

    }
}
