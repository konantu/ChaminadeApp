using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDao
{
    public class ConexionDB
    {


        private static ConexionDB objConexionDB = null;
        private SqlConnection con;

        private ConexionDB()
        {
            //con = new SqlConnection("Data Source=LAPTOP-DAM54AGB\\MSSQLSERVER2012;Initial Catalog=ventas;Integrated Security=True");
            con = new SqlConnection("Data Source=wdb1.my-hosting-panel.com;Initial Catalog=konantu_josechaminade;User id=konantu_sa;Password=Chin9919;");

        }

        public static ConexionDB saberEstado()
        {
            if (objConexionDB == null)
            {
                objConexionDB = new ConexionDB();

            }
            return objConexionDB;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void closeDB()
        {
            objConexionDB = null;
        }
    }
}