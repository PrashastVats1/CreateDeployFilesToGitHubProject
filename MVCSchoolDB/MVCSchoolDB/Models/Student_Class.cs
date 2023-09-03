using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSchoolDB.Models
{
    [Table("Student_Class")]
    public class Student_Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }
        public int CId { get; set; }
        public virtual Class_ Class_ { get; set; }
        public int SubId { get; set; }
        public virtual Subject_ Subject_ { get; set; }
    }

}