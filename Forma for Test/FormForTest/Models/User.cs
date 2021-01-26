using System.Collections.Generic;

namespace FormForTest.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; } = Role.User;

        public List<Logbook> Logbooks { get; } = new List<Logbook>();
    }
}
