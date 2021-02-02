using System;

namespace CS133PROJECT9
{
    class Program
    {
        private delegate void MyMethodPointer(int a, int b);

        static void Main(string[] args)
        {
            MyMethodPointer pointer;


            Myclass myclass = new Myclass();

            pointer = myclass.SumOfNumber;
            pointer += myclass.SubstractionOfNumbers;
            pointer += myclass.MultiplicationOfNumber;
            pointer += myclass.DivisionOfNumber;



            pointer -= myclass.SumOfNumber;
            pointer -= myclass.SubstractionOfNumbers;
            

            pointer(8, 2);

        }
    }
}

public class Myclass
{
    public void SumOfNumber(int parameter1, int parameter2)
    {
      Console.WriteLine(parameter1 + parameter2); 
    }

    public void SubstractionOfNumbers(int x, int y)
    {
        Console.WriteLine(x - y);
    }

    public void MultiplicationOfNumber(int d, int e)
    {
        Console.WriteLine(d * e);
    }

    public void DivisionOfNumber(int d, int e)
    {
        Console.WriteLine(d / e);
    }
}
