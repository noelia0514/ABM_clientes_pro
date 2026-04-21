using AbmPersonas.Domain.Entities;
using AbmPersonas.Domain.Interfaces;
using AbmPersonas.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AbmPersonas.Infrastructure.Repositories;

public class PersonaRepository(AppDbContext context) : IPersonaRepository
{
    public async Task<IReadOnlyList<Persona>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Personas
            .AsNoTracking()
            .OrderBy(x => x.Apellido)
            .ThenBy(x => x.Nombre)
            .ToListAsync(cancellationToken);
    }

    public async Task<Persona?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await context.Personas.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<Persona?> GetByDocumentoAsync(string documento, CancellationToken cancellationToken = default)
    {
        var normalized = documento.Trim();
        return await context.Personas.FirstOrDefaultAsync(x => x.Documento == normalized, cancellationToken);
    }

    public async Task AddAsync(Persona persona, CancellationToken cancellationToken = default)
    {
        await context.Personas.AddAsync(persona, cancellationToken);
    }

    public void Update(Persona persona)
    {
        context.Personas.Update(persona);
    }

    public void Remove(Persona persona)
    {
        context.Personas.Remove(persona);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}
