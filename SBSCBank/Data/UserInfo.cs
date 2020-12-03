using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SBSCBank.Data
{
    public class UserInfo
    {
        [Key]
        
        public int UserInfoId { get; set; }   
       
        [ForeignKey("UserInfo")]
        public int UserId { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }
        [MinLength(11),MaxLength(13)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(3)]
        public string Age { get; set; }
        public virtual User User { get; set; }
        

    }
}
