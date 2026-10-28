using System;

namespace ConsoleApp1
{
    internal class MyArray
    {

        public static void ForEach(int[] array, Action<int> action)
        {
            foreach (int item in array)
            {
                action(item);
            }
        }

        public static int Count(int[] array, Predicate<int> match)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (match(item))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool Exists(int[] array, Predicate<int> match)
        {
            foreach(int item in array)
            {
                if (match(item))
                {
                    return true;
                }
            }
            return false;
        }
        
        public static int FindIndex(int[] array, Predicate<int> match)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (match(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
