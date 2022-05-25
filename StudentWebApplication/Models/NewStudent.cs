using System;
using System.Collections.Generic;

namespace StudentWebApplication.Models
{
    public partial class NewStudent
    {
        public int Studentid { get; set; }
        public string StudentName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public string University { get; set; }
        public string City { get; set; }
    }
}
