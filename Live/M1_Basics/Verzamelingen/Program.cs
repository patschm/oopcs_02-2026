using System.Diagnostics;
using System.Text;

namespace Verzamelingen;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array;
        array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;

        Console.WriteLine(array[2]);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.WriteLine(matrix[0,1]);

        int[][] jagged = new int[5][];
        jagged[0] = [1, 2, 3, 4];
        jagged[1] = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        for (int i = 0; i < array.Length; i++)
        {
            int tmp = array[i];
            Console.WriteLine(tmp);
        }

        foreach(int tmp in array)
        {
            Console.WriteLine(tmp);
        }

        List<int> list = new List<int>();

        list.AddRange(new int[] { 1, 2, 3, });
        list.Add(2);
           
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("een", 1);
        dictionary.Add("twee", 2);

        Console.WriteLine(dictionary["twee"]);



        Stopwatch watch = new Stopwatch();
        watch.Start();
        //string data = "";
        StringBuilder data = new StringBuilder(1000000);

        for(int i = 0; i < 1000_000; i++)
        {
           // data += i.ToString();
           data.Append(i.ToString());
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);

    }
}
