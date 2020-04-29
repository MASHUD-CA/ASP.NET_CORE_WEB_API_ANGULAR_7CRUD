using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    //define model for payment detail entity or tab

    public class PaymentDetail
    {
        //This is for primary key
        [Key]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")] // Card holder name max 100 digits
        public string CardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(16)")] // All card has 16 digits
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(5)")] //YY/MM = 5 character
        public string ExpirationDate { get; set; } 
        [Required]
        [Column(TypeName = "nvarchar(3)")]
        public string  CVV { get; set; } // is 3

    }
}
