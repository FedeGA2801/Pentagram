using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Direccion
    {
        private int _id { get; set; }
        private int _nroCalle { get; set; }
        private string _calle { get; set; }
        private int? _piso { get; set; }
        private string _departamento { get; set; }
        private int _codPostal { get; set; }
        private string _localidad { get; set; }
        private string _provincia { get; set; }
        private string _extra { get; set; }

        public Direccion(int id, int nroCalle, string calle, int? piso, string departamento, int codPostal, string localidad, string provincia, string extra)
        {
            _id = id;
            _nroCalle = nroCalle;
            _calle = calle;
            _piso = piso;
            _departamento = departamento;
            _codPostal = codPostal;
            _localidad = localidad;
            _provincia = provincia;
            _extra = extra;
        }

        public bool esDepartamento
        {
            get { return _departamento != null && _piso != -1; }
        }

        public Direccion(int id)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
        }

        public string DireccionCompleta
        {
            get
            {
                return _calle + " " + _nroCalle + "(" + _codPostal + ")";
            }
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }
        }

        public string Localidad
        {
            get
            {
                return _localidad;
            }
        }
    }
}
