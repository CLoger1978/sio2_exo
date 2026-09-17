decimal solde = 1000m;
decimal montant = 250m;
if (montant > 0)
{
solde += montant;
}
else if (montant < 0)
{
 decimal debit =- montant;
 if(debit <= solde)
 {
 solde =- debit;
 }
 else
 {
    Console.WriteLine("Solde Insuffisant");
 }
} 
Console.WriteLine($"Solde: {solde}");

static decimal Crediter(decimal montant, decimal solde)
{
if (montant > 0)
{
    return montant+solde;
} 
else
{
    Console.WriteLine("Erreur: montant non possitif");
} 
return solde;  
}

 decimal credit_new = Crediter(solde, 2m);

static decimal Debiter(decimal montant, decimal solde)
{
if (montant < 0)
{
   Console.WriteLine("Erreur: montant non possitif"); 
   return solde;
} 
if (solde < montant)
{
   return montant-solde;
}
else 
{
Console.WriteLine("fond insufissant");
}
return solde;  
}

 decimal debit_new = Debiter(solde , 2m);
Console.WriteLine("Hello, World!");
  
   var compte = new Compte();
 {
 compte.Numero = "0001";
    compte.Titulaire = "Claude";
    compte.solde = 2000m;
 }
var compte_1 = new Compte();
{
    compte.Numero ="0002";
    compte.Titulaire = "Clara";
    compte.solde = 1900m;
}

