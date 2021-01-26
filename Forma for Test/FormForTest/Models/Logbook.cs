using System;

namespace FormForTest.Models
{
    public class Logbook
    {
        public DateTime Id { get; set; } = DateTime.UtcNow;
        public bool RecomendateResult { get; set; } = false;
        public bool Result { get; set; } = false;

        public int UserId { get; set; }
        public User User { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
