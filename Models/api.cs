using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class ApiModel
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]

        public string Line { get; set; }
        [Required]

        public string plateform { get; set; }
    }
}