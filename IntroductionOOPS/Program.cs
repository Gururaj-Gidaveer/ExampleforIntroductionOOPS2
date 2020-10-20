using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOPSInher
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Construtor called ");
            Console.WriteLine("ParentClass Construtor ==>called parent ");
        }
        public ParentClass(String Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class ChildClaas : ParentClass
    {
        public ChildClaas():base("Derived class controlling parent class")// "base " used to specify which constructor is called when we have more then two Constructor with Same Class Nmae
        {
            Console.WriteLine("ChildClass Constructor Called");
        }
    }
    public class Program
    {
        public static void Main()
        {
            ChildClaas CC = new ChildClaas();
        }
    }
}
