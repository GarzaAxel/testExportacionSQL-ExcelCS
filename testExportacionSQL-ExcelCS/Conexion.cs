using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace testExportacionSQL_ExcelCS
{
    internal class Conexion
    {
        public static SqlConnection Conectar() 
        { 
            SqlConnection con = new SqlConnection("SERVER=DESKTOP-R538THL; DATABASE=pubs;" +
                " Integrated security=true");

            con.Open();
            return con;
        }
  
    }
}
