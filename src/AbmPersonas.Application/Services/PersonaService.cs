using AbmPersonas.Application.DTOs;
using AbmPersonas.Application.Interfaces;
using AbmPersonas.Domain.Entities;
using AbmPersonas.Domain.Interfaces;

namespace AbmPersonas.Application.Services;

public class PersonaService(IPersonaRepository personaRepository) : IPersonaService
{
    public async Task<IReadOnlyList<PersonaDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var personas = await personaRepository.GetAllAsync(cancellationToken);
        return personas.Select(MapToDto).ToList();
    }

    public async Task<PersonaDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var persona = await personaRepository.GetByIdAsync(id, cancellationToken);
        return persona is null ? null : MapToDto(persona);
    }

    public async Task<PersonaDto> CreateAsync(CrearPersonaDto request, CancellationToken cancellationToken = default)
    {
        ValidateRequest(request.Nombre, request.Apellido, request.Documento, request.FechaNacimiento);

        var existing = await personaRepository.GetByDocumentoAsync(request.Documento, cancellationToken);
        if (existing is not null)
        {
            throw new InvalidOperationException("Ya existe una persona con ese documento.");
        }

        var persona = new Persona(
            request.Nombre,
            request.Apellido,
            request.Documento,
            request.FechaNacimiento,
            request.Email,
            request.Telefono);

        await personaRepository.AddAsync(persona, cancellationToken);
        await personaRepository.SaveChangesAsync(cancellationToken);

        return MapToDto(persona);
    }

    public async Task<PersonaDto?> UpdateAsync(int id, ActualizarPersonaDto request, CancellationToken cancellationToken = default)
    {
        ValidateRequest(request.Nombre, request.Apellido, request.Documento, request.FechaNacimiento);

        var persona = await personaRepository.GetByIdAsync(id, cancellationToken);
        if (persona is null)
        {
            return null;
        }

        var existing = await personaRepository.GetByDocumentoAsync(request.Documento, cancellationToken);
        if (existing is not null && existing.Id != id)
        {
            throw new InvalidOperationException("Ya existe otra persona con ese documento.");
        }

        persona.Actualizar(
            request.Nombre,
            request.Apellido,
            request.Documento,
            request.FechaNacimiento,
            request.Email,
            request.Telefono,
            request.Activo);

        personaRepository.Update(persona);
        await personaRepository.SaveChangesAsync(cancellationToken);

        return MapToDto(persona);
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var persona = await personaRepository.GetByIdAsync(id, cancellationToken);
        if (persona is null)
        {
            return false;
        }

        personaRepository.Remove(persona);
        await personaRepository.SaveChangesAsync(cancellationToken);
        return true;
    }

    private static void ValidateRequest(string nombre, string apellido, string documento, DateOnly fechaNacimiento)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            throw new ArgumentException("El apellido es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(documento))
        {
            throw new ArgumentException("El documento es obligatorio.");
        }

        if (fechaNacimiento > DateOnly.FromDateTime(DateTime.UtcNow))
        {
            throw new ArgumentException("La fecha de nacimiento no puede ser futura.");
        }
    }

    private static PersonaDto MapToDto(Persona persona) =>
        new()
        {
            Id = persona.Id,
            Nombre = persona.Nombre,
            Apellido = persona.Apellido,
            Documento = persona.Documento,
            FechaNacimiento = persona.FechaNacimiento,
            Email = persona.Email,
            Telefono = persona.Telefono,
            Activo = persona.Activo,
            FechaAlta = persona.FechaAlta
        };
}
