using System;
using System.Threading.Tasks;

namespace WSM.Testing.Tool
{
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