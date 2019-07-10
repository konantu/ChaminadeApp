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
    public class Unidad
    {
        private long idUnidad;
        private string nombreUnidad;
        private Int16 estadoUnidad;
        private DateTime fechaHoraUnidad;

        [DisplayName("Id Unidad")]
        public long IdUnidad
        {
            get
            {
                return idUnidad;
            }

            set
            {
                idUnidad = value;
            }
        }

        [DisplayName("Unidad")]
        public string NombreUnidad
        {
            get
            {
                return nombreUnidad;
            }

            set
            {
                nombreUnidad = value;
            }
        }

        [DisplayName("Estado Unidad")]
        public Int16 EstadoUnidad
        {
            get
            {
                return estadoUnidad;
            }

            set
            {
                estadoUnidad = value;
            }
        }

        public DateTime FechaHoraUnidad
        {
            get
            {
                return fechaHoraUnidad;
            }

            set
            {
                fechaHoraUnidad = value;
            }
        }

    }
}
