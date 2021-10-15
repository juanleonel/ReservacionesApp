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
        public int ValorOcupado { get; set; }
        public int OtroUsuario { get; set; }

        public string getClass 
        {
            get {
                if (this.OtroUsuario == 1 && this.ValorOcupado == 1)
                {
                    return "not-free";
                }
                else if (this.OtroUsuario == 0 && this.ValorOcupado == 1)
                {
                    return "other-user";
                }
                {
                    return "normal";
                }
            }
        }
    }
}
