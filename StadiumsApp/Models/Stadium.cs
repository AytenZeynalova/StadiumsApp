using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumsApp.Models
{
    class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourlyPrice { get; set; }
        public int Capacity { get; set; }
    }
}
