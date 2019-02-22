using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class PaymentCard
    {

    
        [Display(Name = "16 Digit Credit Card Number")]
        [Required(ErrorMessage = "16 Digits")]
        public int CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Name is reuired")]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Required]
        public int ExpiryMonth { get; set; }
        [Required]
        public int ExpiryYear { get; set; }
        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string PostCode { get; set; }


    }
}