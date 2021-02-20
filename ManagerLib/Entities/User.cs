namespace ManagerLib.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public bool IsAdmin { get; set; }
    }
}