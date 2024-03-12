using Core.UnitOfWork;
using DataAccess.Interfaces;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace Business.Classes;
public class Service<T> : IService<T>
	where T : class, new()
{
	private readonly

	//AsNoTracking: takip etme.
	public IQueryable<T> GetAll() => _dbSet.AsNoTracking() ;
	public IQueryable<T> Where
		(Expression<Func<T, bool>> predicate)
		=> _dbSet.AsNoTracking().Where(predicate);
	public async Task<T> GetByIdAsync(int id)
		//Asenkron ise mutlaka await komutu yazılır.
		=> await _dbSet.FindAsync(id);
	//Asenkron: Bir işlem bitmeden diğerinin de aynı anda yapilabilmesi.
	public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
		=> await _dbSet.AnyAsync(predicate);

	private async Task CUD (T entity,EntityState state)
	{
		_context.Entry(entity).State = state;
		unitOfWork.CommitAsync();
		_context.Entry(entity).State = EntityState.Detached;
	}
	public async Task AddAsync(T entity)
		=> await CUD(entity, EntityState.Added);
	public async Task AddRangeAsync(IQueryable<T> entities)
	{
		foreach(var x in entities)
		{
			await AddAsync(x);
		}
	}
	public async Task UpdateAsync(T entity)
		=> await CUD(entity, EntityState.Modified);
	public async Task RemoveAsync(T entity)
		=> await CUD (entity, EntityState.Deleted);
	public async Task RemoveRange(IQueryable<T> entities)
		=> entities.ToList().ForEach(async x => await RemoveAsync(x));
		//=> await entities.ForEachAsync(async x => await Remove(x));

}
