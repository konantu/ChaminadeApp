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
    public class Evento
    {
        private long idEvento;
        private string nombreEvento;
        private Int16 estadoEvento;
        private DateTime fechaEvento;
        private DateTime fechaHoraEvento;

        [DisplayName("Id Evento")]
        public long IdEvento
        {
            get
            {
                return idEvento;
            }

            set
            {
                idEvento = value;
            }
        }

        [DisplayName("Evento")]
        public string NombreEvento
        {
            get
            {
                return nombreEvento;
            }

            set
            {
                nombreEvento = value;
            }
        }

        [DisplayName("Estado Evento")]
        public Int16 EstadoEvento
        {
            get
            {
                return estadoEvento;
            }

            set
            {
                estadoEvento = value;
            }
        }

        [DisplayName("Fecha Evento")]
        public DateTime FechaEvento
        {
            get
            {
                return fechaEvento;
            }

            set
            {
                fechaEvento = value;
            }
        }
        public DateTime FechaHoraEvento
        {
            get
            {
                return fechaHoraEvento;
            }

            set
            {
                fechaHoraEvento = value;
            }
        }

    }
}
