using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SBSCBank.Dtos
{
    public class UsersDto
    {
        public string UserName { get; set; }
        [MinLength(11), MaxLength(13)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(3)]
        public string Age { get; set; }
        public string Department { get; set; }
    }
}
