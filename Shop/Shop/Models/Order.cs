using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Imię wymagane")]
        [DisplayName("Imię")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko wymagane")]
        [DisplayName("Nazwisko")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres wymagany")]
        [StringLength(70)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Miasto wymagane")]
        [StringLength(40)]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Kod pocztowy wymagany")]
        [DisplayName("Kod pocztowy")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Kraj wymagany")]
        [StringLength(40)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Telefon wymagany")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Telefon wymagany")]
        [DisplayName("Email Address")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Adres email niepoprawny")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}