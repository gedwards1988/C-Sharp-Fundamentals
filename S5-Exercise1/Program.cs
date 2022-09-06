namespace S5_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            int[] numberList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter a number between 1 and 10!\n");
            int number = Convert.ToInt32(Console.ReadLine());

            if (numberList.Contains(number))
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }


            // Question 2
            Console.WriteLine("Please enter first number!\n");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number!\n");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int maxValue = Math.Max(number1, number2);

            Console.WriteLine(String.Format("The Maximum of the 2 numbers is: {0}", maxValue));


            // Question 3
            Console.WriteLine("Please enter height!\n");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter width!\n");
            int width = Convert.ToInt32(Console.ReadLine());

            string orientation = (height > width) ? "Potrait" : "Landscape";
            Console.WriteLine(orientation);


            // Question 4
            Console.WriteLine("Enter Speed Limit!");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of your car?");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (speed - limit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}