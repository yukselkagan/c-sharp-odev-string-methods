using System;

namespace c_sharp_odev_string_methods
{
    class Program
    {
        static void Main(string[] args)
        {


            string text1 = "Hello world, how is going";
            string text2 = "Hello world";




            //Length
            Console.WriteLine(text1.Length);

            //ToUpper ToLower
            Console.WriteLine(text1.ToUpper());
            Console.WriteLine(text1.ToLower());

            //Concat
            Console.WriteLine(String.Concat(text1, "computer"));

            //Compare
            Console.WriteLine(text1.CompareTo(text2));
            Console.WriteLine(String.Compare(text1, text2, true));

            //Contain
            Console.WriteLine(text1.Contains(text2));
            Console.WriteLine(text1.StartsWith("Hello"));
            Console.WriteLine(text1.EndsWith("Hello"));

            //IndexOf
            Console.WriteLine(text1.IndexOf("world"));
            Console.WriteLine(text1.IndexOf("computer"));
            Console.WriteLine(text1.LastIndexOf("o"));

            //Insert
            Console.WriteLine(text1.Insert(0, "table"));

            //PadLeft PadRight
            Console.WriteLine(text1 + text2.PadLeft(30));
            Console.WriteLine(text1 + text2.PadLeft(30, '*'));
            Console.WriteLine(text1.PadRight(40) + text2);
            Console.WriteLine(text1.PadRight(40, '-') + text2);

            //Remove
            Console.WriteLine(text1.Remove(10));
            Console.WriteLine(text1.Remove(3, 5));
            Console.WriteLine(text1.Remove(0, 1));

            //Replace
            Console.WriteLine(text1.Replace("world", "table"));
            Console.WriteLine(text1.Replace(' ', '*'));

            //Split
            Console.WriteLine(text1.Split(' ')[1]);

            //Substring
            Console.WriteLine(text1.Substring(5));
            Console.WriteLine(text1.Substring(5, 6));






        }
    }
}
