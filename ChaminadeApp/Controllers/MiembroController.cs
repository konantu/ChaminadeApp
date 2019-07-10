using ModelEntity;
using ModelNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaminadeApp.Controllers
{
    public class MiembroController : Controller
    {
        private MiembroNeg objMiembroNeg;

        public MiembroController()
        {
            objMiembroNeg = new MiembroNeg();
        }
        // GET: Miembro
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ObtenerMiembro()
        {
            List<Miembro> listaMiembro = objMiembroNeg.FindAllTop50Miembro();
            return View(listaMiembro);
        }

        [HttpPost]//para buscar clientes
        public ActionResult ObtenerMiembro(string txtnombre)
        {
            if (txtnombre == "")
            {
                txtnombre = "-1";
            }

            Miembro objMiembro = new Miembro();
            objMiembro.TextoBuscar = txtnombre;
 
            List<Miembro> miembro = objMiembroNeg.FindMiembroPorNombre(objMiembro);
            return View(miembro);
        }

    }
}