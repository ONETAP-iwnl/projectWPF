using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace StudentCard
{
    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Group { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
