using System.IO;
using NeXTSR.Api;
using NeXTSR.Members;
using ServiceStack;
using NeXTSR.Services;

namespace NeXTSR.Services
{
    [Route("/upload", "POST")]
        public class UploadFileRequest
        {
            // Example of other properties you can send with the request
            public string[] Tags { get; set; }

        }

    [Route("/RequestUserADD", "POST")]
    public class RequestUserADD
    {
        public string username { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public string ContactPhone { get; set; }
        public int Age { get; set; }
        public string Abilities { get; set; }
        public string PersonelData { get; set; }
        public string Learning { get; set; }
        public long RequestID { get; set; }


    }

    public class RequestUserADDResponse
    {
        public long Id { get; set; }
    }


    [Route("/RequstVolunteerADD", "POST")]
    public class RequstVolunteerADD
    {
        public string username { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public string ContactPhone { get; set; }
        public string RequestID { get; set; }

    }

    public class RequstVolunteerResponse
    {
        public long Id { get; set; }
    }



    [Route("/RequestADD", "POST")]
    public class RequstADD
    {
    public long ID { get; set; }
    public string RequestType { get; set; }
    public string RequestUser { get; set; }
    public string RequestVolunteer { get; set; }
    public string RequestValues { get; set; }
    }

    public class RequstADDResponse
    {
        public long Id { get; set; }
    }

    /*
    #region City Report Services

    [Route("/CityReportsGET/", "POST")]
    public class CityReportsGet
    {

    }

    public class CityReportsGetResponse
    {
        public IEnumerable<CityReports> GetReports { get; set; }
    }


    [Route("/upload/{FileName}", "POST")]
    public class UploadPackage : IRequiresRequestStream
    {
        public System.IO.Stream RequestStream { get; set; }

        public string FileName { get; set; }
    }

    [Route("/RequestUserADD", "POST")]
    public class RequestUserADD
    {
        public string username { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public string ContactPhone { get; set; }
        public int Age { get; set; }
        public string Abilities { get; set; }
        public string PersonelData { get; set; }
        public string Learning { get; set; }
        public long RequestID { get; set; }


    }

    public class RequestUserADDResponse
    {
        public long Id { get; set; }
    }


    public static class StreamExtender
    {
        public static void Copy(this Stream instance, Stream target)
        {
            int bytesRead = 0;
            int bufSize = copyBuf.Length;

            while ((bytesRead = instance.Read(copyBuf, 0, bufSize)) > 0)
            {
                target.Write(copyBuf, 0, bytesRead);
            }
        }
        private static readonly byte[] copyBuf = new byte[0x1000];
    }

    [Route("/CityReportsADD", "POST")]
    public class CityReportsAdd
    {
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public float latid { get; set; }
        public float longt { get; set; }
        public DateTime createTime { get; set; }
        public DateTime ProcessTime { get; set; }
        public string Data { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }

        public Uri Adress { get; set; }

    }

    public class CityReportsAddResponse
    {
        public long ID { get; set; }
    }

    [Route("/CityReportsUPDATE/{UserId}", "POST")]
    public class CityReportsUpdate
    {
        public long UserId { get; set; }
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

    public class CityReportsUpdateResponse
    {
        public string newReportHeader { get; set; }
        public string newReportBody { get; set; }
        public float newlatid { get; set; }
        public float newlongt { get; set; }
        public string newData { get; set; }
        public bool newStatus { get; set; }
        public string newimage1 { get; set; }
    }


    [Route("/CityReportsDELETE/{UserId}", "POST")]
    public class CityReportsDelete
    {
        public long RequestId { get; set; }
    }



    class CityReportsDeleteResponse
    {
        public string Bilgi { get; set; }

    }




    #endregion

    #region City Event Services
    [Route("/EventsADD", "POST")]
    public class EventsAdd
    {
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

    public class EventsAddResponse
    {
        public long ID { get; set; }
    }


    [Route("/EventsGET/", "POST")]
    public class EventsGet
    {

    }

    public class EventsGetResponse
    {
        public IEnumerable<CityEvents> GetEvents { get; set; }
    }



    [Route("/EventUpdate/{Id}", "POST")]
    public class EventUpdate
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

    public class EventUpdateResponse
    {
        public string newReportHeader { get; set; }
        public string newReportBody { get; set; }
        public float Longt { get; set; }
        public float Latid { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ActiveTime { get; set; }
        public string EtknilkTuru { get; set; }
        public string EtknilkIcerigi { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public bool Status { get; set; }


        #endregion
         */
}



public class ClientService : Service
    {

        public VisionService DBService { get; set; }


        public object Post(RequestUserADD request)
        {
            var Id = DBService.CreateRequestUser(request.username,request.Name, request.SName,request.ContactPhone, request.Age,request.Abilities,request.PersonelData,request.Learning, request.RequestID );
            return new NeXTSR.Services.RequestUserADDResponse() { Id = Id };
        }

