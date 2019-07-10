using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;
namespace ModelEntity
{
    public class FormaPago
    {
        private long idFormaPago;
        private string nombreFormaPago;
        private Int16 estadoFormaPago;
        private DateTime fechaHoraFormaPago;

        [DisplayName("Id FormaPago")]
        public long IdFormaPago
        {
            get
            {
                return idFormaPago;
            }

            set
            {
                idFormaPago = value;
            }
        }

        [DisplayName("FormaPago")]
        public string NombreFormaPago
        {
            get
            {
                return nombreFormaPago;
            }

            set
            {
                nombreFormaPago = value;
            }
        }

        [DisplayName("Estado FormaPago")]
        public Int16 EstadoFormaPago
        {
            get
            {
                return estadoFormaPago;
            }

            set
            {
                estadoFormaPago = value;
            }
        }

        public DateTime FechaHoraFormaPago
        {
            get
            {
                return fechaHoraFormaPago;
            }

            set
            {
                fechaHoraFormaPago = value;
            }
        }

    }
}
