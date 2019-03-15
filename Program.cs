using System;

class JosephusProblem
{
    

    static void Main(string[] args)
    {
        Console.WriteLine("Enter Total number of persons");
        int Persons = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of persons to skip");
        int peopleToSkip = int.Parse(Console.ReadLine());

        int safePosition = Josephus(Persons, peopleToSkip);

        Console.WriteLine("The position of person saved is " + safePosition);
        Console.ReadKey();
    }
    public static int Josephus(int Persons, int peopleToSkip)
    {
        if (Persons == 1)
            return 1;
        else
            return (Josephus(Persons - 1, peopleToSkip) + peopleToSkip - 1) % Persons + 1;
    }

}