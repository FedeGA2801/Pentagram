using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tienda
{
    public interface ICatalogo
    {
        int Id {  get; set; }
        string Nombre { get; }
        string MostrarInformacion();
    }
}
