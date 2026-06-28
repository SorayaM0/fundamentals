Console.WriteLine("Hello, welcome to calculator program");
Console.WriteLine("Please enter your first number");  
int num1= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please enter your second number");
int num2= Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("What type of operation do you want?");
System.Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication and d for division");

string answer= Console.ReadLine(); 

if(answer == "a")
{
  System.Console.WriteLine("resunt:" + (num1 +num2));
}
else if (answer == "s" )
{
    System.Console.WriteLine("resunt:" + (num1 - num2));
}
else if (answer == "m" )
{
    System.Console.WriteLine( "resunt:" + (num1 * num2) );
}
else if (answer == "d" )
{
    System.Console.WriteLine("resunt:" + (num1/ num2)); 
} 
