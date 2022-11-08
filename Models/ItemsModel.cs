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
        [Key]
        [Display(Name = "Item Number")]
        public int ItemID { get; set; }

        [Required(ErrorMessage = "Please add a Title.")]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please add a description.")]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string ItemDescription { get; set; }

        [Required(ErrorMessage = "Please add a price.")]
        [Range(0, 999999.99)]
        [Display(Name = "Price")]
        public decimal ItemPrice { get; set; }

        [Required(ErrorMessage = "Please add the date.")]
        [Display(Name = "Date")]
        public DateTime? DateCreated { get; set; }

        [Required(ErrorMessage = "Please add an image name.")]
        [StringLength(100)]
        [Display(Name = "Image Name")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Please add upload an image.")]
        [Display(Name = "Image")]
        public string ImagePath { get; set; }
    }
}
