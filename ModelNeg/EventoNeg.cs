using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDao;
using ModelEntity;

namespace ModelNeg
{
    public class EventoNeg
    {
        private EventoDao objEventoDao;
        public EventoNeg()
        {
            objEventoDao = new EventoDao();
        }
        public List<Evento> GetEvento()
        {
            return objEventoDao.GetEvento();
        }
    }
}
