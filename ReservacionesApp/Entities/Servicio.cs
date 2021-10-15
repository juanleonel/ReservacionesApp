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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServicioId { get; set; }
        public Guid Identificador { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAlta { get; set; }        
        public int Total { get; set; }                        

        [StringLength(10)]
        public string Hora { get; set; }
        public ICollection<Motociclista> Motociclistas { get; set; }         
    }
}
