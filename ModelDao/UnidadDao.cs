using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;

namespace ModelDao
{
    public class UnidadDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;
        public UnidadDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }

        public List<Unidad> GetUnidad()
        {
            List<Unidad> listaUnidad = new List<Unidad>();
            string find = "EXECUTE traeUnidad";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Unidad objUnidad = new Unidad();
                    objUnidad.IdUnidad = Convert.ToInt16(reader[0].ToString());
                    objUnidad.NombreUnidad = reader[1].ToString();
                    //objUnidad.FechaHoraUnidad = Convert.ToDateTime(reader[2].ToString());

                    listaUnidad.Add(objUnidad);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexionDB.getCon().Close();
                objConexionDB.closeDB();
            }

            return listaUnidad;
        }
    }
}
