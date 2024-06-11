namespace Repository.Entity
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// Insert 1 entity vào database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddAsync(T entity);
        /// <summary>
        /// Insert nhiều entity(bản ghi) vào database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddRangeAsync(IEnumerable<T> entity);
        /// <summary>
        /// Update 1 entity (bản ghi)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(T entity);
        /// <summary>
        /// Update nhiều entity (bản ghi) vào database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateRangeAsync(IEnumerable<T> enumerableEntity);
        /// <summary>
        /// Xóa 1 entity (bản ghi) khỏi database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> RemoveAsync(T entity);
        /// <summary>
        /// Xóa nhiều entity (bản ghi) khỏi database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> RemoveRangeAsync(IEnumerable<T> entity);
    }
}