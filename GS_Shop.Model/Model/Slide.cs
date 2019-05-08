using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [Required]
        [MaxLength(200)]
        public string Image { set; get; }

        [Required]
        [MaxLength(200)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }
    }
}