int playerRandomNum;
int enemeyRandomNum;
int playerPoint=0; 
int enemyPoint=0 ; 
Random random = new Random();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Press any key to roll the dice!");
    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine("You rolled : " + playerRandomNum);

    System.Console.WriteLine(".....");
    System.Threading.Thread.Sleep(1000);



    enemeyRandomNum = random.Next(1, 7);
    System.Console.WriteLine("Enemy rolled:" + enemeyRandomNum);

    if (playerRandomNum>enemeyRandomNum)
    {
        playerPoint++; 
        System.Console.WriteLine("Player wins this round");
    }
    else if ( playerRandomNum<enemeyRandomNum)
    {
        enemyPoint++; 
        System.Console.WriteLine("enemy wins this round");
    }
    else if (playerRandomNum==enemeyRandomNum)
    {
        System.Console.WriteLine("Both are equal, so no one wins ");
    }
    System.Console.WriteLine("The score of player is :" + playerPoint + "The score of enemy is :"+ enemyPoint);
    System.Console.WriteLine();
}

