using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProductivity.Entity
{
    internal class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public int Time { get; set; }
        public List<Applications> Applications { get; set; } = new();
        //[NotMapped]
        //public DateTime StartTime { get; set; }
        //[NotMapped]
        //public DateTime EndTime { get; set; }
        //[NotMapped]
        //public List<string> applications;
    }
}
