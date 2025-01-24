using System.ComponentModel.DataAnnotations;
using WAppAgroma.Models;
namespace WAppAgroma.Models
{
    public class Employe
    {
    
    public int Id { get; set; } // Identifiant unique de l'employé

    [MaxLength(100)]
    public string Nom { get; set; } // Nom de l'employé

    [MaxLength(100)]
    public string Prenom { get; set; } // Prénom de l'employé

    public string Poste { get; set; } // Poste de l'employé

    [Range(0, double.MaxValue)]
    public decimal Salaire { get; set; } // Salaire de l'employé
    }
}