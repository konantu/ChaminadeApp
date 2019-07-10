using ModelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDao
{
    public class MiembroDao
    {
        private ConexionDB objConexionDB;
        private SqlCommand comando;
        private SqlDataReader reader;
        public MiembroDao()
        {
            objConexionDB = ConexionDB.saberEstado();
        }

        public List<Miembro> FindAllTop50Miembro()
        {
            List<Miembro> listaMiembro = new List<Miembro>();
            string find = "EXECUTE FindAllTop50Miembro";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Miembro objMiembro = new Miembro();
                    objMiembro.RutMiembro = (reader[0].ToString());
                    objMiembro.NombresMiembro = reader[1].ToString();
                    objMiembro.PaternoMiembro  = reader[2].ToString();
                    objMiembro.MaternoMiembro  = reader[3].ToString();
                    objMiembro.NombreCompletoMiembro  = reader[4].ToString();
                    objMiembro.UnidadMiembro  = reader[5].ToString();
                    objMiembro.TipoMiembro = reader[6].ToString();

                    listaMiembro.Add(objMiembro);
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

            return listaMiembro;
        }

        //
        public List<Miembro> FindMiembroPorNombre(Miembro objMiembro)
        {
            List<Miembro> listaMiembro = new List<Miembro>();
            string find = "EXECUTE FindMiembroPorNombre '" + objMiembro.TextoBuscar.ToString()+ "'";
            try
            {
                comando = new SqlCommand(find, objConexionDB.getCon());
                objConexionDB.getCon().Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Miembro objMiembros = new Miembro();
                    objMiembros.RutMiembro = (reader[0].ToString());
                    objMiembros.NombresMiembro = reader[1].ToString();
                    objMiembros.PaternoMiembro = reader[2].ToString();
                    objMiembros.MaternoMiembro = reader[3].ToString();
                    objMiembros.NombreCompletoMiembro = reader[4].ToString();
                    objMiembros.UnidadMiembro = reader[5].ToString();
                    objMiembros.TipoMiembro = reader[6].ToString();

                    listaMiembro.Add(objMiembros);
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

            return listaMiembro;
        }

    }
}
