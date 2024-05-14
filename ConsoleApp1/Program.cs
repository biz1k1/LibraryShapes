using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        protected int Weidth { get; set; }
        protected int Height { get; set; }
    }
    class Rectengle : Shape
    {
        public void Print()
        {
            Console.WriteLine(Weidth);
        }
    }
    class Circle : Shape
    {

    }
    class Program
    {
        static void EnryPoint()
        {
            Rectengle rectengle = new Rectengle();
            rectengle.Print();
        }
    }
}
