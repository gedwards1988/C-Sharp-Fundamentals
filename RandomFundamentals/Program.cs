namespace RandomFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate 10 random numbers
            var random = new Random();

            const int passwordLength = 100;

            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = ((char)('a' + random.Next(0, 26)));

            var password = new string(buffer);

            Console.Write(password);



        }
    }
}