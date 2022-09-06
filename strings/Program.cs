using System.Diagnostics.Tracing;
using System.Text;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trim additional space
            var fullName = "Gareth Edwards ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());
            
            // Split to first name and last name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);


            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            var sentence = "This is a really really really really really long text.";
            var summary = StringUtility.SummariseText(sentence, 20);
            Console.WriteLine(summary);

            Console.WriteLine(">>\n>>\n>>\n");

            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new String('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First Character: " + builder[0]);
        }

    }
}