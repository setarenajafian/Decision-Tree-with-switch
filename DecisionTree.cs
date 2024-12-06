using System;

Console.WriteLine("Welcome to our Car Exhibition ;)");
Console.WriteLine();

// questions 
string answer1 = GetYesOrNo("Are you interested in Iranian cars? (yes/no)");
string answer2 = GetYesOrNo("Do you prefer Automatic Gear ? (yes/no)");
string answer3 = GetYesOrNo("Do you want a used car? (yes/no)");

// unite answers to form our decisiontree
string decisionTree = answer1 + answer2 + answer3;

// Single switch statement to determine the right answer for customers
switch (decisionTree)
{
    case "yesyesyes":
        Console.WriteLine("I Recommand you a Renault ");
        break;
    case "yesyesno":
        Console.WriteLine("I Recommand you a Dena Plus ");
        break;
    case "yesnoyes":
        Console.WriteLine("I Recommand you a Peugeot 207");
        break;
    case "yesnono":
        Console.WriteLine("I Recommand you a Quick");
        break;
    case "noyesyes":
        Console.WriteLine("I Recommand you a Mitsubishi Pajero");
        break;
    case "noyesno":
        Console.WriteLine("I Recommend you a Mercedes Benz G Klasse");
        break;
    case "nonoyes":
        Console.WriteLine("I Recommend you a Toyota Hairakkusu");
        break;
    default:
        Console.WriteLine("unfortunately i can't help you. explore our exhibition to find your interests!");
        break;
}


// get only "yes" or "no" from the user
static string GetYesOrNo(string question)
{
    Console.WriteLine(question);
    while (true)
    {
        string input = Console.ReadLine();

        if (input == "yes" || input == "no")
        {
            return input;
        }
        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
    }
}