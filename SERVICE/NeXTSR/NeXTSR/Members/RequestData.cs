using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeXTSR.Members
{
    public class RequestData
    {
        public long ID { get; set; }
        public string RequestType { get; set; }
        public string RequestUser { get; set; }
        public string RequestVolunteer { get; set; }
        public string RequestValues { get; set; }

    }
}