using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebFin.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }
    }
}
