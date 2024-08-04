


namespace PersonalBlog.Strategies;

public class DynamoDbDataService : IDataService
{
    private readonly IDynamoDBContext _context;
    public DynamoDbDataService(IDynamoDBContext context)
    {
        _context = context;
    }
    public async Task Create(Post model)
    {
        await _context.SaveAsync<Post>(model);
    }

    public async Task<List<Post>> GetAll()
    {
        return await _context.ScanAsync<Post>(new List<ScanCondition>()).GetRemainingAsync();
    }
}