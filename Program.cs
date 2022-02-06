string moves = "Please enter your move : \n r - rock \n p - paper \n s - scissors \n\n";
int playerWins = 0;
int computerWins = 0;
int ties = 0;
int roundsPlayed = 0;

Console.ResetColor();
Console.WriteLine("Welcome to a game of Rock, Paper, Scissors!");
Console.WriteLine("The rules are simple: \n Rock beats Scissors \n Scissors beats Paper \n Paper beats Rock");
Console.WriteLine("The first to 5 wins!");
Console.WriteLine(moves);

for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Round " + (i + 1));
    Console.WriteLine("Player: " + playerWins + " Computer: " + computerWins + " Ties: " + ties);
    string playerAnswer = CheckAnswer(Console.ReadLine());
    string computerAnswer = GenerateComputerAnswer();
    PlayGame(playerAnswer, computerAnswer);

    if (playerWins == 5 || computerWins == 5)
    {
        break;
    }
}



string CheckAnswer(string input)
{
    input = input.ToLower();
    switch (input)
    {
        case "r":
            Console.WriteLine("You chose Rock");
            return "Rock";
        case "p":
            Console.WriteLine("You chose Paper");
            return "Paper";
        case "s":
            Console.WriteLine("You chose Scissors");
            return "Scissors";
        default:
            Console.WriteLine("Invalid input");
            Console.WriteLine("Please try again");
            Console.WriteLine(moves);
            return CheckAnswer(Console.ReadLine());
    }
}
string GenerateComputerAnswer()
{
    string b = "";

    Random rnd = new Random();
    int random = rnd.Next(1, 4);
    switch (random)
    {
        case 1:
            b = "Rock";
            break;
        case 2:
            b = "Paper";
            break;
        case 3:
            b = "Scissors";
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("The computer chose " + b);
    return b;

}
void PlayGame(string a, string b)
{
    if (a == b)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("It's a tie!");
        Console.ResetColor();
        ties++;
    }
    else if (a == "Rock" && b == "Scissors")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!");
        Console.ResetColor();
        playerWins++;
    }
    else if (a == "Rock" && b == "Paper")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose!");
        Console.ResetColor();
        computerWins++;
    }
    else if (a == "Paper" && b == "Rock")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!");
        Console.ResetColor();
        playerWins++;
    }
    else if (a == "Paper" && b == "Scissors")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose!");
        Console.ResetColor();
        computerWins++;
    }
    else if (a == "Scissors" && b == "Rock")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose!");
        Console.ResetColor();
        computerWins++;
    }
    else if (a == "Scissors" && b == "Paper")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!");
        Console.ResetColor();
        playerWins++;
    }
    roundsPlayed++;
}



