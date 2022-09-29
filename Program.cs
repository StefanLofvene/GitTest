    Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Högsta möjliga: ");
int top = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;

Random rd = new Random();
int rättsvar = rd.Next(0,top);

int inmatning = 0;
while (inmatning != rättsvar)
{
Console.Write("Gissa Talet!: ");
inmatning = int.Parse(Console.ReadLine());
if (inmatning < rättsvar)
{
    Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Talet är högre!");
    Console.ForegroundColor = ConsoleColor.White;
}
else if(inmatning > rättsvar)
{
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Talet är lägre!");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("rätt svar!");    
    Console.ForegroundColor = ConsoleColor.White;
}
}
Console.ReadLine();
