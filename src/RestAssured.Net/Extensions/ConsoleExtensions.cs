using System;
using System.Collections.Generic;
using static System.Console;

namespace RA.Extensions
{
    public static class EnumerationExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action.Invoke(item);
            }
        } 
    }

    public static class ConsoleExtensions
    {
        public static void WriteHeader(this string source, params object[] objects)
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(source, objects);
            ResetColor();
        }

        public static void WriteLine(this string source, params object[] objects)
        {
            ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- " + source, objects);
            ResetColor();
        }

        public static void Write(this string source, params object[] objects)
        {
            ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(source, objects);
            ResetColor();
        }

        public static void WriteTest(this KeyValuePair<string, bool> source)
        {
            if (source.Value)
            {
                WritePassedTest();
            }
            else
            {
                WriteFailedTest();
            }

            ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" : {0}", source.Key);
            ResetColor();

            

            ResetColor();
        }

        public static void WritePassedTest()
        {
            ForegroundColor = ConsoleColor.Green;
            Console.Write("- Passed");
            ResetColor();
        }

        public static void WriteFailedTest()
        {
            ForegroundColor = ConsoleColor.Red;
            Console.Write("- Failed");
            ResetColor();
        }
    }
}