using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeXTSR.Members
{
    public class RequestData
    {
        public long ID { get; set; }
        public string RequestTitle { get; set; }
        public string RequestBody { get; set; }
        public string RequestType { get; set; }
        public string RequestUser { get; set; }
        public string RequestVolunteer { get; set; }
        //public string RequestValues { get; set; }
        public string RequestState { get; set; }// Gönderildi , Onaylandı, Rezervedlidi, Alındı
        public string RequestLocation { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime VerifyTime { get; set; }
        public DateTime ProcessTime { get; set; }
        //Erişim Bilgisi
        public long Latid { get; set; }
        public long Longt { get; set; }
        public string AccessID { get; set; }
        public string AccessPass { get; set; }
        public string AccessCode { get; set; }

        ///     VEYA
        ///     ID & PASS GİRİLDİKTEN SONRA VERİLEN 4 HANELİ ŞİFREYE GÖRE
        ///     Bir Gate Açılarak AV Tamamlanacak

    }
}