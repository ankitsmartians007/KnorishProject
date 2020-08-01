using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string HourlyRate { get; set; }
        public string CustomerName { get; set; }
    }
}
