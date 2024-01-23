//setup our infinite loop to keep the program running
bool runProgram = true;
while (runProgram)
{
    //get user input
    Console.WriteLine("Welcome to the number analyzer! Please enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter an integer between 1 and 100:");
    int choice = int.Parse(Console.ReadLine());

    //ensure input is within the set parameters
    while (choice > 100 || choice < 1)
    {
        Console.WriteLine("That is an invalid selection. Please enter an integer between 1 and 100:");
        choice = int.Parse(Console.ReadLine());
    }

    //sorting logic
    if (choice % 2 != 0 && choice < 60)
    {
        Console.WriteLine(name + $", you've selected {choice}. {choice} is odd and less than 60");
    }
    else if (choice % 2 == 0 && choice >= 2 && choice <= 24)
    {
        Console.WriteLine(name + $", you've selected {choice}. {choice} is even and less than 25");
    }
    else if (choice % 2 == 0 && choice >= 26 && choice <= 60)
    {
        Console.WriteLine(name + $", you've selected {choice}. {choice} is even and between 26 and 60 inclusive");
    }
    else if (choice % 2 == 0 && choice > 60)
    {
        Console.WriteLine(name + $", you've selected {choice}. {choice} is even and greater than 60");
    }
    else if (choice % 2 != 0 && choice > 60)
    {
        Console.WriteLine(name + $", you've selected {choice}. {choice} is odd and greater than 60");
    }

    //check if user would like to continue
    Console.WriteLine("Would you like to continue using this program? Y/N");
    string progchoice = Console.ReadLine();
    if (progchoice == "Y")
    {
        runProgram = true;
    }
    else if (progchoice == "N")
    {
        Console.WriteLine("Thank you for using the number analyzer. Goodbye!");
        runProgram = false;
    }
}