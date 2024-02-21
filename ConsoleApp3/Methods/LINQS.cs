using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3.Methods
{
    public class LINQS
    {
        public List<BuxgalterModel> GetAllBuxgalters()
        {
            List<BuxgalterModel> list = new List<BuxgalterModel>()
            {
                new BuxgalterModel() { Id = 1, Name = "Johnny", ProgrammingLanguageId = 1},
                new BuxgalterModel() { Id = 2, Name = "Kimmy", ProgrammingLanguageId = 2 },
                new BuxgalterModel() { Id = 3, Name = "Martin", ProgrammingLanguageId = 1 },
                new BuxgalterModel() { Id = 4, Name = "Kavin", ProgrammingLanguageId = 2 },
                new BuxgalterModel() { Id = 5, Name = "Buzz", ProgrammingLanguageId = 3 },
                new BuxgalterModel() { Id = 6, Name = "Johnny Cage", ProgrammingLanguageId = 3},
                new BuxgalterModel() { Id = 7, Name = "Kimmy Laurens", ProgrammingLanguageId = 2 },
                new BuxgalterModel() { Id = 8, Name = "Martin Fernandes", ProgrammingLanguageId = 1 },
                new BuxgalterModel() { Id = 9, Name = "Kavin Makkalister", ProgrammingLanguageId = 4 },
                new BuxgalterModel() { Id = 10, Name = "Buzz Steven", ProgrammingLanguageId = 3 },
                new BuxgalterModel() { Id = 11, Name = "Johnny akmalxojayev", ProgrammingLanguageId = 1},
                new BuxgalterModel() { Id = 12, Name = "Kimmy Buzz", ProgrammingLanguageId = 2 },
                new BuxgalterModel() { Id = 13, Name = "Martin Doe", ProgrammingLanguageId = 1 },
                new BuxgalterModel() { Id = 14, Name = "Kavin Otabek", ProgrammingLanguageId = 4 },
                new BuxgalterModel() { Id = 15, Name = "Buzz Akmalxoja", ProgrammingLanguageId = 3},
                new BuxgalterModel() { Id = 16, Name = "Johnny Sardor", ProgrammingLanguageId = 1},
                new BuxgalterModel() { Id = 17, Name = "Kimmy Sarvar", ProgrammingLanguageId = 4 },
                new BuxgalterModel() { Id = 18, Name = "Martin Hayotilla", ProgrammingLanguageId = 3 },
                new BuxgalterModel() { Id = 19, Name = "Kavin Nuriddin", ProgrammingLanguageId = 2 },
                new BuxgalterModel() { Id = 20, Name = "Buzz Asadulloh", ProgrammingLanguageId = 4 },
            };



            return list;
        }

        public List<ProgrammingLanguageModel> GetLanguages()
        {
            List<ProgrammingLanguageModel> list = new List<ProgrammingLanguageModel>()
            {
                new ProgrammingLanguageModel() { Id = 1, Name = "C++"},
                new ProgrammingLanguageModel() { Id = 2, Name = "C#"},
                new ProgrammingLanguageModel() { Id = 3, Name = "Python"},
                new ProgrammingLanguageModel() { Id = 4, Name = "Javascript" },
            };
            return list;
        }


        public IEnumerable<BuxgalterModel> GetBuxgaltersByKnowingLanguage(int number)
        {
            var result = GetAllBuxgalters().Select(x => x).Where(z => z.ProgrammingLanguageId == number);

            return result;    
        }

        public IEnumerable<ProgrammingLanguageModel> GetLanguagesFromList(int id)
        {
            var result = GetLanguages().Select(x => x).Where(z => z.Id == id);
            return result;
        }
    }
}
