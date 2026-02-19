namespace EvolutieTheorieDerDelegates;

delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002/2003. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1,2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;
        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3,4);


        // 2007/2008. Framework 3.0/3.5
        // delegate is => (goes to)
        MathDel m4a = (int a, int b) =>
        {
            return a + b;
        };

        MathDel m4 =  (a, b) => a + b;

        result = m4(4, 5);

        // Procedure
        Action<string> a1 = DoeIets;
        a1("Hoi");

        a1 = (obj) => Console.WriteLine($"Wederom {obj}");
        a1("hoi");

        // Funtions

        Func<int, int, int> m5 = Add;

        result = m5(5,6);
               


        Console.WriteLine(result);


        // 2018
        int TelOp(int a, int b)
        {
            return a + b; 
        }

    }

    private static void DoeIets(string obj)
    {
        Console.WriteLine(obj);
    }

    static int Add(int a, int b)
    {
        return a + b; 
    }
}
