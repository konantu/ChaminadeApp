using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;

namespace ModelDao
{
    public class FormaPagoDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;
        public FormaPagoDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }

        public List<FormaPago> GetFormaPago()
        {
            List<FormaPago> listaFormaPago = new List<FormaPago>();
            string find = "EXECUTE traeFormaPago";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    FormaPago objFormaPago = new FormaPago();
                    objFormaPago.IdFormaPago = Convert.ToInt16(reader[0].ToString());
                    objFormaPago.NombreFormaPago = reader[1].ToString();
                    //objFormaPago.FechaHoraFormaPago = Convert.ToDateTime(reader[2].ToString());

                    listaFormaPago.Add(objFormaPago);
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

            return listaFormaPago;
        }
    }
}
