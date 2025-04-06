
namespace Demo.DataAccess.Repositories
{
    public interface IDepartmentRepository
    {
        int Add(Department dept);
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        int Remove(Department dept);
        int Update(Department dept);
    }
}