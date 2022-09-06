using System;

namespace S6_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Question 1
             * Write a program and continuously ask the user to enter 
             * different names, until the user presses Enter (without supplying a name). 
             * Depending on the number of names provided, display a message 
             * based on the above pattern.*/

            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name: (or hit 'ENTER' to quit)\n>>");
                var name = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                names.Add(name);
            }

            switch(names.Count)
            {
                case > 2:
                    Console.WriteLine(String.Format("{0} and {1} like your post and {2} others like your post ", names[0], names[1], names.Count - 2));
                    break;
                case 2:
                    Console.WriteLine(String.Format("{0} and {1} like your post", names[0], names[1]));
                    break;
                case 1:
                    Console.WriteLine(String.Format("{0} likes your post", names[0]));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }



            /* Question 2
             * Write a program and ask the user to enter their name. Use an 
             * array to reverse the name and then store the result in a new 
             * string. Display the reversed name on the console.*/

            Console.Write("What's your name? ");
            var username = Console.ReadLine();

            var array = new char[username.Length];
            for (var i = username.Length; i > 0; i--)
                array[username.Length - i] = username[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);



            /* Question 3
             * Write a program and ask the user to enter 5 numbers. 
             * If a number has been previously entered, display an error 
             * message and ask the user to re-try. Once the user successfully 
             * enters 5 unique numbers, sort them and display the result on 
             * the console.*/

            var number_list = new List<int>();

            while (number_list.Count < 5)
            {
                Console.WriteLine("Enter a number: \n");
                var integer = Convert.ToInt32(Console.ReadLine());
                if (number_list.Contains(integer))
                {
                    Console.WriteLine("You have already entered that number!");
                }
                else
                {
                    number_list.Add(integer);
                }
            }
            number_list.Sort();

            foreach(var n in number_list)
            {
                Console.WriteLine(n);
            }

            /* Question 4
             * Write a program and ask the user to continuously enter a number 
             * or type "Quit" to exit. The list of numbers may include duplicates. 
             * Display the unique numbers that the user has entered.*/

            var total_list = new List<int>();

            while(true)
            {
                Console.WriteLine("Enter a number or type 'quit' to exit\n>>");
                var user_number = Console.ReadLine();

                if (user_number.ToLower() == "quit")
                {
                    break;
                }

                total_list.Add(Convert.ToInt32(user_number));

            }

            var unique_list = new List<int>();
            
            foreach(var t in total_list)
            {
                if (!unique_list.Contains(t))
                {
                    unique_list.Add(t);
                }
            }

            foreach(var x in unique_list)
            {
                Console.WriteLine(x);
            }


            /* Question 5
             * Write a program and ask the user to supply a list of comma 
             * separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty 
             * or includes less than 5 numbers, display "Invalid List" 
             * and ask the user to re-try; otherwise, display the 3 smallest 
             * numbers in the list.*/

            string[] elements;
            while(true)
            {
                Console.WriteLine("Enter a list of comma separated numbers (5 numbers or more)\n>>>");
                var input_value = Console.ReadLine();

                if (!String.IsNullOrEmpty(input_value))
                {
                    elements = input_value.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                    
                }
                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach(var e in elements)
            {
                numbers.Add(Convert.ToInt32(e));
            }

            numbers.Sort();
            Console.WriteLine("The 3 smallest numbers are:");

            for(var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}