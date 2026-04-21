namespace AbmPersonas.Domain.Entities;

public class Persona
{
    public int Id { get; private set; }
    public string Nombre { get; private set; } = string.Empty;
    public string Apellido { get; private set; } = string.Empty;
    public string Documento { get; private set; } = string.Empty;
    public DateOnly FechaNacimiento { get; private set; }
    public string? Email { get; private set; }
    public string? Telefono { get; private set; }
    public bool Activo { get; private set; }
    public DateTime FechaAlta { get; private set; }

    private Persona()
    {
    }

    public Persona(
        string nombre,
        string apellido,
        string documento,
        DateOnly fechaNacimiento,
        string? email,
        string? telefono)
    {
        Nombre = nombre.Trim();
        Apellido = apellido.Trim();
        Documento = documento.Trim();
        FechaNacimiento = fechaNacimiento;
        Email = email?.Trim();
        Telefono = telefono?.Trim();
        Activo = true;
        FechaAlta = DateTime.UtcNow;
    }

    public void Actualizar(
        string nombre,
        string apellido,
        string documento,
        DateOnly fechaNacimiento,
        string? email,
        string? telefono,
        bool activo)
    {
        Nombre = nombre.Trim();
        Apellido = apellido.Trim();
        Documento = documento.Trim();
        FechaNacimiento = fechaNacimiento;
        Email = email?.Trim();
        Telefono = telefono?.Trim();
        Activo = activo;
    }
}
