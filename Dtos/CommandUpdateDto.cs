using System.ComponentModel.DataAnnotations;

namespace webapidotnetcore.Dto
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
    }
}