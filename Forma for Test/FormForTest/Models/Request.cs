using System.Collections.Generic;

namespace FormForTest.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Realty Realty { get; set; }
        public Marital_Status Marital_Status { get; set; }
        public int Salary { get; set; }
        public string Phone { get; set; }

        public List<Logbook> Logbooks { get; } = new List<Logbook>();
    }
}
