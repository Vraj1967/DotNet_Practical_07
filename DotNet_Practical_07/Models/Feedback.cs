
using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet_Practical_07.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ID is required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Branch is required")]
        public string Branch { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Review is required")]
        public string Review { get; set; }
    }
}
