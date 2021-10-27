using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmPuesto
    {
        public static DataTable Listar()
        {
            string query = "Select Nombre FROM dbo.Puesto";

            SqlDataAdapter adapter = new SqlDataAdapter(query, AdminBD.ConectarBD());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Puestos");

            return ds.Tables["Puestos"];
        }
    }
}
