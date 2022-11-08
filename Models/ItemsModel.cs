using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class ItemsModel
    {
        [Display(Name = "Item Number")]
        public int ItemId { get; set; }


        // [Required]
        // [StringLength(100)]
        public string Title { get; set; }


        // [Required]
        // [StringLength(100)]
        [Display(Name = "Description")]
        public string ItemDescription { get; set; }


        // [Required]
        // [Range(0, 9999.99]
        [Display(Name = "Price")]
        public decimal ItemPrice { get; set; }


        [Display(Name = "Date")]
        public DateTime? DateCreated { get; set; }



        [Required(ErrorMessage = "Please Upload a Valid Image File. Only jpg format allowed")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Product Image")]
        [FileExtensions(Extensions = "jpg")]
        public IFormFile Image { get; set; }


        // [Required]
        // [StringLength(100)]
        [Display(Name = "Image Name")]
        public string ImageName { get; set; }
    }
}
