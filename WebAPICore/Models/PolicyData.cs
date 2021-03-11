using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPICore.Models
{
   
    public class PolicyData
    {
        [Required]
        //[JsonPropertyName("id")]
        public long Id { get; set; }

        [Required]
        //[JsonPropertyName("policyNumber")]
        public string PolicyNumber { get; set; }

        [Required]
        //[JsonPropertyName("policyName")]
        public string PolicyName { get; set; }

        [Required]
        //[JsonPropertyName("active")]
        public bool Active { get; set; }
    }
}
