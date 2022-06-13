namespace HashIds.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

    public class ReturnUser
    {
        public string Id { get; set; }
        public string FullName { get; set; }
    }
}