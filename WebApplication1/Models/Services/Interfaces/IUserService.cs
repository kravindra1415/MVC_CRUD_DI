namespace WebApplication1.Models.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateAsync(User user);
        Task DeleteAsync(int id);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task UpdateAsync(User user);
    }
}