namespace Variables;

internal class Program
{
    static void Main(string[] args)
    {
        int age = 42;
        string name;
        name = "Patrick";
        bool isMale = true;

        {
            float salary;
        }

       // age = age + 2;

        Console.WriteLine(isMale);

        Console.WriteLine(++age);
        Console.WriteLine(age);

        float res = 3 / 4F;
        Console.WriteLine(res);

        int a = 1;  // 0001
        int b = 2;  // 0010

        int c = a ^ b;

        Console.WriteLine(c);


        bool d = a == b;


        int? x = null;

        int y = x ?? 100;

        string? first = null;

        Console.WriteLine(first?.Length);


        long waarde = 100_000_000_000;
        int w2 = (int)waarde;

        Console.WriteLine(w2);

        bool isInt = w2 is int;
       // int w3 = waarde as int;


    }
}
