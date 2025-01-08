using Microsoft.Identity.Client;


namespace WAppAgroma.Models
{  
    public class Commande
    {
        public int Id { get; set; }

        public int ClientId { get; set; } // Référence au client ayant passé la commande

        public DateTime DateCommande { get; set; } // Date de la commande

        public decimal MontantTotal { get; set; } // Montant total de la commande

        // Relation avec le client (navigation property)
        public Client Client { get; set; }
    }
}
