using System.ComponentModel.DataAnnotations;

namespace testAgain.Models
{
    public class Feedback
    {
        [Display(Name = "Введіть ім'я")]
        [Required(ErrorMessage = "U need to type ur name")]
        public string Name { get; set; }

        [Display(Name = "Введіть фамілію")]
        [Required(ErrorMessage = "U need to type ur surname")]
        public string Surname { get; set; }

        [Display(Name = "Введіть вік")]
        [Required(ErrorMessage = "U need to type ur name")]
        public int Age { get; set; }

        [Display(Name = "Введіть емаїл")]
        [Required(ErrorMessage = "U need to type ur email")]
        public string Email { get; set; }

        [Display(Name = "Введіть повідомлення")]
        [Required(ErrorMessage = "U need to type ur message")]
        [StringLength(10, ErrorMessage = "need more than 10 words")]
        public string Message { get; set; }

    }
}
