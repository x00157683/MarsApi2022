using System;
using System.ComponentModel.DataAnnotations;

namespace EAD_Ca3.Data
{

    public enum RoverNames
    {
        Perseverance,
        Opportunity,
        Curiosity,
        Spirit
    };


    public class MarsQuery
    {
        
        [Range(0, Int32.MaxValue, ErrorMessage = "Value should be a number")]
        [Required(ErrorMessage = "Sol must not be blank!")]
        public string ?solDay { get; set; }

        public bool ?isEmpty { get; set; } = true;
        public RoverNames RoverName { get; set; }
        public string? earth_date { get; set; }


    }
}
