using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName ="Nvarchar(100)")]
        public string CardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(16)")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(5)")]
        public string ExprationDate { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(3)")]
        public string CVV { get; set; }


    }
}
