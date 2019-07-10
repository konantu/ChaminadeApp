using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDao;
using ModelEntity;

namespace ModelNeg
{
    public class FormaPagoNeg
    {
        private FormaPagoDao objFormaPagoDao;
        public FormaPagoNeg()
        {
            objFormaPagoDao = new FormaPagoDao();
        }
        public List<FormaPago> GetFormaPago()
        {
            return objFormaPagoDao.GetFormaPago();
        }
    }
}
