Random random= new Random(); 
bool playAgain= true; 
int min=1;
int max=100; 
int guess; 
int number; 
int guesses; 
string response; 

while (playAgain)
{
    guess = 0 ; 
    guesses=0 ; 
    number=random.Next(min, max); 
while (guess!= number)
    {
        System.Console.WriteLine("Guess a number between" + min + "-"+ max + ":");
        guess= Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Guess:"+ guess);


        if(guess > number)
        {
            System.Console.WriteLine(guess +" is too high");
        }
       else if ( guess < number)
        {
            System.Console.WriteLine(guess+ "is too low");
        }
        guesses++ ; 
    }  
    System.Console.WriteLine("Number:" + number);
    System.Console.WriteLine("You Win!");
    System.Console.WriteLine("quesses:"+ guesses);
    System.Console.WriteLine(" would you like to play again? (Y/N)");
    response= Console.ReadLine(); 
    if (response="Y")
    {
        playAgain=true; 
    }
    else if (response="N"); 
    playAgain= false;
}