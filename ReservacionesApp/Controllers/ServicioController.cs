using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ReservacionesApp.Entities;
using ReservacionesApp.Interfaces;
using Microsoft.Extensions.Logging;
using ReservacionesApp.Models;

namespace ReservacionesApp.Controllers
{
    public class ServicioController : Controller
    {
        private readonly IServicio _servicio;
        private readonly ILogger<ServicioController> _logger;
        public ServicioController(IServicio servicio)
        {
            _servicio = servicio;
        }

        // GET: Servicio
        public ActionResult Index()
        {
            //var servicios = _servicio.GetALL().ToList();

            DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 00, 00, DateTimeKind.Local);
            var endTime = startTime.AddHours(12);

            List<ServicioViewModel> servicioViewModel = new List<ServicioViewModel>();
            while (startTime <= endTime)
            {
                servicioViewModel.Add(new ServicioViewModel() { 
                    Hora = startTime.ToString("HH:mm"),
                    Identificador = Guid.NewGuid(),
                    Leyenda = "Motociclistas",
                    TotalMotociclistas = 8
                });
                startTime = startTime.AddMinutes(30);
            }

            return View(servicioViewModel);
        }

        [HttpPost]
        public ActionResult Aplicado([FromBody] ServicioSelecViewModel model) {

            try
            {

                

                return Json(new { status = true, message = "ok" });        
            }
            catch (Exception ex)
            {
                return Json(new { status = true, message = ex.Message });
            }

        }
       
    }
}