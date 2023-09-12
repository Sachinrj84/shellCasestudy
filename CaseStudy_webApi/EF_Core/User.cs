using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy_webApi.EF_Core
{
    [Table("User")]
    public class User
    {
        [Key,Required]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }=string.Empty;
        public string UserPhone { get; set; }
        

    }
}
