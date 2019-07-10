using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;

namespace ModelEntity
{
    public class Ingreso
    {
        private long folioIngreso;
        private long idFormaPago;
        private string formaPago;
        private long totalIngreso;
        private DateTime fechaIngreso;
        private string pagadorIngreso;
        private string observacionesIngreso;
        private Int16 estadoIngreso;
        private DateTime fechaHoraIngreso;
        private string idUser;
        private string nombreUser;
        private Int64 idEstadoIngreso;


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

        [DisplayName("Id Forma Pago")]
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

        [DisplayName("Forma Pago")]
        public string FormaPago
        {
            get
            {
                return formaPago;
            }

            set
            {
                formaPago = value;
            }
        }

        [DisplayName("Total Ingreso")]
        public long TotalIngreso
        {
            get
            {
                return totalIngreso;
            }

            set
            {
                totalIngreso = value;
            }
        }
        [Required]
        [DisplayName("Fecha Ingreso")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-mmm-yyyy}")]
        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        [DisplayName("Pagador Ingreso")]
        public string PagadorIngreso
        {
            get
            {
                return pagadorIngreso;
            }

            set
            {
                pagadorIngreso = value;
            }
        }

        [DisplayName("Observaciones Ingreso")]
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
        /*
        private Int16 estadoIngreso;
        private DateTime fechaHoraIngreso;
        private string idUser;
        private string nombreUser;
        */

        [DisplayName("Estado Ingreso")]
        public Int16 EstadoIngreso
        {
            get
            {
                return estadoIngreso;
            }

            set
            {
                estadoIngreso = value;
            }
        }


        [DisplayName("Observaciones Ingreso")]
        public DateTime FechaHoraIngreso
        {
            get
            {
                return fechaHoraIngreso;
            }

            set
            {
                fechaHoraIngreso = value;
            }
        }

        [DisplayName("Id Usuario")]
        public string IdUser
        {
            get
            {
                return idUser;
            }

            set
            {
                idUser = value;
            }
        }

        [DisplayName("Nombre Usuario")]
        public string NombreUser
        {
            get
            {
                return nombreUser;
            }

            set
            {
                nombreUser = value;
            }
        }

        public long IdEstadoIngreso
        {
            get
            {
                return idEstadoIngreso;
            }

            set
            {
                idEstadoIngreso = value;
            }
        }
        public Ingreso()
        {

        }
        public Ingreso(long folioIngreso)
        {
            this.FolioIngreso = folioIngreso;
        }

        public Ingreso(long folioIngreso, string pagadorIngreso, long idFormaPago, DateTime fechaIngreso, string  observacionesIngreso, long idEstadoIngreso, string idUser)
        {
            this.FolioIngreso = folioIngreso;
            this.PagadorIngreso = pagadorIngreso;
            this.IdFormaPago = idFormaPago;
            this.FechaIngreso = fechaIngreso;
            this.ObservacionesIngreso = observacionesIngreso;
            this.IdEstadoIngreso = idEstadoIngreso;
            this.IdUser = idUser;
        }
    }
}
