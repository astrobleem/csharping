// See https://aka.ms/new-console-template for more information
ConsoleKeyInfo key;

Console.Title = "What are you building today?";
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("C# stuff");
Console.WindowHeight = 40;
string name = "";
bool running = true;
name = Console.ReadLine();
Console.WriteLine(name);
do{


key = Console.ReadKey(true);

if (key.Key == ConsoleKey.DownArrow) 
{
Console.WriteLine("down");

}
if (key.Key == ConsoleKey.UpArrow) 
{
Console.WriteLine("up");

}
if (key.Key == ConsoleKey.LeftArrow) 
{
Console.WriteLine("left");

}
if (key.Key == ConsoleKey.RightArrow) 
{
Console.WriteLine("right");

}

if (key.Key == ConsoleKey.Q) 
{
Console.WriteLine("terminate");
Console.WriteLine(running);
running = false;
Console.WriteLine(running);
}



 // } while (key.Key != ConsoleKey.X || key.Modifiers != ConsoleModifiers.Alt);
  } while (key.Key != ConsoleKey.X);



Console.WriteLine("shutdowndie");
Console.ReadKey();
