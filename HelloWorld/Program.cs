using System;

namespace HelloWorld
{
    class Program
    {
        /* void method does not return anything */
        static void Main(string[] args)
        {
            var x1 = "Hello";
            var x2 = "Gareth";
            Console.WriteLine("{0} Owen {1}", x1, x2);
            /* -------------------------------------------- */
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            /* -------------------------------------------- */
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
            /* -------------------------------------------- */
            try
            {
                var numberS = "1234";
                byte b = Convert.ToByte(numberS);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
            /* -------------------------------------------- */
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The value could not be converted to a boolean");
            }
            /* -------------------------------------------- */
            var num1 = 10;
            var num2 = 3;
            Console.WriteLine((float)num1 / (float)num2);
            /* -------------------------------------------- */
            var t1 = 1;
            var t2 = 2;
            var t3 = 3;
            Console.WriteLine((t1 + t2) * t3);
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1 == t2 || t1 < t2);
            Console.WriteLine(!(t1 != t2));

            if (t2 > t1)
            {
                Console.WriteLine("t2 is greater than t1");
            }

            for (int j =0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

        }
    }
}