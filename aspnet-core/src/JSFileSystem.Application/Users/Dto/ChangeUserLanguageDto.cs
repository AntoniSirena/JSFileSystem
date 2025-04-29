using System.ComponentModel.DataAnnotations;

namespace JSFileSystem.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}