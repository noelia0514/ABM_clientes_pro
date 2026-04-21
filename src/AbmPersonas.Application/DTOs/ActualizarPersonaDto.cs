using System.ComponentModel.DataAnnotations;

namespace AbmPersonas.Application.DTOs;

public class ActualizarPersonaDto
{
    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Apellido { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string Documento { get; set; } = string.Empty;

    [Required]
    public DateOnly FechaNacimiento { get; set; }

    [EmailAddress]
    [MaxLength(150)]
    public string? Email { get; set; }

    [MaxLength(30)]
    public string? Telefono { get; set; }

    public bool Activo { get; set; } = true;
}
