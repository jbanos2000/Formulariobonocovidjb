using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Formulariobonocovidjb.Models;
using Formulariobonocovidjb.Data;

namespace Formulariobonocovidjb.Controllers
{
    public class CovidController : Controller
    {
        private readonly ILogger<CovidController> _logger;
        private readonly DatabaseContext _context;

        public CovidController(ILogger<CovidController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Covid covid){
            if(ModelState.IsValid){
                //grabado DB
                covid.Autor="jbejarano";
                _context.Add(covid);
                _context.SaveChanges();            
                covid.Respuesta="Su solicitud será enviada pronto, muchas gracias!";
            }
            return View("Index",covid);
        }

        
    }
}