using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDB
    {
        DataTable Select(string storedProcedure, List<SqlParameter> listaParams);
        int Insert(string storedProcedure, List<SqlParameter> listaParams);
        bool Delete(string storedProcedure, List<SqlParameter> listaParams);
        bool Update(string storedProcedure, List<SqlParameter> listaParams);

        string CreateBackup(string rutaDestino);
        void RestoreBackup(string rutaArchivo);
        void lala();
    }
}
