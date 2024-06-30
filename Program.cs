Console.WriteLine("what is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
Console.Write($"{Environment.NewLine}press any key to exit...");
Console.ReadKey(true);
