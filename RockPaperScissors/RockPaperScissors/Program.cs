Random random= new Random();
bool playAgain= true; 
string player;
string computer;

while (playAgain)
{
    player= " ";
    computer=" "; 
    while (player != "rock" && player != "paper" && player != "scissors") {
    System.Console.WriteLine("Enter rock, paper, or scissors");
    player=Console.ReadLine();
    player= player.ToLower();
}
  
  switch(random.Next( 1,4))
    {
        case 1 :
        computer = "rock";
        break;
        case 2: 
        computer= "paper";
        break; 
        case 3 :
        computer = "scissors";
        break;
    }
    System.Console.WriteLine(" Player:" + player);
    System.Console.WriteLine(" computer:" + computer);
 }
