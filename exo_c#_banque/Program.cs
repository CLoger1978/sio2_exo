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

 decimal credit_new = Crediter(1000m , 2000m);

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

 decimal debit_new = Debiter(1000m , 2000m);
Console.WriteLine("Hello, World!");
