public class Post 
{
    public I(Parameters)
    {
       Id = Guid.NewGuid().ToString(); 
    }
    
    public string Id { get; set; }
    public DateTime PostDateTime { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}