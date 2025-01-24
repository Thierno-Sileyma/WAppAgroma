using WAppAgroma.Models;
public class TableauDeBord
{
    public int TotalClients { get; set; } // Nombre total de clients

    public int TotalCommandes { get; set; } // Nombre total de commandes

    public decimal RevenusTotaux { get; set; } // Somme totale des revenus

    public decimal DepensesTotales { get; set; } // Somme totale des dépenses

    public int ProjetsEnCours { get; set; } // Nombre de projets en cours

    public int EmployesDisponibles { get; set; } // Nombre d'employés disponibles
}
