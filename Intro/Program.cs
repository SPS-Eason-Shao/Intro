namespace Intro;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, L8!");

        // IntroTaskOne();

        // IntroTaskTwo();

        IntroTaskThree();

        Console.ReadLine(); // Just to pause the program so that the terminal doesn't disappear suddenly
    }

    static void IntroTaskOne() // 05.09.2023 Task One
    {
        Console.WriteLine(
            "*******\n" +
            "*     *\n" +
            "*  0  *\n" +
            "* /|\\ *\n" +
            "* / \\ *\n" +
            "*******");
    }

    static void IntroTaskTwo() // 05.09.2023 Task Two
    {
        Console.WriteLine("Please input 1 for Centigrate to Farenheit and 2 for Farenheit to Centigrate");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Please input a temperature in Centigrate");

            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The temperature in Farenheit is: " + Centigrate2Farenheit(input).ToString("F2"));
        }
        else if (choice == "2")
        {
            Console.WriteLine("Please input a temperature in Farenheit");

            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The temperature in Centigrate is: " + Farenheit2Centigrate(input).ToString("F2"));
        }
    }

    static double Centigrate2Farenheit(double input) // Function for Task Two
    {
        return input * 1.8 + 32;
    }
    
    static double Farenheit2Centigrate(double input) // Function for Task Two
    {
        return (input - 32) / 1.8;
    }

    static void IntroTaskThree() // 05.09.2023 Task Three
    {
        Console.WriteLine("Please input the width, length of the room in metres in integers, and the price of carpet in pounds per metre squared.");

        string[] inputs = Console.ReadLine()!.Split();
        int roomWidth = int.Parse(inputs[0]), roomLength = int.Parse(inputs[1]), priceOfCarpet = int.Parse(inputs[2]);

        Console.WriteLine("The total price is: " + CarpetFitting(roomWidth, roomLength, priceOfCarpet));
    }

    static int CarpetFitting(int roomWidth, int roomLength, int priceOfCarpet) // Fuction for Task Three
    {
        const int priceOfUnderlay = 3, priceOfGrippers = 1, priceOfFitting = 50;

        int carpetPrice = roomWidth * roomLength * priceOfCarpet;
        int underlayPrice = roomWidth * roomLength * priceOfUnderlay;
        int grippersPrice = (2 * roomWidth + 2 * roomLength) * priceOfGrippers;

        return carpetPrice + underlayPrice + grippersPrice + priceOfFitting;
    }
}

