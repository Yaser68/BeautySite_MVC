using System.ComponentModel.DataAnnotations;

namespace BeautySite_MVC.Models
{
    public class contact
    {
        
       
        [Required(ErrorMessage ="این فیلد الزامی است")]
        [MinLength(5,ErrorMessage ="حداقل 5 کاراکتر باشد")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "این فیلد الزامی است")]
        public string number { get; set; }
    }
}
