using ConsoleMathGame.CoSat2023.Models;

namespace ConsoleMathGame.CoSat2023;

internal class Helpers
{
    internal static List<Game> games = new List<Game>();
    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var result = new int[2];

        var firstNumber = random.Next(1, 9);
        var secondNumber = random.Next(1, 9);
        var product = firstNumber * secondNumber;

        while (firstNumber == secondNumber)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
            product = firstNumber * secondNumber;
        }

        result[0] = product;
        result[1] = firstNumber;

        return result;
    }
    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }
    internal static void PrintGames()
    {
        //var gamesToPrint = games.Where(x => x.Date > new DateTime(2025, 06, 04)).OrderByDescending(x => x.Score);

        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("---------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }
        Console.WriteLine("---------------------\n");
        Console.WriteLine("Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }
    internal static string? ValidateResults(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }
    internal static string GetName()
    {
        Console.WriteLine("Please type your name");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name can't be empty. Please enter your name.");
            name = Console.ReadLine();
        }

        return name;
    }

}
