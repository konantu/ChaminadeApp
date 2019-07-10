using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;


namespace ModelEntity
{
    public class DetalleIngreso
    {
        private long idDetalleIngreso;
        private long folioIngreso;
        private string rutMiembro;
        private string nombreCompletoMiembro;
        private long idUnidad;
        private string nombreUnidad;
        private long idEvento;
        private string nombreEvento;
        private string observacionesIngreso;
        private long montoIngreso;
        private DateTime fechaHoraModificacionIngreso;
        private string idUsario;
        private string resultado;


        [DisplayName("Folio Ingreso")]
        public long FolioIngreso
        {
            get
            {
                return folioIngreso;
            }

            set
            {
                folioIngreso = value;
            }
        }

        public long IdDetalleIngreso
        {
            get
            {
                return idDetalleIngreso;
            }


            set
            {
                idDetalleIngreso = value;
            }
        }

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
        public string IdUsuario
        {
            get
            {
                return idUsario;
            }

            set
            {
                idUsario = value;
            }
        }

        public string Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }



        [DisplayName("Monto Ingreso")]
        public long MontoIngreso
        {
            get

            {
                return montoIngreso;
            }

            set
            {
                montoIngreso = value;
            }
        }

        public DateTime FechaHoraModificacionIngreso
        {
            get
            {
                return fechaHoraModificacionIngreso;
            }

            set
            {
                fechaHoraModificacionIngreso = value;
            }
        }

        [DisplayName("Rut Participante")]
        public string RutMiembro
        {
            get
            {
                return rutMiembro;
            }

            set
            {
                rutMiembro = value;
            }
        }

        [DisplayName("Nombre Participante")]
        public string NombreCompletoMiembro
        {
            get
            {
                return nombreCompletoMiembro;
            }

            set
            {
                nombreCompletoMiembro = value;
            }
        }

        [DisplayName("Observaciones")]
        public string ObservacionesIngreso
        {
            get
            {
                return observacionesIngreso;
            }

            set
            {
                observacionesIngreso = value;
            }
        }
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

        public DetalleIngreso()
        {

        }
        public DetalleIngreso(long folioIngreso)
        {
            this.FolioIngreso = folioIngreso;
        }

        public DetalleIngreso(long idDetalleIngreso, long folioIngreso, string idUsuario)
        {
            this.IdDetalleIngreso = idDetalleIngreso;
            this.FolioIngreso = folioIngreso;
            this.IdUsuario = idUsuario;
        }
        //folioIngreso, rutMiembro, , observacionesDetalle, montoDetalle, idUsuario
        public DetalleIngreso(long folioIngreso, string rutMiembro, long idEvento, string observacionesDetalle, long montoDetalle, string idUsuario)
        {
            this.FolioIngreso = folioIngreso;
            this.RutMiembro = rutMiembro;
            this.IdEvento = idEvento;
            this.ObservacionesIngreso = observacionesDetalle;
            this.MontoIngreso = montoDetalle;
            this.IdUsuario = idUsuario;
        }
    }
}
