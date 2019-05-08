using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_Shop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(15)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(200)]
        public string CustomerMessage { set; get; }

        [MaxLength(100)]
        public string PaymentMethod { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}