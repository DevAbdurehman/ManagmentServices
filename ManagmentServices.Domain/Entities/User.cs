using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentServices.Domain.Entities
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string FullName {  get; set; } = string.Empty;
    }
}
