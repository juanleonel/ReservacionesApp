using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Models
{
    public class ServicioSelecViewModel
    {
        public Guid ServicioId { get; set; }
        public bool Seleccionado { get; set; }
        public int Total { get; set; }
        public string Hora { get; set; }
    }
}
