using System.Collections.Generic;
using System.Web.Mvc;
using EtkinlikTakvimi3.Models;

namespace EtkinlikTakvimi3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetEvents()
        {
            var eventList = new List<EventModel>()
            {
                new EventModel{ EventDate = "10.05.2018",EventTitle="Etkinlik Takvimi Yapımı 3 Mvc",EventDetail="<span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nec tortor molestie, tincidunt arcu vitae, vulputate augue. Maecenas nibh purus, consequat et est nec, bibendum consectetur leo. Nulla ornare consequat augue vel sagittis.</span><div><img width='90' src='https://mosaicdesigns.in/assets/online-tests/covers/0.png' /></div>"},
                new EventModel{ EventDate = "12.05.2018",EventTitle="Etkinlik 2",EventDetail="<h3>Etkinlik </h3><div>test etkinlik 2</div>"},
                new EventModel{ EventDate = "14.05.2018",EventTitle="Etkinlik 3",EventDetail="<h3>Etkinlik </h3><div>test etkinlik 3</div>"}
            };

            return Json(eventList,JsonRequestBehavior.AllowGet);
        }
    }
}