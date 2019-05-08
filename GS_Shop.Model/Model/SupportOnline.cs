using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string Name { set; get; }

        [MaxLength(100)]
        public string Department { set; get; }

        [MaxLength(100)]
        public string Skype { set; get; }

        [MaxLength(100)]
        public string Moblie { set; get; }

        [MaxLength(100)]
        public string Email { set; get; }

        [MaxLength(100)]
        public string Facebook { set; get; }

        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}