using LinqToDB.Mapping;
using System;

namespace WindowsFormsApp.Models
{
    [Table(Name = "Logbook")]
    public class Logbook
    {
        [PrimaryKey]
        public int LogbookId { get; set; }

        [Column(Name = "DateTime")]
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        [Column(Name = "RecomendateResult")]
        public bool RecomendateResult { get; set; } = false;

        [Column(Name = "Result")]
        public bool Result { get; set; } = false;

        [Column(Name = "UserId")]
        public int UserId { get; set; }

        [NotColumn]
        [Association(ThisKey = nameof(UserId), OtherKey = nameof(Models.User.UserId))]
        public User User { get; set; }

        [Column(Name = "RequestId")]
        public int RequestId { get; set; }

        [NotColumn]
        [Association(ThisKey = nameof(RequestId), OtherKey = nameof(Models.Request.RequestId))]
        public Request Request { get; set; }
    }
}
