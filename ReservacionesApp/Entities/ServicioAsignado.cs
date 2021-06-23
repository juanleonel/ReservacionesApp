using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Entities
{
    public class ServicioAsignado
    {
        [Key]
        public int ServicioAsignadoId { get; set; }

        public ICollection<Servicio> Servicios { get; set; }
    }
}
