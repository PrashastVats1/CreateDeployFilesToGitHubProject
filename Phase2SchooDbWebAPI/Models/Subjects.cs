using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase2SchoolDbWebAPI.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int SubID { get; set; }

        [Required]
        [StringLength(50)]
        public string SubName { get; set; }
    }
}
