namespace ControlFlow
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            // Short cut for an if/else statement
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            // Switch Statement

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is Autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("It is finally Summer");
                    break;

                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("We have got a promotion");
                    break;

                default:
                    Console.WriteLine("None of the seasons!");
                    break;
            }

        }
    }
}