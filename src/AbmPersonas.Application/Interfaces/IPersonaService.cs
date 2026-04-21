using AbmPersonas.Application.DTOs;

namespace AbmPersonas.Application.Interfaces;

public interface IPersonaService
{
    Task<IReadOnlyList<PersonaDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<PersonaDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<PersonaDto> CreateAsync(CrearPersonaDto request, CancellationToken cancellationToken = default);
    Task<PersonaDto?> UpdateAsync(int id, ActualizarPersonaDto request, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}
