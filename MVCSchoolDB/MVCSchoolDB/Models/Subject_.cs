using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSchoolDB.Models
{
    [Table("Subject")]
    public class Subject_
    {
        [Key]
        public int SubId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubName { get; set; }
        public int CId { get; set; }
        public virtual Class_ Class_ { get; set; }
        public virtual ICollection<Student_Class> Student_Classes { get; set; }
    }

}