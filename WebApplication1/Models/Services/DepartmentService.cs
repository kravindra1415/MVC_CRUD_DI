using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.DataAccess;

namespace WebApplication1.Models.Services
{
    public class DepartmentService
    {
        public async Task<IEnumerable<Department>> GetAll()
        {
            using var context = new UserManagementContext();

            var department = from d in context.Department
                       select d;

            return await department.ToListAsync();
        }

        public async Task<Department> GetById(int id)
        {
            using var context = new UserManagementContext();

            var department = from d in context.Department
                             where d.Id == id
                             select d;

            return await department.SingleOrDefaultAsync();
        }

        public async Task CreateAsync(Department department)
        {
            using var context = new UserManagementContext();

            await context.Department.AddAsync(department);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Department department)
        {
            using var context = new UserManagementContext();

            context.Department.Update(department);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var context = new UserManagementContext();

            var userToDepartment = await (from d in context.Department
                                          where d.Id == id
                                          select d).SingleAsync();

            context.Department.Remove(userToDepartment);
            await context.SaveChangesAsync();
        }
    }

}
