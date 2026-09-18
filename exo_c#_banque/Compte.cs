 using System;
 public class Compte
 {
    public string Numero { get; }

    public string Titulaire {get; set;}

    public decimal Solde {get;set;}
    

    public Compte(string numero, string titulaire)
              : this(numero,titulaire, 0m)
    {
    }
    
    public Compte( string numero, string titulaire, decimal soldeid)
 
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = soldeid;
    }   
}




    

