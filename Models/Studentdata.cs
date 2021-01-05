using System;
using System.ComponentModel;

namespace Models
{
    public class Studentdata
    {
        [DisplayName("Student ID")]
        public string Studentid { get; set; }

        [DisplayName("Student Name")]

        public string StudentName { get; set; }

        [DisplayName("ISEM1 Marks")]
        public string ISEM1 { get; set; }

        [DisplayName("ISEM2 Marks")]

        public string ISEM2 { get; set; }

        [DisplayName("ISEM3 Marks")]
        public string ISEM3 { get; set; }
    }
}

