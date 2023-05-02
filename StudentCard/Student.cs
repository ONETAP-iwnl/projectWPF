using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace StudentCard
{
    public class Student: Group2PK1
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
