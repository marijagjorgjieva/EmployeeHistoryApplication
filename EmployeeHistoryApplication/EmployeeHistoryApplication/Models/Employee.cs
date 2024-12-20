﻿using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace EmployeeHistoryApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Adress { get; set; }
        public string? EMBG { get; set; }

        public ICollection<JobHistory> jobs { get; } = new List<JobHistory>();

    }
}
