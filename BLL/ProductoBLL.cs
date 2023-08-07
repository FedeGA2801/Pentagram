using BE.Tienda;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL prodDAL = new ProductoDAL();
        public List<Categoria> ObtenerArbolCategoriasXNegocio(int idnegocio)
        {
            return prodDAL.ObtenerArbolCategoriasXNegocio(idnegocio);
        }
    }
}
