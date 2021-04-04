using LinqToDB.Mapping;
using System.Collections.Generic;

namespace WindowsFormsApp.Models
{
    [Table(Name = "Request")]
    public class Request
    {
        [PrimaryKey]
        public int RequestId { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Gender")]
        public string Gender { get; set; }

        [Column(Name = "Realty")]
        public string Realty { get; set; }

        [Column(Name = "Marital_Status")]
        public string Marital_Status { get; set; }

        [Column(Name = "Salary")]
        public int Salary { get; set; }

        [Column(Name = "Phone")]
        public string Phone { get; set; }

        [Column(Name = "Car")]
        public string Car { get; set; }

        public bool Recomendate { get; set; }

        public bool Result { get; set; }

        [NotColumn]
        [Association(ThisKey = nameof(RequestId), OtherKey = nameof(Models.Logbook.RequestId))]
        public List<Logbook> Logbooks { get; } = new List<Logbook>();
    }
}
