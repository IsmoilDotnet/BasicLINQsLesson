using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Methods
{
    public class LINQSForUniversity
    {
        public List<University> GetAll()
        {
            List<University> list = new List<University>()
            {
                new University { Id = 1, Name = "Westminster", Location = "Chilonzor", Students  =
                new List<Students>() {
                    new Students() { Id = 1, Age = 27, Status = "Contract", FirstName = "Akramjon", LastName = "Abduvahobov" },
                    new Students() { Id = 2, Age = 20, Status = "Contract", FirstName = "Abduxoliq", LastName = "Abduxoliqov" },
                    new Students() { Id = 3, Age = 23, Status = "Budget", FirstName = "Muhammad Abdulloh", LastName = "Muhammad Abdullohov" },
                    new Students() { Id = 4, Age = 40, Status = "Contract", FirstName = "Ikromjon", LastName = "Ikromjon" },
                } },
                new University { Id = 2, Name = "Pedinst", Location = "Mirzo Ulug'bek", Students  =
                new List<Students>() {
                    new Students() { Id = 1, Age = 30, Status = "Budget", FirstName = "Akramjon Mohirdev", LastName = "Abduvahobov Mohirdev" },
                    new Students() { Id = 2, Age = 17, Status = "Contract", FirstName = "Abduxoliq Mohirdev", LastName = "Abduxoliqov Mohirdev" },
                    new Students() { Id = 3, Age = 20, Status = "Budget", FirstName = "Muhammad Abdulloh Mohirdev", LastName = "Muhammad Abdullohov Mohirdev" },
                    new Students() { Id = 4, Age = 31, Status = "Budget", FirstName = "Ikromjon Mohirdev", LastName = "Ikromjon Mohirdev" },
                } },

            };

            return list;
        }
        public IEnumerable<string> GetAllCenter()
        {
            var centers = GetAll().Select(x => x.Name);

            return centers;
        }

        public IEnumerable<University> GetCenterByName(string name)
        {
            var centers = GetAll().Select(x => x).Where(z => z.Name == name);

            return centers;
        }

        public IEnumerable<Students> GetCenterByNameWithStatus(string name)
        {
            var result = GetAll().SelectMany(x => x.Students).Where(z => z.Status == "Contract");

            return result;
        }

    }
}
