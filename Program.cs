while (true)
{
    Console.Clear();
    Console.WriteLine("Select Operation");
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Exit");

    string choice = Console.ReadLine();
        Console.Clear();

    if (choice == "5")
    {
        break;
    }

    int fn, sn;
    Console.WriteLine("Type the first number");
        if (!int.TryParse(Console.ReadLine(), out fn))
    {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Console.WriteLine("Press anything to go back");
        Console.ReadKey();
        continue;
    }

    Console.WriteLine("Type the second number");
        if (!int.TryParse(Console.ReadLine(), out sn))
    {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Console.WriteLine("Press anything to go back");
        Console.ReadKey();
        continue;
    }

    Console.WriteLine("Press anything to go back");
        switch (choice)
    {
        case "1":
        Console.WriteLine($"{fn+sn}");
        break;

        case "2":
        Console.WriteLine($"{fn-sn}");
        break;

        case "3":
        Console.WriteLine($"{fn*sn}");
        break;

        case "4":
        if (sn == 0)
        {
            Console.WriteLine("Undefined");
        }
        else
        Console.WriteLine($"{fn/sn}");
        break;

        default:
        Console.WriteLine("Invalid Operation");
        break;
    }
    Console.ReadKey();
}