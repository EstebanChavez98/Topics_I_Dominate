using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APICrudCeuta.Data
{
    public class Conexion
    {
        public static string strIP = "DESKTOP-3IG31E1\\SQLEXPRESS", strBD = "CeutaIP";

        public string conexionDESK = "Data Source=" + strIP + ";Initial Catalog=" + strBD + ";Integrated Security=true;";
    }
}
