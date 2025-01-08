
 namespace WAppAgroma.Models
 {

    public class Client
    {
    

        public int Id { get; set; }

        public string Nom { get; set; }

         public string Adresse { get; set; }

        [EmailAddress] // Valide qu'il s'agit d'une adresse e-mail
        public string Email { get; set; }

        [Phone] // Valide qu'il s'agit d'un numéro de téléphone
       public string Telephone { get; set; }
    }
 }

