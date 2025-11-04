using System.ComponentModel.DataAnnotations;

namespace FluentValidationDemonstration.Client;

public record MyViewModel
{
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage ="Data annotations says notes are required")]
    public string Notes { get; set; } = string.Empty;
}

