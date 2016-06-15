using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class OffreContext : DbContext
    {
        public OffreContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<OffreLivre> OffreLivres { get; set; }
    }

    [Table("OffreLivre")]
    public class OffreLivre
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Isbn { get; set; }
        public string ÉtatLivre { get; set; }
        public bool EstVente { get; set; }
        public float Prix { get; set; }
        public string Cours { get; set; }
    }

    public class AjouterOffreModel
    {
        [Display(Name = "Isbn")]
        public int Isbn { get; set; }

        [Display(Name = "Titre")]
        public string Titre { get; set; }

        [Display(Name = "Auteur")]
        public string Auteur { get; set; }


        [Display(Name = "Numéro d'édition")]
        public int NuméroÉdition { get; set; }


        [Display(Name = "Nombre de page")]
        public int NbPage { get; set; }


        public AjouterOffreModel() { }
        public AjouterOffreModel(int isbn, string titre, string auteur, int numeroDedition, int nbPage)
        {
            Isbn = isbn;
            Titre = titre;
            Auteur = auteur;
            NuméroÉdition = numeroDedition;
            NbPage = nbPage;
        }

        [Required]
        [Display(Name = "État physique du livre")]
        public string ÉtatLivre { get; set; }

        [Required]
        [Display(Name = "Est Vente")]
        public bool EstVente { get; set; }

        [Required]
        [Display(Name = "Prix")]
        public float Prix { get; set; }

        [Required]
        [Display(Name = "Cours")]
        public string Cours { get; set; }
    }

    public class RechercherLivreModel
    {
        [Required]
        [Display(Name = "Isbn")]
        public int Isbn { get; set; }

    }
}
