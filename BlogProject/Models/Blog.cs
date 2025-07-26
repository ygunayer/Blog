using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Slug { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Title { get; set; } = string.Empty;

        // Foreign Key
        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; } = null!;

        // Navigation Property
        public virtual ICollection<BlogEntry> BlogEntries { get; set; } = new List<BlogEntry>();
    }
}