using LinqToDB.Mapping;
using System.Collections.Generic;

namespace FormForTest.Models
{
    [Table(Name = "User")]
    public class User
    {
        [PrimaryKey]
        public int UserId { get; set; }

        [Column(Name = "Login")]
        public string Login { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Role")]
        public Role Role { get; set; } = Role.User;

        [NotColumn]
        [Association(ThisKey = nameof(UserId), OtherKey = nameof(Models.Logbook.UserId))]
        public List<Logbook> Logbooks { get; } = new List<Logbook>();

        public override string ToString()
        {
            return string.Format($"{UserId} {Login} {Password} {Name} {Role}");
        }
    }
}
