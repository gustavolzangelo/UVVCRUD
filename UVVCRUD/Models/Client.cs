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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surename{ get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email{ get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Digite um CPF válido.")]
        public string CPF { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Job{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Digite uma senha válida.")]
        public string Password { get; set; }
    }
}
