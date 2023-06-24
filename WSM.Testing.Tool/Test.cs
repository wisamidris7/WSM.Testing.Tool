namespace WSM.Testing.Tool
{
    public class Test
    {
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
        public void Run(List<(string name, string desc, Action action)> values)
        {
            Console.WriteLine("Write Any Of This Options");
            Console.WriteLine();
            foreach (var item in values)
            {
                Console.WriteLine($"{item.name} For => {item.desc}");
            }
            Console.Write("What Option : ");
            var line = Console.ReadLine();
            foreach (var item in values)
            {
                if (line == item.name)
                {
                    item.action();
                    break;
                }
                if (line == item.desc)
                {
                    item.action();
                    break;
                }
            }
        }
    }
}