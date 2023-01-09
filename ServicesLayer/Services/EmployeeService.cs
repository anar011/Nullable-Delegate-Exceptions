﻿using DomainLayer.Models;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetCountByAge(int age)
        {
            var employees = GetAll();

            return employees.FindAll(m=>m.Age>age).Count;

        }

        private List<Employee> GetAll()
        {
          return  new List<Employee>() { new Employee { Id = 1, Name ="Mirze", Age=26},
                new Employee{Id=2,Name="Cahandar", Age = 26},new Employee {Id=3,Name = "Anar",Age=27} };
        }

    }
}
