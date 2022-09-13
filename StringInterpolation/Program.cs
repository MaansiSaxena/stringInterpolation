using System;

namespace StringInterpolation
{ 
    class employee
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string name = "Mansi";
            var date = DateTime.Now;

            //normal printing methods:
            Console.WriteLine("Hello " + name + " it is " + DateTime.Now);
            Console.WriteLine("Hello {0} Today is {1} ", name, DateTime.Now);

            //string interpolation    suitable for long paragraph
            Console.WriteLine($"Hello {name} Today date is {DateTime.Now}");
            */

            employee emp = null;
            //string employee = (emp != null) ? emp.name : null; //
            emp?.name
            Console.WriteLine(employee);
        }
    }
}
