using Blah;

namespace EigenTypes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 2;
            DagVanWeek dag = DagVanWeek.Donderdag;
            Console.WriteLine((int)dag);

            DagVanWeek dag2 = (DagVanWeek)5;
            Console.WriteLine(dag2);

        }
    }

   
}
