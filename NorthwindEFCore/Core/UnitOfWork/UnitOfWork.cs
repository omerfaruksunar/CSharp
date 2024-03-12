
using Entities.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Core.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
	private readonly NorthwindContext context;
	private IDbContextTransaction transaction;

	public UnitOfWork(NorthwindContext p_context)
	{
		context = p_context;
	}

	public async Task CommitAsync()
	{
		await using (transaction = await context.Database.BeginTransactionAsync())
		{
			try
			{
				await context.SaveChangesAsync();
				await transaction.CommitAsync();
			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				throw new Exception($"{ex.Message}");
			}
		}
	}
}
