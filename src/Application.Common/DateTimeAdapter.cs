using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common
{
    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime LocalNow => DateTime.Now;
    }
}
