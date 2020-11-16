using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using WDG.Business.Abstract;
using WDG.Entities.Concrete;

namespace WDG.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IkurDataServices _kurDataService;
        public HomeController(IkurDataServices kurDataService)
        {
            _kurDataService = kurDataService;
        }
        public IActionResult Index()
        {
          
            if (_kurDataService.GetList() != null)
            {
                var data = _kurDataService.GetList().Select(i => i.kurID);
                foreach (var item in data)
                {
                    _kurDataService.Delete(new kurData { kurID = item });
                }

                _kurDataService.webVeriYukle();
            }
            else
            {
                _kurDataService.webVeriYukle();
            }

            var gosterilecekVeri = _kurDataService.GetList();

            return View(gosterilecekVeri);
        }
    }
}
