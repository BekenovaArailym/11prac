﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeelib;

namespace Prac11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1;

            employee1.name = "Айрис";
            employee1.vacancy = Vacancies.PoliceOfficer;
            employee1.hireDate = new int[] { 2020, 9, 01 };
            employee1.salary = 1900000;

            Console.WriteLine($"Имя: {employee1.name}");
            Console.WriteLine($"Должность: {employee1.vacancy}");
            Console.WriteLine($"Время когда его приняли на работу: {employee1.hireDate[0]}.{employee1.hireDate[1]}.{employee1.hireDate[2]}");
            Console.WriteLine($"ЗП: {employee1.salary}");

            Console.ReadLine();
        }
    }
}
