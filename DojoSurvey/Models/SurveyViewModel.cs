using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class SurveyViewModel
    {
        [Required(ErrorMessage="Please Enter Name")]
        [MinLength (2), MaxLength(15)]
        public string name { get; set; }
        [Required(ErrorMessage="Please Enter Location")]
        public string location { get; set; }
        [Required(ErrorMessage="Please Enter Language")]
        public string language { get; set; }
        
        public string comment { get; set; }

    }
}