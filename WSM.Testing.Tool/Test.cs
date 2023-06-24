using System;
using System.Collections.Generic;

namespace WSM.Testing.Tool
{
    public static class Test
    {
        public static string? GetValue(string value, string end)
        {
            Console.Write($"{value} {end} ");
            return Console.ReadLine();
        }
        public static string? GetValue(string value)
        {
            Console.Write($"{value} : ");
            return Console.ReadLine();
        }
        public static void Write(string value)
        {
            Console.Write(value);
        }
        public static void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        public static void Write(params object[] values)
        {
            Console.Write(values);
        }
        public static void WriteLine(params object[] values)
        {
            Console.WriteLine(values);
        }
        public static void Write(object value)
        {
            Console.Write($"{value}");
        }
        public static void WriteLine(object value)
        {
            Console.WriteLine($"{value}");
        }
        public static void Run(List<TestItem> values)
        {
            Console.WriteLine("Write Any Of This Options");
            Console.WriteLine();
            foreach (var item in values)
            {
                Console.WriteLine($"{item.Name} For => {item.Desc}");
            }
            Console.Write("What Option : ");
            var line = Console.ReadLine();
            foreach (var item in values)
            {
                if (line == item.Name)
                {
                    item.Action();
                    break;
                }
                if (line == item.Desc)
                {
                    item.Action();
                    break;
                }
            }
        }
    }
}