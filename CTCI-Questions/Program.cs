using System;

class Program
{
    static void Main(string[] args)
    {
        TestChapter1();
    }

    private static void TestChapter1()
    {
        Console.WriteLine("Question 1");
        Console.WriteLine(Chapter1.Question1("abc"));
        Console.WriteLine(Chapter1.Question1("abbc"));

        Console.WriteLine("Question 2");
        Console.WriteLine(Chapter1.Question2("abc", "bca"));
        Console.WriteLine(Chapter1.Question2("abc", "bda"));

        Console.WriteLine("Question 3");
        Console.WriteLine(Chapter1.Question3("a b c"));

        Console.WriteLine("Question 4");
        Console.WriteLine(Chapter1.Question4("ttaacoc"));
        Console.WriteLine(Chapter1.Question4("ttadacoc"));
    }
}
