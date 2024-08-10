using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
