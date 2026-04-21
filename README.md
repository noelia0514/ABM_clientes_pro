# ABM Personas - Proyecto Final

Aplicacion de escritorio WinForms para gestionar Personas (alta, baja, modificacion y consulta) con persistencia real en SQL Server.

## Stack tecnico

- C# / .NET 9
- WinForms
- Entity Framework Core 9
- SQL Server
- Inyeccion de dependencias (`Microsoft.Extensions.DependencyInjection`)
- Configuracion por `appsettings.json`

## Arquitectura

La solucion mantiene una arquitectura por capas:

- `AbmPersonas.Domain`: entidad `Persona` y contratos de repositorio.
- `AbmPersonas.Application`: DTOs y `PersonaService` con reglas de negocio.
- `AbmPersonas.Infrastructure`: `AppDbContext`, EF Core, repositorios, migraciones.
- `AbmPersonas.WinForms`: interfaz final para usuario.
- `AbmPersonas.Api`: API opcional (no necesaria para la UI WinForms).

## Funcionalidades implementadas

- Listado de clientes con paginacion.
- Busqueda por texto (nombre, email, codigo, documento).
- Filtro por estado (Todos / Activo / Inactivo).
- Panel lateral de detalle del cliente seleccionado.
- Alta, edicion, visualizacion y eliminacion.
- Exportacion de clientes filtrados a CSV.
- Persistencia en SQL Server.

## Configuracion de base de datos

Editar la cadena de conexion en:

- `src/AbmPersonas.WinForms/appsettings.json`

Ejemplo:

```json
{
  "ConnectionStrings": {
    "SqlServer": "Server=localhost;Database=AbmPersonasDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

## Ejecutar el proyecto

1. Restaurar y compilar:
   - `dotnet build AbmPersonas.sln`
2. Aplicar migraciones:
   - `dotnet ef database update --project src/AbmPersonas.Infrastructure --startup-project src/AbmPersonas.WinForms`
3. Ejecutar WinForms:
   - `dotnet run --project src/AbmPersonas.WinForms`

## Checklist para demo final

1. Crear un cliente nuevo.
2. Editar el cliente.
3. Filtrar por estado.
4. Buscar por nombre o documento.
5. Eliminar un cliente.
6. Exportar CSV con los datos filtrados.
