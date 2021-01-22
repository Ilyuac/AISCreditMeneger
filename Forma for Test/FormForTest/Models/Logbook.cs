﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FormForTest.Models
{
    class Logbook
    {
        public DateTime Id { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }
        public User User { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
