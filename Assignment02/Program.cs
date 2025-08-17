using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        #region Q03 
        //static void ReverseQueue(Queue<int> q)
        //{
        //    Stack<int> st = new Stack<int>();
        //    while (q.Count > 0)
        //    {
        //        st.Push(q.Dequeue());
        //    }

        //    while (st.Count > 0)
        //    {
        //        q.Enqueue(st.Pop());
        //    }
        //}
        #endregion
        #region Q04 
        //static bool IsBalanced(string str)
        //{
        //    Stack<char> st = new Stack<char>();

        //    foreach (char c in str)
        //    {
        //        if (c == '(' || c == '[' || c == '{')
        //        {
        //            st.Push(c);
        //        }
        //        else if (c == ')' || c == ']' || c == '}')
        //        {
        //            if (st.Count == 0) return false;

        //            char top = st.Pop();

        //            if ((c == ')' && top != '(') ||
        //                (c == ']' && top != '[') ||
        //                (c == '}' && top != '{'))
        //            {
        //                return false; // mismatch
        //            }
        //        }
        //    }

        //    return st.Count == 0;
        //}
        #endregion
        #region Q05
        //static List<int> RemoveDuplicates(int[] arr)
        //{
        //    List<int> unique = new List<int>();

        //    foreach (int num in arr)
        //    {
        //        if (!unique.Contains(num)) 
        //        {
        //            unique.Add(num);
        //        }
        //    }

        //    return unique;
        //}
        #endregion
        #region Q06
        static void RemoveOdd(ArrayList arr)
        {
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if ((int)arr[i] % 2 != 0) 
                {
                    arr.RemoveAt(i);
                }
            }
        }

        #endregion
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

            //int n = int.Parse(Console.ReadLine());
            //string[] numbers = Console.ReadLine().Split();

            //List<int> arr = new List<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(int.Parse(numbers[i]));
            //}


            //List<int> reversed = new List<int>(arr);
            //reversed.Reverse();


            //if (arr.SequenceEqual(reversed))
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Q03
            //Queue<int> q = new Queue<int>();


            //q.Enqueue(10);
            //q.Enqueue(20);
            //q.Enqueue(30);
            //q.Enqueue(40);

            //Console.WriteLine("Original Queue: " + string.Join(" ", q));

            //ReverseQueue(q);

            //Console.WriteLine("Reversed Queue: " + string.Join(" ", q));

            #endregion

            #region Q04

            //string input = Console.ReadLine();

            //Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");

            #endregion

            #region Q05 
            //int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            //List<int> result = RemoveDuplicates(arr);

            //Console.WriteLine("Array without duplicates: " + string.Join(" ", result));
            #endregion

            #region Q06 
            ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Original ArrayList: " + string.Join(" ", arr.ToArray()));

            RemoveOdd(arr);

            Console.WriteLine("After removing odds: " + string.Join(" ", arr.ToArray()));
            #endregion

            
        }
    }
}
