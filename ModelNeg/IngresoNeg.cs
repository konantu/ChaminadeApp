using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDao;
using ModelEntity;

namespace ModelNeg
{
    public class IngresoNeg
    {
        private IngresoDao objIngresoDao;
        public IngresoNeg()
        {
            objIngresoDao = new IngresoDao();
        }
        public List<Ingreso> GenerarFolioIngreso(Ingreso objIngreso)
        {
            return objIngresoDao.GenerarFolioIngreso(objIngreso);
        }

        public List<Ingreso> TraeEncabezadoIngreso(Ingreso objIngreso)
        {
            return objIngresoDao.TraeEncabezadoIngreso(objIngreso);
        }

        //

        public string ActualizaEncabezado(Ingreso objIngreso)
        {
            return objIngresoDao.ActualizaEncabezado(objIngreso);
        }

    }
}
