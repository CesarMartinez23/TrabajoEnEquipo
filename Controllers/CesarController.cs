using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrabajoEnEquipo.Models;

namespace TrabajoEnEquipo.Controllers

{
    public class CesarController : Controller
    {
        public IActionResult Index()
        {
            Personal_Cesar cesar = new Personal_Cesar();
            cesar.profession = "Student";
            cesar.experience = "1 Year";
            cesar.phone = "+503 7470-8027";
            cesar.email = "SMIS055621@UGB.EDU.SV";
            cesar.location = "Santa Rosa de Lima, La Union, El Salvador, Centroamerica.";
            cesar.name ="Cesar";
            cesar.lastname ="Martinez";
            cesar.age=20;
            return View(cesar);
        }
    }
}
