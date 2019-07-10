using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDao;
using ModelEntity;
using ModelNeg;

namespace ChaminadeApp.Controllers
{
    public class IngresoController : Controller
    {
        private UnidadNeg objUnidadNeg;
        private EventoNeg objEventoNeg;
        private FormaPagoNeg objFormaPagoNeg;
        private IngresoNeg objIngresoNeg;
        private DetalleIngresoNeg objDetalleIngresoNeg;

        public IngresoController()
        {
            objUnidadNeg = new UnidadNeg();
            objEventoNeg = new EventoNeg();
            objFormaPagoNeg = new FormaPagoNeg();
            objIngresoNeg = new IngresoNeg();
            objDetalleIngresoNeg = new DetalleIngresoNeg();
        }
        // GET: Ingreso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuevoIngreso(Int64 folio)
        {
            var datosEncabezadoIngreso = new Ingreso();
            var datosDetalleIngreso = new DetalleIngreso();
            Ingreso objIngreso = new Ingreso();
            //DetalleIngreso objDetalleIngreso = new DetalleIngreso();

            if (folio.Equals(0))
            {
                objIngresoNeg.GenerarFolioIngreso(objIngreso);
                datosEncabezadoIngreso = objIngreso;
            }
            else
            {

                Ingreso objEncabezadoIngreso = new Ingreso(folio);
                objIngresoNeg.TraeEncabezadoIngreso(objEncabezadoIngreso);
                datosEncabezadoIngreso = objEncabezadoIngreso;

                

            }

            DetalleIngreso objDetalleIngreso = new DetalleIngreso(folio);
            List<DetalleIngreso> ListaDetalleIngreso = objDetalleIngresoNeg.TraeDetalleIngreso(objDetalleIngreso);
            //SelectList ListaHistoricoGestion = new SelectList(dataHistoricoGestion, "idResultadoGestion", "nombreResultadoGestion");
            ViewBag.ListaDetalleIngresos = ListaDetalleIngreso;

            List<Unidad> dataUnidad = objUnidadNeg.GetUnidad();
            SelectList ListaUnidad = new SelectList(dataUnidad, "idUnidad", "nombreUnidad");
            ViewBag.ListaUnidades = ListaUnidad;

            List<Evento> dataEvento = objEventoNeg.GetEvento();
            SelectList ListaEvento = new SelectList(dataEvento, "idEvento", "nombreEvento");
            ViewBag.ListaEventos = ListaEvento;

            List<FormaPago> dataFormaPago = objFormaPagoNeg.GetFormaPago();
            SelectList ListaFormaPago = new SelectList(dataFormaPago, "idFormaPago", "nombreFormaPago");
            ViewBag.ListaFormaPagos = ListaFormaPago;


            return View(Tuple.Create(datosEncabezadoIngreso));//(Tuple.Create(datosHabilitado, datosGestion, datosTipoGestion, datosHistoricoGestion));

        }

        [HttpPost]
        public ActionResult EliminaDetalleIngreso(Int64 idDetalleIngreso, Int64 folioIngreso, string idUsuario)
        {
            string mensaje = "";

            if (idDetalleIngreso == 0 || folioIngreso == 0 || idUsuario == "")
            {
                if (idDetalleIngreso == 0) mensaje = "SELECCIONE ACCION  GESTIÓN";
                if (folioIngreso == 0) mensaje = "SELECCIONE RESULTADO";
                if (idUsuario == "") mensaje = "ERROR EN IDENTIFICADOR DE HABILITADO";
            }
            else
            {
                try
                {
                    DetalleIngreso objDetalleIngreso = new DetalleIngreso(idDetalleIngreso, folioIngreso, idUsuario);
                    //objDetalleIngresoNeg.EliminaDetalleIngreso(objDetalleIngreso);

                    string resultado = objDetalleIngresoNeg.EliminaDetalleIngreso(objDetalleIngreso);
                    //resultado = objIngresoNeg.Resultado.ToString();
                    if (resultado == "1" || resultado == null)
                    {
                        mensaje = "ERROR AL REGISTRAR EL PAGO";
                    }
                    else
                    {
                        mensaje = "0";
                    }
                }
                catch (Exception)
                {
                    mensaje = "ERROR, REVISAR DATOS INGRESADOS";
                }
            }
            return Json(mensaje);
        }

