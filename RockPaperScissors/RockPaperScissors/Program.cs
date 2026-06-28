Random random = new Random();
bool playAgain = true;
string answer;
string computer;
string player; 

while (playAgain)
{
     player = "";
     computer = "";
     answer= "";
    

    while (player != "rock" && player != "paper" && player != "scissors")
    {
        Console.Write("Enter rock, paper, or scissors: ");
        player = Console.ReadLine().ToLower();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "rock";
            break;
        case 2:
            computer = "paper";
            break;
        case 3:
            computer = "scissors";
            break;
    }

    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player)
    {
        case "rock" :
        if (computer== "rock")
            {
                System.Console.WriteLine("It's a draw");
            }
            else if (computer == "paper")
            {
                System.Console.WriteLine("You lose");
            } 
            else
            {
                System.Console.WriteLine("You win");
            }
        break; 
        case "paper" :
         if (computer== "rock")
            {
                System.Console.WriteLine("You win !");
            }
            else if (computer == "paper")
            {
                System.Console.WriteLine("it's a draw");
            } 
            else
            {
                System.Console.WriteLine("You lose !");
            }
        break; 
        case "scissors" :
        if (computer== "rock")
            {
                System.Console.WriteLine("You lose!");
            }
            else if (computer == "paper")
            {
                System.Console.WriteLine("You win");
            } 
            else
            {
                System.Console.WriteLine(" it's a draw  !");
            }
        break; 
    }
     System.Console.WriteLine("Would you like to play again (Y/N):");
     answer= Console.ReadLine(); 
     answer= answer.ToUpper();

     if (answer == "Y")
    {
        playAgain= true; 
    }
    else
    {
        playAgain= false; 
        System.Console.WriteLine("Thanks for playing");
    }

    } 