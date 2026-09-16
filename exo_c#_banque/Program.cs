ecimal solde = 1000m;
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

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
