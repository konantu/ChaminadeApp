using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDao;
using ModelEntity;

namespace ModelNeg
{
    public class UnidadNeg
    {
        private UnidadDao objUnidadDao;
        public UnidadNeg()
        {
            objUnidadDao = new UnidadDao();
        }
        public List<Unidad> GetUnidad()
        {
            return objUnidadDao.GetUnidad();
        }
    }
}
