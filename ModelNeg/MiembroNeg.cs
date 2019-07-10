using ModelDao;
using ModelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNeg
{
    public class MiembroNeg
    {
        private MiembroDao objMiembroDao;
        public MiembroNeg()
        {
            objMiembroDao = new MiembroDao();
        }
        public List<Miembro> FindAllTop50Miembro()
        {
            return objMiembroDao.FindAllTop50Miembro();
        }
        //FindMiembroPorNombre
        public List<Miembro> FindMiembroPorNombre(Miembro objMiembro)
        {
            return objMiembroDao.FindMiembroPorNombre(objMiembro);
        }
    }
}