using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Models
{
    public class ApplicationDTO
    {
        public int ID { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public Profile Profile1 { get; set; }
        public Profile Profile2 { get; set; }
        public College College { get; set; }
    }
}
