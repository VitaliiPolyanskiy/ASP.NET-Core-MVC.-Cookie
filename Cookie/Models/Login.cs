using System.ComponentModel.DataAnnotations;

namespace Cookie.Models;

public class Login
{
    [Required(ErrorMessage = "Поле є обов'язковим")]
    [Display(Name = "Ім'я користувача:")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Поле є обов'язковим")]
    [Display(Name = "Пароль:")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}