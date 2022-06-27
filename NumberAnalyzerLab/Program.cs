
while (true)
{
    string restartValue;
    Console.WriteLine("Hi! please enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter an integer between 1 and 100:");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    if (number > 0 && number <= 100)
    {
        if (number % 2 != 0 && number < 60)
        {
            Console.WriteLine(name + ", you entered " + number + ", which is odd and less than 60.");
        }
        else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            Console.WriteLine(name + ", You entered " + number + ", which is even and less than 25.");
        }
        else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            Console.WriteLine(name + ", You entered " + number + ", which is even and between 26 and 60 inclusive.");
        }
        else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine(name + ", You entered " + number + ", which is even and greater than 60.");
        }
        else if (number % 2 != 0 && number > 60)
        {
            Console.WriteLine(name + ", You entered " + number + ", which is odd and greater than 60.");
        }
    }
    else
    {
        Console.WriteLine(name + ", please pick a positive integer between 1 and 100.");
    }

    while (true)
    {
        Console.WriteLine("Would you like to restart? y/n.");
        restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            break;
        else
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
    }
}


