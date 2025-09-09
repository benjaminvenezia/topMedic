using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using topMedic.Domain.Models;
using topMedic.Domain.Services;

namespace topMedic.EntityFramework.Services;
public class GenericDataService<T> : IDataService<T> where T : DomainObject
{

    private readonly TopMedicDbContextFactory _contextFactory;

    public GenericDataService(TopMedicDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<T> Create(T entity)
    {
        using (TopMedicDbContext context = _contextFactory.CreateDbContext())
        {
            EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();

            return createdResult.Entity;
        }
    }

    public async Task<bool> Delete(int id)
    {
        using (TopMedicDbContext context = _contextFactory.CreateDbContext())
        {
            T? entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);

            if (entity == null)
            {
                return false;
            }

            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();

            return true;
        }
    }

    public async Task<T> Get(int id)
    {
        using (TopMedicDbContext context = _contextFactory.CreateDbContext())
        {
            T? entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
            return entity;
        }
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        using (TopMedicDbContext context = _contextFactory.CreateDbContext())
        {
            IEnumerable<T> entities = await context.Set<T>().ToListAsync();
            return entities;
        }
    }

    public async Task<T> Update(int id, T entity)
    {
        using (TopMedicDbContext context = _contextFactory.CreateDbContext())
        {
            entity.Id = id;
            context.Set<T>().Update(entity);

            await context.SaveChangesAsync();

            return entity;
        }
    }
}
