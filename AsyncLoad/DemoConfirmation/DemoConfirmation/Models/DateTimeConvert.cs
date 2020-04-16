using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoConfirmation.Models
{
    public class DateTimeConvert
    {
        public DateTime DeptSomeDateTime { get; set; }

        public string DeptSomeDateTimeString { get; set; }

        public DateTime DestSomeDateTime { get; set; }

        public string DestSomeDateTimeString { get; set; }

        public string SFODateTimeString { get; set; }

        public string DXBDateTimeString { get; set; }

        public DateTimeOffset SomeDTOffsetDemoDT { get; set; }

    }
}