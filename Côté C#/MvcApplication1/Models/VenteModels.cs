using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class VenteContext : DbContext
    {
        public VenteContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<VenteContext> Ventes { get; set; }
    }

    [Table("Vente")]
    public class EffectuerVente
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
    }

    public class EffectuerVenteModel
    {
        
    }
}
