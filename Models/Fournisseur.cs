using System.ComponentModel.DataAnnotations;

namespace  WAppAgroma.Models
{
    public class Fournisseur
    {
    
        public int Id { get; set; } // Identifiant unique du fournisseur

        [MaxLength(100)]
        public string Nom { get; set; }

        public string Adresse { get; set; }

        [EmailAddress]
        public string Email { get; set; } // Email du fournisseur

        [Phone]
        public string Telephone { get; set; } // Téléphone du fournisseur

    }
}
