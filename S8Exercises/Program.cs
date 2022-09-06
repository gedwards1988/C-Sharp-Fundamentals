using System.Linq.Expressions;
using System.Net.WebSockets;

namespace S8Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Question 1
             * Write a program and ask the user to enter a few numbers separated 
             * by a hyphen. Work out if the numbers are consecutive. For example, 
             * if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
             * "Consecutive"; otherwise, display "Not Consecutive". */

            Console.WriteLine("Please enter numbers separaeted by - :");
            var input = Console.ReadLine();

            var raw_string = input.Split('-');

            var raw_numbers = new List<int>();
            foreach(var x in raw_string)
            {
                raw_numbers.Add(Convert.ToInt32(x));
            }

            raw_numbers.Sort();

            var isConsecutive = true;
            for(int i = 1; i < raw_numbers.Count; i++)
            {
                if(raw_numbers[i] != raw_numbers[i-1] + 1)
                {
                    isConsecutive = false;
                }
            }

            var message = isConsecutive ? "Cosnecutive" : "Not Consecutive";
            Console.WriteLine(message);



            /* Question 2#
             * Write a program and ask the user to enter a few numbers separated by 
             * a hyphen. If the user simply presses Enter, without supplying an input, 
             * exit immediately; otherwise, check to see if there are duplicates. 
             * If so, display "Duplicate" on the console.*/

            Console.WriteLine("Please enter numbers separated by - :");
            var input2 = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input2))
            {
                return;
            }
            // Split the string by hypen
            var raw_string2 = input2.Split('-');
            // Create a list and loop through string
            // Convert to number
            var raw_numbers2 = new List<int>();
            foreach(var num in raw_string2)
            {
                raw_numbers2.Add(Convert.ToInt32(num));
            }

            // Unique List
            var isDuplicate = false;

            var unique_numbers = new List<int>();
            foreach(int x in raw_numbers2)
            {
                if(!unique_numbers.Contains(x))
                {
                    unique_numbers.Add(x);
                }
                else
                {
                    isDuplicate = true;
                    break;
                }
            }

            if(isDuplicate)
            {
                Console.WriteLine("Duplicate Present");
            }



            /* Question 3
             * Write a program and ask the user to enter a time value in the 24-hour 
             * time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. 
             * If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
             * If the user doesn't provide any values, consider it as invalid time.*/

            Console.Write("Enter time: ");
            var time_input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(time_input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = time_input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }



            /* Question 4
             * Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. For example, 
             * if the user types: "number of students", display "NumberOfStudents". 
             * Make sure that the program is not dependent on the input. So, if the user 
             * types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/

            // Input
            Console.Write("Enter a few words: ");
            var raw_words = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(raw_words))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in raw_words.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);



            /* Question 5
             * Write a program and ask the user to enter an English word. Count the number 
             * of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
             * the program should display 6 on the console.*/

            Console.WriteLine("Enter an English Word:\n>>>>>>");
            var eng_word = Console.ReadLine().ToLower();

            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var vowel_count = 0;

            foreach(var letter in eng_word)
            {
                if(vowels.Contains(letter))
                {
                    vowel_count++;
                }
            }

            Console.WriteLine("Number of Vowels: {0}", vowel_count);
        }

    }
    
}