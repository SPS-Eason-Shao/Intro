namespace Intro;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, L8!");

        IntroTaskOne();

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
}

