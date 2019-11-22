using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTap01_CRUD_MVC.Models
{
    public class Product
    {
        public int? Id { get; set; }
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [MinLength(7, ErrorMessage = "Name cannot be shorter than 7 characters.")]
        public string Name { get; set; }
        [Range(10000, 1000000, ErrorMessage = "Price cannot be higher than 1,000,000 or lower than 10,000")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Description is needed")]
        public string Description { get; set; }
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string ManufactureEmail { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [Range(1, 3, ErrorMessage = "Status cannot be higher than 3 or lower than 1")]
        public int Status { get; set; }

        public Product()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}