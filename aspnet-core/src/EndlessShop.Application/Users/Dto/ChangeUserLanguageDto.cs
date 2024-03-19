using System.ComponentModel.DataAnnotations;

namespace EndlessShop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}