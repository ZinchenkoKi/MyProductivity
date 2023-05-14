using System.ComponentModel.DataAnnotations;

namespace MyProductivity.Entity
{
    internal class Applications
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }
    }
}
