using System;
using System.Collections.Generic;

#nullable disable

namespace First12.DB
{
    public partial class EventLogger
    {
        public string LoggerId { get; set; }
        public DateTime? EventStartTime { get; set; }
        public string Event { get; set; }
        public TimeSpan? EventDuration { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ErrorLogTime { get; set; }
        public string Source { get; set; }
    }
}
