using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Test");

            Class1 ourObject = new Class1();
            try
            {

            ourObject.TestClass();
            }
            catch (Exception e)
            {
                if (e.Message != null)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                else
                {

                throw;
                }
            }
        }
    }
}