        [HttpPost]
        public ActionResult InsertaDetalleIngreso(Int64 folioIngreso, string pagadorIngreso, Int64 idFormaPago, DateTime fechaPago, string observacionesIngreso, Int64 idEstadoIngreso, string idUsuario, string rutMiembro, long idEvento, string observacionesDetalle, long montoDetalle)
        {
            string mensaje = "";

            if (folioIngreso == 0 || idUsuario == "")
            {
                //if (idDetalleIngreso == 0) mensaje = "SELECCIONE ACCION  GESTIÓN";
                if (folioIngreso == 0) mensaje = "SELECCIONE RESULTADO";
                if (idUsuario == "") mensaje = "ERROR EN IDENTIFICADOR DE HABILITADO";
            }
            else
            {
                try
                {
                    DetalleIngreso objDetalleIngreso = new DetalleIngreso(folioIngreso, rutMiembro, idEvento, observacionesDetalle, montoDetalle, idUsuario);
                    string resultadoDetalle = objDetalleIngresoNeg.InsertaDetalleIngreso(objDetalleIngreso);

                    if (resultadoDetalle == "1" || resultadoDetalle == null)
                    {
                        mensaje = "ERROR AL REGISTRAR DETALLE DEL PAGO";
                    }
                    else
                    {
                        mensaje = "0";
                    }


                    Ingreso objIngreso = new Ingreso(folioIngreso, pagadorIngreso, idFormaPago, Convert.ToDateTime(fechaPago), observacionesIngreso, idEstadoIngreso, idUsuario);
                    //objDetalleIngresoNeg.EliminaDetalleIngreso(objDetalleIngreso);

                    string resultado = objIngresoNeg.ActualizaEncabezado(objIngreso);
                    //resultado = objIngresoNeg.Resultado.ToString();
                    if (resultado == "1" || resultado == null)
                    {
                        mensaje = "ERROR AL REGISTRAR EL PAGO";
                    }
                    else
                    {
                        mensaje = "0";
                    }

                }
                catch (Exception)
                {
                    mensaje = "ERROR, REVISAR DATOS INGRESADOS";
                }
            }
            return Json(mensaje);
        }


       // [HttpPost]
        //ActualizaEncabezado
        public ActionResult ActualizaEncabezado(Int64 folioIngreso, string pagadorIngreso, Int64 idFormaPago, DateTime fechaPago, string observacionesIngreso, Int64 idEstadoIngreso, string idUsuario)
        {
            string mensaje = "";

            if (folioIngreso == 0 || idUsuario == "")
            {
                //if (idDetalleIngreso == 0) mensaje = "SELECCIONE ACCION  GESTIÓN";
                if (folioIngreso == 0) mensaje = "SELECCIONE RESULTADO";
                if (idUsuario == "") mensaje = "ERROR EN IDENTIFICADOR DE HABILITADO";
            }
            else
            {
                try
                {
                    Ingreso objIngreso = new Ingreso(folioIngreso, pagadorIngreso, idFormaPago, Convert.ToDateTime(fechaPago), observacionesIngreso, idEstadoIngreso, idUsuario);
                    //objDetalleIngresoNeg.EliminaDetalleIngreso(objDetalleIngreso);

                    string resultado = objIngresoNeg.ActualizaEncabezado(objIngreso);
                    //resultado = objIngresoNeg.Resultado.ToString();
                    if (resultado == "1" || resultado == null)
                    {
                        mensaje = "ERROR AL REGISTRAR EL PAGO";
                    }
                    else
                    {
                        mensaje = "0";
                    }

                }
                catch (Exception)
                {
                    mensaje = "ERROR, REVISAR DATOS INGRESADOS";
                }
            }
            return Json(mensaje);
        }



    }
}