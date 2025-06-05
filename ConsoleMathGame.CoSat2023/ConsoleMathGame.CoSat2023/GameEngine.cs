using ConsoleMathGame.CoSat2023.Models;

namespace ConsoleMathGame.CoSat2023;

internal class GameEngine
{
    int roundsPerGame = 5;

    internal void DivisionGame(string message)
    {
        var score = 0;

        for (int i = 0; i < roundsPerGame; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type Enter for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type Enter for the next question.");
                Console.ReadLine();
            }

            if (i == roundsPerGame - 1)
            {
                Console.WriteLine($"Game over. Your final score was {score}. Press Enter to go back to the main menu.");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
    internal void MultiplicationGame(string message)
    {
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < roundsPerGame; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type Enter for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type Enter for the next question.");
                Console.ReadLine();
            }

            if (i == roundsPerGame - 1)
            {
                Console.WriteLine($"Game over. Your final score was {score}. Press Enter to go back to the main menu.");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Multiplication);

    }
    internal void SubtractionGame(string message)
    {
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0;i < roundsPerGame;i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type Enter for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type Enter for the next question.");
                Console.ReadLine();
            }

            if (i == roundsPerGame - 1)
            {
                Console.WriteLine($"Game over. Your final score was {score}. Press Enter to go back to the main menu.");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Subtraction);
    }
    internal void AdditionGame(string message)
    {
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < roundsPerGame;i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber= random.Next(1, 9);
            secondNumber= random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine($"Your answer was correct. Type Enter for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type Enter for the next question.");
                Console.ReadLine();
            }

            if (i == roundsPerGame - 1)
            {
                Console.WriteLine($"Game over. Your final score was {score}. Press Enter to go back to the main menu.");
                Console.ReadLine();
            }

        }

        Helpers.AddToHistory(score, GameType.Addition);
    }
}
