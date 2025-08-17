using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //string[] firstLine = Console.ReadLine().Split();
            //int n = int.Parse(firstLine[0]);
            //int q = int.Parse(firstLine[1]);

            
            //ArrayList arr = new ArrayList();
            //string[] numbers = Console.ReadLine().Split();
            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(int.Parse(numbers[i]));
            //}

           
            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    // Linear Search
            //    for (int j = 0; j < arr.Count; j++)
            //    {
            //        if ((int)arr[j] > x)  
            //            count++;
            //    }

            //    Console.WriteLine(count);
            //}

            #endregion

            #region Q02 

            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();

            List<int> arr = new List<int>();

            
            for (int i = 0; i < n; i++)
            {
                arr.Add(int.Parse(numbers[i]));
            }

            
            List<int> reversed = new List<int>(arr);
            reversed.Reverse();

            
            if (arr.SequenceEqual(reversed))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            #endregion


        }
    }
}
