using ModelEntity;
using ModelNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaminadeApp.Controllers
{
    public class EventoController : Controller
    {
        private UnidadNeg objUnidadNeg;
        private EventoNeg objEventoNeg;
        public EventoController()
        {
            objUnidadNeg = new UnidadNeg();
            objEventoNeg = new EventoNeg();
        }
            // GET: Evento
            public ActionResult Index()
        {
            return View();
        }
        public ActionResult ParticipacionEvento()
        {
            List<Unidad> dataUnidad = objUnidadNeg.GetUnidad();
            SelectList ListaUnidad = new SelectList(dataUnidad, "idUnidad", "nombreUnidad");
            ViewBag.ListaUnidades = ListaUnidad;

            List<Evento> dataEvento = objEventoNeg.GetEvento();
            SelectList ListaEvento = new SelectList(dataEvento, "idEvento", "nombreEvento");
            ViewBag.ListaEventos = ListaEvento;

            return View();
        }
    }
}