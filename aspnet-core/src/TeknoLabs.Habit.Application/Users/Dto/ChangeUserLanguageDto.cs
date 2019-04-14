using System.ComponentModel.DataAnnotations;

namespace TeknoLabs.Habit.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}