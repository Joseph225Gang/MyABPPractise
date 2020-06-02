using System.ComponentModel.DataAnnotations;

namespace MyABPPractise.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}