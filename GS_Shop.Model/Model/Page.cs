﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("Pages")]
    public class Page
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
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}