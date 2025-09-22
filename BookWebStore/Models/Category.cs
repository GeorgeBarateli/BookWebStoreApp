using System.ComponentModel.DataAnnotations;

namespace BookWebStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        public string DisplayOrder { get; set; }
    }
}
