using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.DataAccess;
using WebApplication1.Models.Services.Interfaces;

namespace WebApplication1.Models.Services
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<User>> GetAll()
        {
            using var context = new UserManagementContext();

            var user = from u in context.Users
                       select u;

            return await user.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            using var context = new UserManagementContext();

            var user = from b in context.Users
                       where b.Id == id
                       select b;

            return await user.SingleOrDefaultAsync();
        }

        public async Task CreateAsync(User user)
        {
            using var context = new UserManagementContext();

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            using var context = new UserManagementContext();

            context.Users.Update(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var context = new UserManagementContext();

            var userToDelete = await (from u in context.Users
                                      where u.Id == id
                                      select u).SingleAsync();

            context.Users.Remove(userToDelete);
            await context.SaveChangesAsync();
        }

        //public List<UserModel> GetAll()
        //{
        //    using var context = new UserManagementContext();

        //    var user=from u in context.Users
        //             select u;

        //    return user.ToList();
        //}


        //public UserModel GetById(int id)
        //{
        //    using var context = new UserManagementContext();

        //    //var brand = context.Brands.SingleOrDefault(b => b.BrandName == brandName);

        //    var user = from b in context.Users where b.Id == id
        //                select b;

        //    return user.SingleOrDefault();
        //}
    }
}
