using System.Collections;

namespace AdvancedC02
{
    internal class Program
    {
        public static int SumofArrayList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList is not null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum = sum + (int?)arrayList[i] ?? 0;
                }
            }
            return sum;
        }
        public static int SumOfList(List<int> Numbers)
        {
            int Sum = 0;
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    Sum = Sum + Numbers[i];
                }

            }
            return Sum;
        }

        static void Main(string[] args)
        {
            #region Non_Generic Collections [ArrayList]
            //#region Part 01 
            //ArrayList arraylist = new ArrayList();

            //Console.WriteLine( $"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");

            ////function on array list 
            //arraylist.Add(1);
            //arraylist.Add(2);
            //arraylist.AddRange(new int[] {3,4});
            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");

            //arraylist.Add(5);
            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");
            //arraylist.TrimToSize();
            ////realese|deallcote |free | dlete unused bytes = 12 bytes
            //Console.WriteLine( "After tirming");
            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");
            #endregion

            #region Part 02 
            //ArrayList arraylist = new ArrayList(5);

            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");

            ////function on array list 
            //arraylist.Add(1);
            //arraylist.Add(2);
            //arraylist.AddRange(new int[] { 3, 4 , 5});
            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");
            //arraylist.Add(6);
            //Console.WriteLine($"Count : {arraylist.Count} :  Capacity : {arraylist.Capacity}");

            #endregion

            #region Part 03 
            //ArrayList arraylist = new ArrayList(5);


            //arraylist.Add(1); // casting from int [Value type ] To object [REf Type ] 
            //                  //Boxing
            //arraylist.Add(2);
            //arraylist.Add(3);
            //arraylist.Add(4);
            //arraylist.Add("Martin");//compiler cannot enforce type safty 
            //int result = SumofArrayList(arraylist);
            //Console.WriteLine( $"reslut = {result}");
            #endregion

            #region Genaric Collection List<T> 

            #region Part 01 
            //List<int> list = new List<int>();

            //Console.WriteLine($"Count : {list.Count} :  Capacity : {arraylist.Capacity}");

            ////function on array list 
            //list.Add(1);
            //list.Add(2);
            //list.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");

            //list.Add(5);
            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");
            //list.TrimExcess();
            ////realese|deallcote |free | dlete unused bytes = 12 bytes
            //Console.WriteLine("After tirming");
            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");
            #endregion

            #region Part 02 
            //List<int> list = new List<int>(5);

            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");

            ////function on array list 
            //list.Add(1);
            //list.Add(2);
            //list.AddRange(new int[] { 3, 4, 5 });
            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");
            //list.Add(6);
            //Console.WriteLine($"Count : {list.Count} :  Capacity : {list.Capacity}");

            #endregion

            #region Part 03 
            //List<int> Numbers = new List<int>(5);


            //Numbers.Add(1); // casting from int [Value type ] To object [REf Type ] 
            //                //Boxing
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(4);
            ////Numbers.Add("Martin");//compiler enforce type safty 
            //int result = SumOfList(Numbers);
            //Console.WriteLine($"reslut = {result}");
            #endregion
            #endregion
        }
    }
}
    

