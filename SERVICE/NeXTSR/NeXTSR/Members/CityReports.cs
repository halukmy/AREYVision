using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeXTSR.Members
{
    public class CityReports
    {
        public long Id { get; set; }
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public float latid { get; set; }
        public float longt { get; set; }
        public DateTime createTime { get; set; }
        public DateTime ProcessTime { get; set; }
        public string Data { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
    }
    public class CityEvents
    {
        public long Id { get; set; }
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public float Longt { get; set; }
        public float Latid { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ActiveTime { get; set; }
        public string EtknilkTuru { get; set; }
        public string EtknilkIcerigi { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }

        public bool Status { get; set; }
    }

}