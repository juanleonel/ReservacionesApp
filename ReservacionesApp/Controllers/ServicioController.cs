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
using ReservacionesApp.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace ReservacionesApp.Controllers
{
    [Authorize]
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
            List<ServicioViewModel> servicioViewModel = new List<ServicioViewModel>();
            var servicios = _servicio.GetALL().ToList();

            var result = servicios.Where(x => x.Motociclistas.Any(c => c.UsuarioId == User.GetUserId())).FirstOrDefault();



            foreach (var servicio in servicios)
            {
                servicioViewModel.Add(new ServicioViewModel()
                {
                    Hora =  servicio.Hora,
                    Identificador =   servicio.Identificador ,
                    Leyenda = "Motociclistas",
                    TotalMotociclistas =  servicio.Total,    
                    ValorOcupado = result != null ? 1 : 0
                });
            }

           
            return View(servicioViewModel);
        }

        [HttpPost]
        public ActionResult Aplicado([FromBody] ServicioSelecViewModel model) {

            try
            {


                var servicio = _servicio.GetByIdentificador(model.ServicioId);
                if (servicio != null)
                { 
                    var Servicio = new Servicio()
                    {
                        FechaAlta = DateTime.Now,
                        Identificador = model.ServicioId,
                        Total = model.Total,
                        Hora = model.Hora,
                    };

                    List<Motociclista> motociclistas = new List<Motociclista>();
                    motociclistas.Add(new Motociclista()
                    {
                        FechaAlta = DateTime.Now,
                        Nombre = "Ramdom",
                        UsuarioId = User.GetUserId(),
                        Ocupado = true,
                        ServicioId = servicio.ServicioId
                    });

                    Servicio.Motociclistas = motociclistas;
                    _servicio.Aplica(Servicio);

                    return Json(new { status = true, message = "ok" });
                }

                return Json(new { status = true, message = "bad" });

            }
            catch (Exception ex)
            {
                return Json(new { status = true, message = ex.Message });
            }

        }
       
    }
}