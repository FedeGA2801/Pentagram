using BE.Tienda;
using SalasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {
        private readonly IDB _acceso;

        public ProductoDAL()
        {
            _acceso = new SqlDb();
        }

        public List<Categoria> ObtenerArbolCategoriasXNegocio(int idnegocio)
        {
            throw new NotImplementedException();
        }
    }
}
