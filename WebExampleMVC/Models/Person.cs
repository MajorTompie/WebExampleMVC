using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebExampleMVC.Models
{
    public class Person
    {
        public int personID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }
    }
}
