using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
}
