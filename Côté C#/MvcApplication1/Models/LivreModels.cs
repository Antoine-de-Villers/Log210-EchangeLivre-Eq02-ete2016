using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Data.Entity.Migrations;

namespace MvcApplication1.Models
{
    public class LivreContext : DbContext
    {
        public LivreContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<LivreContext>(null);
        }

        public DbSet<Livre> Livres { get; set; }
    }

    [Table("Livre")]
    public class Livre
    {
        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        [Key]
        public int Isbn { get; set; }

        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NuméroÉdition { get; set; }
        public int NbPage { get; set; }
    }


    public class AjouterLivreModel
    {
        [Required]
        [Display(Name = "Titre")]
        public string Titre { get; set; }

        [Required]
        [Display(Name = "Auteur")]
        public string Auteur { get; set; }

        [Required]
        [Display(Name = "Isbn")]
        public int Isbn { get; set; }

        [Required]
        [Display(Name = "Numéro d'édition")]
        public int NuméroÉdition { get; set; }

        [Required]
        [Display(Name = "Nombre de page")]
        public int NbPage { get; set; }

    }

}
