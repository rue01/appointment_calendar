using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Models
{
    public class Available
    {
        public int Id { get; set; }
        public string event_description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}