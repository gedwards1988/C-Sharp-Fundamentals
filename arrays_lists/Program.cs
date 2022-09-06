namespace arrays_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length of array: " + numbers.Length);


            // IndexOf() - find positional index
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);


            // Original Array
            Console.WriteLine("Original Array");
            foreach(var j in numbers)
            {
                Console.WriteLine(j);
            }


            // Clear() method - setting them to zero / boolean = flase / string = null
            Console.WriteLine("Effect of using Clear() for first 2 elements");
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            // Copy() method
            Console.WriteLine("Effect of using Copy() to get first 3 elements");
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            foreach(var n in another)
            {
                Console.WriteLine(n);
            }


            // Sort() method
            Console.WriteLine("Effect of the Sort() to put original array in ASC order");
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // Reverse() method
            Console.WriteLine("Effect of the Reverse() to put original array in DESC order ");
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }
    }
}