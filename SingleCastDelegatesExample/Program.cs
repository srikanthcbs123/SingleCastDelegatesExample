using System;

namespace SingleCastDelegatesExample
{
    class Class1
    {
        //create target method
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is " + c);
        }
        public void subtract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("subtraction is " + c);
        }
        public void Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("multiplication is " + c);
        }
        public void Division(int a,int b)
        {
            int result = a / b;
            Console.WriteLine("division is" + result);
        }

    }

    //create or declaring the  a delegate type
//synatax://accmodifier delgate returntype yourdelegatename(your target method arguments pass)
    public delegate void MyDelegateType(int a, int b);//declaring the delegate here.

    class Program
    {
        static void Main()
        {
            //create a delegate refrence variable
            MyDelegateType d;

            //create object/instance
            Class1 c1 = new Class1();

            //store the address of Add method into delegate here
            d = c1.Add;//----single cast delegate
            //d += c1.subtract;//--multicaste delegate(implemented by + operator)
            //d += c1.Multiply;
            //d += c1.Division;
            //call the Add/subtarct/multiply/divison method using delegate
            d(10, 20);
            

            Console.ReadKey();
        }
    }
}


