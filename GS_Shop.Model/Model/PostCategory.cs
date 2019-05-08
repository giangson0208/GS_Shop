using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("PostCategorys")]
    public class PostCategory
    {
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(200)]
        public string Image { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        public int? Parent { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}