    public object Post(RequstVolunteerADD request)
    {
        var Id = DBService.CreateVolunteerUser(request.username,request.Name , request.SName, request.ContactPhone,request.RequestID);
        return new NeXTSR.Services.RequestUserADDResponse() { Id = Id };
    }
    public object Post(RequstADD request)
    {
        var Id = DBService.CreateRequest(request.RequestType,request.RequestUser,request.RequestVolunteer,request.RequestValues);
        return new NeXTSR.Services.RequestUserADDResponse() { Id = Id };
    }




    /*

    #region REPORTS
    public object Post(CityReportsGet request)
    {
        return new CityReportsGetResponse() { GetReports = DBService.GetCityReportsn() };
    }

    public object Post(CityReportsAdd request)
    {
        var Id = DBService.CreateCityReport(request.ReportHeader, request.ReportBody, request.latid, request.longt,
           request.createTime, request.ProcessTime, request.Data, request.Active, request.Image);
        return new CityReportsAddResponse() { ID = Id };
    }
    public object Post(CityReportsUpdate request)
    {
        var FindReportsId = DBService.FindReportID(request.UserId);

        FindReportsId.ReportHeader = request.ReportHeader;
        FindReportsId.ReportBody = request.ReportBody;
        FindReportsId.latid = request.latid;
        FindReportsId.longt = request.longt;
        FindReportsId.ProcessTime = request.ProcessTime;
        FindReportsId.Active = request.Active;
        FindReportsId.Data = request.Data;
        FindReportsId.Image = request.Image;
        FindReportsId.createTime = request.createTime;

        DBService.UpdateCityReport(FindReportsId);
        return new CityReportsUpdateResponse()
        {
            newData = FindReportsId.Data,
            newReportBody = FindReportsId.ReportBody,
            newReportHeader = FindReportsId.ReportHeader,
            newStatus = FindReportsId.Active
        };
    }


    public object Post(CityReportsDelete request)
    {
        DBService.DeleteReport(request.RequestId);
        return new CityReportsDeleteResponse() { Bilgi = "Silinen Veri : " + request.RequestId };
    }



    #endregion

    #region EVENTS
    public object Post(EventsAdd request)
    {
        var Id = DBService.CreateCityEvent(request.ReportHeader, request.ReportBody, request.Longt, request.Latid,
           request.CreateTime, request.ActiveTime, request.EtknilkTuru, request.EtknilkIcerigi, request.Status, request.image1, request.image2);
        return new EventsAddResponse() { ID = Id };
    }

    public object Post(EventsGet request)
    {
        return new EventsGetResponse() { GetEvents = DBService.getcityevents() };
    }


    #endregion






    public object Post(EventUpdate request)
    {
        var FindReportsId = DBService.FindEventID(request.Id);

        FindReportsId.ReportHeader = request.ReportHeader;
        FindReportsId.ReportBody = request.ReportBody;
        FindReportsId.Latid = request.Latid;
        FindReportsId.Longt = request.Longt;
        FindReportsId.ActiveTime = request.ActiveTime;
        FindReportsId.Status = request.Status;
        FindReportsId.image1 = request.image1;
        FindReportsId.image2 = request.image2;
        FindReportsId.CreateTime = request.CreateTime;

        DBService.UpdateCityEvent(FindReportsId);

        return new EventUpdateResponse()
        {
            newReportBody = FindReportsId.ReportBody,
            newReportHeader = FindReportsId.ReportHeader,
        };
    }




    public bool Post(UploadFileRequest request)
    {
        // Check a file has been attached
        if (Request.Files == null || Request.Files.Length == 0)
            throw new HttpError(400, "Bad Request", "No file has been uploaded");

      // var path = @"c:\NextData\a.png";

        var path = @"c:\inetpub\next\UserData\";


        Request.Files[0].SaveTo(path+Request.Files[0].FileName);

        // Save the file
      //  Request.Files[0].SaveTo( Request.Files[0].FileName);

        // Maybe store the tags (or any other data in the request)
        // request.Tags


        return true;
    }


    //public object Post(UploadPackage request)
    //{
    //    // hack - get the properties from the request
    //    if (string.IsNullOrEmpty(request.FileName))
    //    {
    //        var segments = base.Request.PathInfo.Split(new[] { '/' },
    //            StringSplitOptions.RemoveEmptyEntries);
    //        request.FileName = segments[1];
    //    }

    //    string resultFile = Path.Combine(@"C:\Temp", request.FileName);

    //    if (File.Exists(resultFile))
    //    {
    //        File.Delete(resultFile);
    //    }
    //    using (FileStream file = File.Create(resultFile))
    //    {
    //        request.RequestStream.Copy(file);
    //    }

    //    return new HttpResult(System.Net.HttpStatusCode.OK);


    //}
    
    */



}
/*
namespace ServiceStackStreaming.Utility
{
    public static class StreamExtender
        {
            public static void Copy(this Stream instance, Stream target)
            {
                int bytesRead = 0;
                int bufSize = copyBuf.Length;

                while ((bytesRead = instance.Read(copyBuf, 0, bufSize)) > 0)
                {
                    target.Write(copyBuf, 0, bytesRead);
                }
            }
            private static readonly byte[] copyBuf = new byte[0x1000];
        }
} 
} */

