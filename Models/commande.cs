using Microsoft.Identity.Client;

public class Commande
namespace WAppAgroma.Models
{  
    public class commande
    {
        public int Id { get; set; }

        public int ClientId { get; set; } // Référence au client ayant passé la commande

        public DateTime DateCommande { get; set; } // Date de la commande

        public decimal MontantTotal { get; set; } // Montant total de la commande

        // Relation avec le client (navigation property)
        public Client Client { get; set; }
    }
}
