using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Entities
{
    public class Motociclista
    {
        [Key]
        public int MotociclistaId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }
        public bool Ocupado { get; set; }
        public Servicio servicio { get; set; } 
    }
}
