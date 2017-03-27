using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploy_runtime
{
    public class Student1
    {
        public virtual void Show()
        {
            Console.WriteLine("Hello From Student 1");
        }
    }
    public class Student2:Student1
    {

        public override void Show()
        {
            Console.WriteLine("Hello From Dervied class");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Student1 std;
            std = new Student1();
            std.Show();

            std = new Student2();
            std.Show();

            Console.ReadKey();


        }
    }
}
