using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Entities
{
    public class ApplicationUser : IdentityUser {

        public bool Disabled { get; set; }

        public bool Alive { get; set; }

    }


    //public class ApplicationRole : IdentityRole {}
    //public class ApplicationUserClaim : IdentityUserClaim<Guid> { }
    //public class ApplicationUserToken : IdentityUserToken<Guid> { }
    //public class ApplicationUserLogin : IdentityUserLogin<Guid> { }
    //public class ApplicationUserRole : IdentityUserRole<int> { }
    //public class ApplicationRoleClaim : IdentityRoleClaim<int> { }
}
