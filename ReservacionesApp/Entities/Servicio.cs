using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Entities
{
    public class Servicio
    {
        [Key]
        public int ServicioId { get; set; }
          
        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }

        [ForeignKey("MotociclistaId")]
        public int? MotociclistaId { get; set; }
        public Motociclista Motociclista { get; set; }         
    }
}
