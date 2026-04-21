using AbmPersonas.Domain.Entities;

namespace AbmPersonas.Domain.Interfaces;

public interface IPersonaRepository
{
    Task<IReadOnlyList<Persona>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Persona?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Persona?> GetByDocumentoAsync(string documento, CancellationToken cancellationToken = default);
    Task AddAsync(Persona persona, CancellationToken cancellationToken = default);
    void Update(Persona persona);
    void Remove(Persona persona);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
