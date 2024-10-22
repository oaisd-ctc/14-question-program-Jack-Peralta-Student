using System;

public class Program
{
    public static string name;
    public static string age;
    public static int agePlus5;
    public static string eyes;
    public static string hair;
    public static string shoeSize;
    public static string color;
    public static string fVmovie;
    public static string fVteacher;
    public static string fVclass;
    public static string fVholiday;
    public static string season;
    public static string dreamJob;
    public static string askNumberOfSiblings;

    public static void Main(string[] args)
    {
        Name();
        Age();
        Eyes();
        Hair();
        ShoeSize();
        Color();
        FVmovie();
        FVteacher();
        FVclass();
        FVholiday();
        FVseason();
        DreamJob();
        FutureAge();
        AskNumberOfSiblings();
        You();
    }

    public static void Name()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        //    Console.WriteLine(name);
    }

    public static void Age()
    {
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
    }

    public static void Eyes()
    {
        Console.WriteLine("What color are your eyes?");
        eyes = Console.ReadLine();
    }

    public static void Hair()
    {
        Console.WriteLine("What color is your hair?");
        hair = Console.ReadLine();
    }

    public static void ShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine();
    }

    public static void Color()
    {
        Console.WriteLine("What is your favorite color?");
        color = Console.ReadLine();
    }

    public static void FVmovie()
    {
        Console.WriteLine("What is your favorite movie or show?");
        fVmovie = Console.ReadLine();
    }

    public static void FVteacher()
    {
        Console.WriteLine("Who is your favorite teacher? (*Mr. Martinez cough*)");
        fVteacher = Console.ReadLine();
    }

    public static void FVclass()
    {
        Console.WriteLine("What is your favorite class? (*Mr. Martinez cough even louder*)");
        fVclass = Console.ReadLine();
    }

    public static void FVholiday()
    {
        Console.WriteLine("What is your Favotite Holiday");
        fVholiday = Console.ReadLine();
    }

    public static void FVseason()
    {
        Console.WriteLine("What is your Favorite season?");
        season = Console.ReadLine();
    }

    public static void DreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }

    public static void FutureAge()
    {
        agePlus5 = int.Parse(age);
        Console.WriteLine("You will be " + (agePlus5 + 5) + " in 5 years.");
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        askNumberOfSiblings = Console.ReadLine();
    }

    public static void You()
    {
        Console.WriteLine("My friend's name is " + name + ", " + name + " is " + age + " years old. Their eye color is "
         + eyes + ". Their hair color is " + hair + ". Their Shoe sizes are " + shoeSize + ". Their favorite color is "
          + color + ". Their favorite Movie/Show is " + fVmovie + ". Their favotire teacher is " + fVteacher +
           ". Their favorite class is " +  fVclass + ". Their favorite holiday is " + fVholiday + ". Their favotire season is "
            + season + ". Their dream job is " + dreamJob + " and their will be " + askNumberOfSiblings);
    }
}