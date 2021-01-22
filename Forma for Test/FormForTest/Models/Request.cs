using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.Models
{
    class Request
    {
        public int RequestId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Realty Realty { get; set; }
        public Marital_Status Marital_Status { get; set; }
        public int Salary { get; set; }
        public string Phone { get; set; }
    }
}
