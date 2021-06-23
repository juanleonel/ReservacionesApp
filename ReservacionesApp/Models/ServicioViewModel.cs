using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Models
{
    public class ServicioViewModel
    {
        public Guid Identificador { get; set; }
        public string Hora { get; set; }
        public string Leyenda { get; set; }
        public int TotalMotociclistas { get; set; }
    }
}
