using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class DepotContext : DbContext
    {
        public DepotContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<OffreLivre> OffreLivres { get;}
        public DbSet<UserProfile> UserProfiles { get;}

    }


}
