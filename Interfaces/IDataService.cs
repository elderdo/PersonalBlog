
namespace PersonalBlog.Interfaces;

public interface IDataService
{
    Task Create(Post model);
    Task<List<Post>> GetAll();
}