using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Models
{
    public class Order
    {
        
        [BindNever]
        public int id { get; set; }
        [Display(Name ="Ім'я")]
        [StringLength(12)]
        [Required(ErrorMessage ="Довжина імені не меньше 2 символів")]
        public string name { get; set; }
        [Display(Name = "Прізвище")]
        [StringLength(17)]
        [Required(ErrorMessage = "Довжина імені не меньше 5 символів")]
        public string surname { get; set; }
        [Display(Name = "Адреса")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина імені не меньше 5 символів")]
        public string address { get; set; }
        [Display(Name = "Номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжина номера не меньше 10 символів")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина email не меньше 10 символів")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime ortderTime { get; set; }
        public List <OrderDetail> orderDetails { get; set;}


    }
}
