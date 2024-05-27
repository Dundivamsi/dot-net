using System;
namespace ConsoleApplication1
{
    public class Program
    {
        public void test1()
        {
            test2();
            //Console.WriteLine("csharp");
        }
        private void test2()
        {
            //Console.WriteLine("python");
        }
        public static void Main(string[] args)
        {
            Program a123 = new Program();
            //a123.test1();
            //a123.test2();
            Console.WriteLine("Hello World12345678910!");
        }
        
    }
}