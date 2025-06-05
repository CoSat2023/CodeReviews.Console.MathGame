namespace ConsoleMathGame.CoSat2023;

internal class Menu
{
    GameEngine engine = new();

    internal void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.");
        Console.WriteLine("Press Enter to show the menu.");
        Console.ReadLine();
        Console.WriteLine("\n");

        var isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($@"What game would you like to play today? Choose from the options below:

    V - View Previous Games
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    Q - Quit the program");

            Console.WriteLine($"-----------------------------------------");

            var gameSelected = Console.ReadLine().Trim().ToLower();

            switch (gameSelected)
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    engine.AdditionGame("Addition");
                    break;
                case "s":
                    engine.SubtractionGame("Subtraction");
                    break;
                case "m":
                    engine.MultiplicationGame("Multiplication");
                    break;
                case "d":
                    engine.DivisionGame("Division");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }
}
