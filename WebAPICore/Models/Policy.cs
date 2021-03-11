using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPICore.Models
{
    public partial class Policy
    {
        public long Id { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyName { get; set; }
        public DateTime PolicyEffectiveDate { get; set; }
        public DateTime PolicyExpiryDate { get; set; }
        public bool Active { get; set; }
    }
}
