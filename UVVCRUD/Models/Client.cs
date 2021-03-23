using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UVVCRUD.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surename{ get; set; }

        public string Email{ get; set; }

        public DateTime BirthDate { get; set; }

        public string CPF { get; set; }

        public int Age { get; set; }

        public string Job{ get; set; }

        public string Password { get; set; }
    }
}
