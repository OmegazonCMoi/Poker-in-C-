string deux = "Deux";
string trois = "Trois";
string quatre = "Quatre";
string cinq = "Cinq";
string six = "Six";
string sept = "Sept";
string huit = "Huit";
string neuf = "Neuf";
string dix = "Dix";
string valet = "Valet";
string dame = "Dame";
string roi = "Roi";
string ass = "As";

Console.WriteLine("\\-------------------------------------/Poker\\------------------------------------/");
Console.Write("Pseudo : ");
string nomJoueur = Console.ReadLine();
Console.WriteLine($"\nBienvenue {nomJoueur} ! Tu vas maintenant pouvoir jouer au Texas Hold'em !");
Console.WriteLine("Entre C pour commencer la partie !");
Console.ReadLine();
Console.Clear();
Console.WriteLine("\\-------------------------------------/Poker\\------------------------------------/");
Random tirageDeBase1 = new Random();
Random tirageDeBase2 = new Random();
int resultatTirage1 = tirageDeBase1.Next(1, 7);
int resultatTirage2 = tirageDeBase2.Next(1, 7);
Console.WriteLine($"\nTu as en ta possession un {resultatTirage1}, un {resultatTirage2} et 500$ !");
Console.WriteLine("Veux tu miser, suivre ou te coucher ?");
Console.WriteLine("Écris M pour miser, S pour suivre et C pour te coucher");
int argent = 500;
string mise1 = Console.ReadLine();
if (mise1 == "M")
{
    Console.Clear();
    Console.WriteLine("\\-------------------------------------/Poker\\------------------------------------/");
    Console.WriteLine("\nDe combien veux tu miser ?");
    Console.Write("Somme : ");
    Console.ReadLine();
}
else
{
    if (mise1 == "S")
    {
        Console.Clear();
        Console.WriteLine("\\-------------------------------------/Poker\\------------------------------------/");
        Console.WriteLine("Suivre");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\\-------------------------------------/Poker\\------------------------------------/");
        Console.WriteLine("Coucher");
    }
}



Console.ReadLine();