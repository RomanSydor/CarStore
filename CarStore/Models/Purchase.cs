using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty.")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "E-mail")]
        [EmailAddress]        
        public string Email { get; set; }


        public DateTime Date { get; set; }
        public int BrandId { get; set; }
        public int CarTypeId { get; set; }
        public int CarModelId { get; set; }
        public int ConfigId { get; set; }
        public int CarColorId { get; set; }
        public float Price { get; set; }

    }
}