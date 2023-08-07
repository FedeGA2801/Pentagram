using BE.Excepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PentaExcepcion : Exception
    {
        private int _codError { get; set; }
        private GravedadError _gravedad { get; set; }
        public PentaExcepcion(string msg, GravedadError gravedad, Exception inner) : base(msg, inner)
        {
            _gravedad = gravedad;
        }

        public PentaExcepcion(int codErr, GravedadError gvedad)
        {
            _codError = codErr;
            _gravedad = gvedad;
        }
    }
}
