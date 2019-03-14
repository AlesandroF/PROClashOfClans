namespace Clash.ValueObjectEntity.EntityManipulation
{
    public class VOUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }

        public VOUser(string userName, string password, int id, string role)
        {
            UserName = userName;
            Password = password;
            Id = id;
            Role = role;
        }

        public VOUser Create(string userName, string password, int id, string role)
        {
            return new VOUser(userName, password, id, role);
        }
    }
}