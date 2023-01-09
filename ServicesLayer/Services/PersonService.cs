using DomainLayer.Models;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services
{
    public class PersonService : IPersonService
    {
        public int GetBySalary(int salary)
        {
            var persons = GetAll();

            return persons.FindAll(m => m.Salary > salary).Count;



        }





        private List<Person> GetAll()
        {
            return new List<Person>() { new Person { Id = 1, Name = "Hesen",Surname ="Hesenov",Address="Xetai",Salary = 2000 },
                new Person{ Id = 2,Name = "Qadir",Surname ="Qadirov",Address="Ehmedli",Salary = 900},
                new Person{ Id = 3,Name = "Subhan",Surname ="Kazimov",Address="Nizami",Salary = 3000},
                new Person{ Id = 4,Name = "Yasin",Surname ="Recebov",Address="Nizami",Salary = 1200} };

        }

        
    }
}
