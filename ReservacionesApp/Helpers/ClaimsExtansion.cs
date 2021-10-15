using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReservacionesApp.Helpers
{
    public static class ClaimsExtansion
    {
        public static Guid GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
                throw new ArgumentNullException(nameof(principal));

            string value = principal.FindFirstValue(ClaimTypes.NameIdentifier);

            Guid id = Guid.Empty;
            Guid.TryParse(value, out id);

            return id;
        }
    }
}
