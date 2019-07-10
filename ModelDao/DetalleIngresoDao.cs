using ModelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelDao
{
    public class DetalleIngresoDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;

        public DetalleIngresoDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }
       
        public List<DetalleIngreso> TraeDetalleIngreso(DetalleIngreso objDetalleIngresos)

        {
            List<DetalleIngreso> listaDetalleIngreso = new List<DetalleIngreso>();
            //Ingreso objDetalleIngreso = new Ingreso();
            string find = "EXECUTE TraeDetalleIngreso " + objDetalleIngresos.FolioIngreso;
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    DetalleIngreso objDetalleIngreso = new DetalleIngreso();

                    objDetalleIngreso.IdDetalleIngreso = Convert.ToInt64(reader[0].ToString());
                    objDetalleIngreso.FolioIngreso = Convert.ToInt64(reader[1].ToString());
                    objDetalleIngreso.RutMiembro = (reader[2].ToString());
                    objDetalleIngreso.NombreCompletoMiembro = (reader[3].ToString());
                    objDetalleIngreso.IdUnidad = Convert.ToInt64(reader[4].ToString());
                    objDetalleIngreso.NombreUnidad = (reader[5].ToString());
                    objDetalleIngreso.IdEvento = Convert.ToInt64(reader[6].ToString());
                    objDetalleIngreso.NombreEvento = (reader[7].ToString());
                    objDetalleIngreso.ObservacionesIngreso = (reader[8].ToString());
                    objDetalleIngreso.MontoIngreso = Convert.ToInt64(reader[9].ToString());
                    

                    listaDetalleIngreso.Add(objDetalleIngreso);
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
            return listaDetalleIngreso;
        }

        public string EliminaDetalleIngreso(DetalleIngreso objDetalleIngresos)
        {
            string resultado = "";
            string create = "Execute EliminaDetalleIngreso '" + objDetalleIngresos.IdDetalleIngreso + "','" + objDetalleIngresos.FolioIngreso + "','" + objDetalleIngresos.IdUsuario + "'";
            try
            {
                comando = new SqlCommand(create, objConexionDB.getCon());
                objConexionDB.getCon().Open();

                //RECUPERAR EL CODIGO AUTOGENERADO
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    resultado = reader[0].ToString();
                }

            }
            catch (Exception e)
            {
                resultado = "1";
            }
            finally
            {
                objConexionDB.getCon().Close();
                objConexionDB.closeDB();
            }
            return resultado;

        }

        //InsertaDetalleIngreso
        public string InsertaDetalleIngreso(DetalleIngreso objDetalleIngresos)
        {
            string resultado = "";
            string create = "Execute InsertaDetalleIngreso '" + objDetalleIngresos.FolioIngreso + "','" + objDetalleIngresos.RutMiembro + "','" + objDetalleIngresos.IdEvento + "','" + objDetalleIngresos.ObservacionesIngreso + "','" + objDetalleIngresos.MontoIngreso + "','" + objDetalleIngresos.IdUsuario + "'";
            try
           {
                comando = new SqlCommand(create, objConexionDB.getCon());
                objConexionDB.getCon().Open();

                //RECUPERAR EL CODIGO AUTOGENERADO
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    resultado = reader[0].ToString();
                }

            }
            catch (Exception e)
            {
                resultado = "1";
            }
            finally
            {
                objConexionDB.getCon().Close();
                objConexionDB.closeDB();
            }
            return resultado;

        }

    }
}

