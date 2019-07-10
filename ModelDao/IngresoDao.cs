using ModelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDao
{
    public class IngresoDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;

        public IngresoDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }
            public List<Ingreso> GenerarFolioIngreso(Ingreso objIngreso)
        
            {
            List<Ingreso> listaIngreso = new List<Ingreso>();
            string find = "EXECUTE GenerarFolioIngreso 'lruiz'";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                                
                while (reader.Read())
                {


                    objIngreso.FolioIngreso = Convert.ToInt64 (reader[0].ToString());
                    /*                    objIngreso.NombreHabilitado = (reader[1].ToString());
                                        objIngreso.DireccionFocalizado = (reader[2].ToString());
                                        objIngreso.CiudadFocalizado = (reader[3].ToString());
                                        objIngreso.TelefonoFocalizado = (reader[4].ToString());
                                        objContactoHabilitado.EmailFocalizado = (reader[5].ToString());
                    */
                    listaIngreso.Add(objIngreso);
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
            return listaIngreso;
        }

        //
        public List<Ingreso> TraeEncabezadoIngreso(Ingreso objIngreso)

        {
            List<Ingreso> listaIngreso = new List<Ingreso>();
            //Ingreso objIngreso = new Ingreso();
            string find = "EXECUTE TraeEncabezadoIngreso " + objIngreso.FolioIngreso;
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {


                    objIngreso.FolioIngreso = Convert.ToInt64(reader[0].ToString());
                    objIngreso.IdFormaPago = Convert.ToInt64(reader[1].ToString());
                    objIngreso.TotalIngreso = Convert.ToInt64(reader[2].ToString());
                    objIngreso.FechaIngreso = Convert.ToDateTime(reader[3].ToString());
                    objIngreso.PagadorIngreso = (reader[4].ToString());
                    objIngreso.ObservacionesIngreso = (reader[5].ToString());
                    objIngreso.EstadoIngreso = Convert.ToInt16 (reader[6].ToString());
                    objIngreso.IdUser = (reader[7].ToString());
                    objIngreso.FechaHoraIngreso = Convert.ToDateTime(reader[8].ToString());

                    listaIngreso.Add(objIngreso);
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
            return listaIngreso;
        }

        public string ActualizaEncabezado(Ingreso objIngresos)
        {
            string resultado = "";
            string create = "Execute ActualizaEncabezado '" + objIngresos.FolioIngreso + "','" + objIngresos.IdFormaPago + "','" + objIngresos.FechaIngreso + "','" + objIngresos.PagadorIngreso + "','" + objIngresos.ObservacionesIngreso + "','" + objIngresos.IdEstadoIngreso + "','" + objIngresos.IdUser + "'";
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

