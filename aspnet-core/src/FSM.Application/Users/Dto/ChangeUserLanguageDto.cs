using System.ComponentModel.DataAnnotations;

namespace FSM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}