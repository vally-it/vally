
namespace ProjectVally.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        
    }
}
