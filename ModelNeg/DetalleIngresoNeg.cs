using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDao;
using ModelEntity;

namespace ModelNeg
{
    public class DetalleIngresoNeg
    {
        private DetalleIngresoDao objDetalleIngresoDao;
        public DetalleIngresoNeg()
        {
            objDetalleIngresoDao = new DetalleIngresoDao();
        }

        public List<DetalleIngreso> TraeDetalleIngreso(DetalleIngreso objDetalleIngreso)
        {
            return objDetalleIngresoDao.TraeDetalleIngreso(objDetalleIngreso);
        }

        public string EliminaDetalleIngreso(DetalleIngreso objDetalleIngreso)
        {
            return objDetalleIngresoDao.EliminaDetalleIngreso(objDetalleIngreso);
        }

        //
        public string InsertaDetalleIngreso(DetalleIngreso objDetalleIngreso)
        {
            return objDetalleIngresoDao.InsertaDetalleIngreso(objDetalleIngreso);
        }

    }
}
