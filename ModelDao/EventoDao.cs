using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;

namespace ModelDao
{
    public class EventoDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;
        public EventoDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }

        public List<Evento> GetEvento()
        {
            List<Evento> listaEvento = new List<Evento>();
            string find = "EXECUTE traeEvento";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Evento objEvento = new Evento();
                    objEvento.IdEvento = Convert.ToInt16(reader[0].ToString());
                    objEvento.NombreEvento = reader[1].ToString();
                    //objEvento.FechaHoraEvento = Convert.ToDateTime(reader[2].ToString());

                    listaEvento.Add(objEvento);
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

            return listaEvento;
        }
    }
}
