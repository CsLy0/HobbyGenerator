Random rand = new Random();
var randomNumber = rand.Next(0, 5);
string[] names = { "Marius", "Ole", "Michal", "Peder", "Vårin" };
string randomNameString = names[rand.Next(names.Length)];

if (randomNumber == 0)
{
    Console.WriteLine($"{randomNameString} liker twintip.");
}
else if (randomNumber == 1)
{
    Console.WriteLine($"{randomNameString} liker gaming.");
}
else if (randomNumber == 2)
{
    Console.WriteLine($"{randomNameString} liker tv-serier.");
}
else if (randomNumber == 3)
{
    Console.WriteLine($"{randomNameString} liker musikk.");
}
else
{
    Console.WriteLine($"{randomNameString} liker filmer."); ;
}