using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSchoolDB.Models
{
    [Table("Class_")]
    public class Class_
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        [StringLength(50)]
        public string CName { get; set; }
        public virtual ICollection<Subject_> Subject_s { get; set; }
        public virtual ICollection<Student_Class> Student_Classes { get; set; }
    }

}