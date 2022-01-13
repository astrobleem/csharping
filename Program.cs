// See https://aka.ms/new-console-template for more information
ConsoleKeyInfo key;

Console.Title = "What are you building today?";
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("C# stuff");
bool running = true;

do{


key = Console.ReadKey(true);

if (key.Key == ConsoleKey.DownArrow) 
{
Console.WriteLine("10 go 20");
//running = false;
}



} while(key.Key != ConsoleKey.X);

// Console.ReadKey();

