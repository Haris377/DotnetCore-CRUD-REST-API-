using System.ComponentModel.DataAnnotations;

namespace webapidotnetcore.Dto
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
    }
}