using Demo3.DAL.Models.EmployeeModels;
using Demo3.DAL.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.DAL.Models.EmployeeModels
{
    public class Employee :BaseEntity
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive {get; set; }
        public string? PhoneNumber {get; set; }
        public string? Email {get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
