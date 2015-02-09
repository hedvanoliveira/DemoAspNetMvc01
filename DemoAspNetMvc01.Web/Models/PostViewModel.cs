using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAspNetMvc01.Web.Models
{
    public class PostViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [AllowHtml]
        [Required]
        public string Description { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
    }
}