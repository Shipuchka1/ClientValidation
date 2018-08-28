using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SearchValidation.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:36,ErrorMessage ="Поле не должно превышать 36 символов")]
        [RegularExpression(@"^[\d,A-Z,А-Я].*[\d.,-;:!]$",ErrorMessage ="Поле должно начинаться с числа или заглавной буквы и заканчиваться числом")]
        public string InvoiceNumber { get; set; }
    }
}