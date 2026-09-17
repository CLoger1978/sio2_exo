 using System;
 public class Compte
 {
    public string Numero { get; set; }

    public string Titulaire {get; set;}
    
    public decimal solde {get; set;}

    public Compte()
    {
        Numero = "0";
        Titulaire = "Cassandra";
        solde = 2000m;
    }
 }


    

