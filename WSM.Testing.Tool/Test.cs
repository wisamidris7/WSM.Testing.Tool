using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WSM.Testing.Tool
{
    public class Test
    {
        public string? GetValue(string value, string end)
        {
            Console.Write($"{value} {end} ");
            return Console.ReadLine();
        }
        public string? GetValue(string value)
        {
            Console.Write($"{value} : ");
            return Console.ReadLine();
        }
        public void Write(string value)
        {
            Console.Write(value);
        }
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void Write(object value)
        {
            Console.Write($"{value}");
        }
        public void WriteLine(object value)
        {
            Console.WriteLine($"{value}");
        }
        public void Run(List<TestItem> values)
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
    public class TestItem
    {
        public TestItem()
        {
        }
        public TestItem(string name, string desc, Action action)
        {
            Name = name;
            Desc = desc;
            Action = action;
        }
        public TestItem(string name, Action action)
        {
            Name = name;
            Action = action;
        }
        public TestItem(string name, string desc, Func<Task> action)
        {
            Name = name;
            Desc = desc;
            Action = () => action();
        }
        public TestItem(string name, Func<Task> action)
        {
            Name = name;
            Action = () => action();
        }

        public string Name { get; set; }
        public string Desc { get; set; }
        public Action Action { get; set; }
    }
}