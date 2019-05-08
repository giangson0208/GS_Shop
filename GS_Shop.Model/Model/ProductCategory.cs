using GS_Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("ProductCategorys")]
    public class ProductCategory : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }   //Seo title

        [MaxLength(500)]
        public string Description { set; get; }

        public int? Parent { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(200)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}