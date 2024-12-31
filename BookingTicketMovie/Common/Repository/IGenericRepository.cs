using System.Linq.Expressions;

namespace BookingTicketMovie.Common.Repository
{
    public interface IGenericRepository<T, TKey> where T : class
    {
        Task<T> GetByIdAsync(TKey id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task <IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
