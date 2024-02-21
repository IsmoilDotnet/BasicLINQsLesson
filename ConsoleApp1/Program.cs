using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQSForUniversity data = new LINQSForUniversity();

            foreach (var university in data.GetCenterByName("Westminster"))
            {
                Console.WriteLine(university.Name);
            }

            foreach (var item in data.GetCenterByNameWithStatus("Westminster"))
            {
                Console.WriteLine(item.FirstName + " " + item.Status);
            }
        }
    }
}
