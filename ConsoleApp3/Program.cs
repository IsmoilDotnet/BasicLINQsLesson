using ConsoleApp3.Methods;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQS data = new LINQS();
            
            //List<int> numbers = new List<int>()
            //{
            //    232,4,45,4,5,6,64,54,3,43,5,46,4,534,24,325,346,457,4674,4523,432,5,3457,467,446,32,4,1,2,3,4,5,6
            //};

            //var result = numbers.TakeLast(3);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            Console.WriteLine("1)C++\n2)C#\n3)Python\n4)Javascript\nEtner language id: ");
            var result = Console.ReadLine();
            
            Console.Clear();
            
            int res = Int32.Parse(result);
            Console.WriteLine("Accountants:\n");

            foreach (var item in data.GetLanguagesFromList(res))
            {
                Console.WriteLine($"Language: { item.Name}");
            }

            foreach (var item in data.GetBuxgaltersByKnowingLanguage(res))
            {
                Console.Write($"ID: {item.Id} |");
                Console.Write($" Name: {item.Name} |");
                Console.WriteLine($" Language ID: { item.ProgrammingLanguageId}");
            }

            Console.WriteLine();

            Main(args);
        }
    }
}
