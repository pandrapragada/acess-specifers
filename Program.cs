using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace acess_specifers
//{
//    public class program
//    {
//        private string name = "hima";
//        protected string descripation = "protected";
//        public int id = 102;

//        public void testAcess()
//        {
//            Console.WriteLine(name);
//            Console.WriteLine(descripation);
//            Console.WriteLine(id);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            program obj = new program();
//            obj.testAcess();
//            Console.ReadLine();
//        }
//    }
//}


//abstract class
//public abstract class Vehicle
//{
//    public abstract void display();
//}

//public class Bus : Vehicle
//{
//    public override void display()
//    {
//        Console.WriteLine("Bus");
//    }
//}
//public class MyClass
//{
//    public static void Main()
//    {
//        Vehicle v;
//        v = new Bus();
//        v.display();
//        Console.ReadLine();
//    }
//}
//interface 
interface IPolygon
{
    // method without body
    void calculateArea();

}
// implements interface
class Rectangle : IPolygon
{

    // implementation of IPolygon interface
    public void calculateArea()
    {

        int l = 30;
        int b = 90;
        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}
class Program
{
    static void Main(string[] args)
    {

        Rectangle r1 = new Rectangle();
        r1.calculateArea();
        Console.ReadLine();
    }
}



