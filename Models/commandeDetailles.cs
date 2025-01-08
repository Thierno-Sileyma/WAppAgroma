public class CommandeDetail
{
   
    public int Id { get; set; } // Identifiant unique du détail

    public int CommandeId { get; set; } // Référence à la commande

    public int ProduitId { get; set; } // Référence au produit

    public int Quantite { get; set; } // Quantité commandée

    public decimal PrixUnitaire { get; set; } // Prix unitaire du produit

    // Relation avec la commande (navigation property)
    public Commande Commande { get; set; }
}
