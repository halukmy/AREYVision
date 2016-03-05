using NeXTSR.Members;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;

namespace NeXTSR.Api
{
    public interface VisionService
    {

        /*
        IEnumerable<CityReports> GetCityReportsn();

        long CreateCityReport(string reportHeader, string reportBody, float latid, float longt, DateTime createTime,
            DateTime activeTime, string data, bool Status, string image1);

        long CreateCityEvent(string reportHeader, string reportBody, float longt, float latid, DateTime createTime,
            DateTime activeTime, string etknilkTuru, string etknilkIcerigi, bool status, string image1, string image2);

        IEnumerable<CityEvents> getcityevents();
        void DeleteReport(long requestId);
        CityEvents FindEventID(long p);

        CityReports FindReportID(long p);
        void UpdateCityReport(CityReports findReportsId);

        void UpdateCityEvent(CityEvents findReportsId);
        */





        // long CreateVolunteer(string username, string name, string sname, string contactPhone, int age, string abilities, string personelData, string learning, long requestID);
        // long CreateRequest(string username, string name, string sname, string contactPhone, int age, string abilities, string personelData, string learning, long requestID);




        long CreateRequestUser(string username, string name, string sname, string contactPhone, int age, string abilities, string personelData, string learning, long requestID);
        long CreateVolunteerUser(string username, string name, string sName, string contactPhone, string requestID);
        long CreateRequest(string requestType, string requestUser, string requestVolunteer, string requestValues);
    }

    public class DBService : VisionService
    {

        private IRedisClientsManager RedisManager { get; set; }

        public DBService(IRedisClientsManager redisManager)
        {
            this.RedisManager = redisManager;
        }

        public long CreateRequestUser(string username, string name, string sname, string contactPhone, int age, string abilities, string personelData, string learning, long requestID)
        {

            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<RequestUserData>();

                var NewRequestUser = new RequestUserData()
                {
                    Abilities = abilities,
                    Age=age,
                    Learning= learning,
                    Name= name,
                    SName= sname,
                    PersonelData=personelData,
                    RequestID= 0,
                    ContactPhone = personelData,
                    username=username,
                    
                   
                    ID = redisUser.GetNextSequence()
                };

                redisUser.Store(NewRequestUser);
                return NewRequestUser.ID;

            }


        }

        public long CreateVolunteerUser(string username, string name, string sName, string contactPhone, string requestID)
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<RequstVolunteer>();

                var NewRequestUser = new RequstVolunteer()
                {
                    username = username,
                    ContactPhone= contactPhone,
                    Name= name,
                    RequestID= requestID,
                    SName= sName,
                    ID = redisUser.GetNextSequence()
                };

                redisUser.Store(NewRequestUser);
                return NewRequestUser.ID;
            }
        }

        public long CreateRequest(string requestType, string requestUser, string requestVolunteer, string requestValues)
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<RequestData>();

                var NewRequestUser = new RequestData()
                {
                    RequestType= requestType,
                    RequestUser= requestUser,
                    RequestValues= requestValues,
                    RequestVolunteer= requestVolunteer,
                    ID = redisUser.GetNextSequence()
                };

                redisUser.Store(NewRequestUser);
                return NewRequestUser.ID;

            }
        }




        #region REPORTS

        /*

        public IEnumerable<CityReports> GetCityReportsn()
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<CityReports>();

                return redisUser.GetAll();
            }
        }

        public long CreateCityReport(string reportHeader, string reportBody, float latid, float longt,
           DateTime createTime,
           DateTime activeTime, string data, bool Status, string image)
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<CityReports>();

                var NewReport = new CityReports()
                {
                    
                    ReportHeader = reportHeader,
                    ReportBody = reportBody,
                    latid = latid,
                    longt = longt,
                    Active = Status,
                    Data = data,
                    ProcessTime = activeTime,
                    createTime = createTime,
                    Image = image,
                    Id = redisUser.GetNextSequence()
                };

                redisUser.Store(NewReport);
                return NewReport.Id;

            }
        }


        public void DeleteReport(long requestId)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityReports>();
           

                redisUser.DeleteById(requestId);
            }

        }


        public CityReports FindReportID(long p)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityReports>();
                return redisUser.GetById(p);
            }
        }

        public void UpdateCityReport(CityReports findReportsId)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityReports>();
                redisUser.Store(findReportsId);
            }

        }

        */
        #endregion

        /*

        #region Events

        public long CreateCityEvent(string reportHeader, string reportBody, float longt, float latid,
            DateTime createTime,
            DateTime activeTime, string etknilkTuru, string etknilkIcerigi, bool status, string image1, string image2)
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<CityEvents>();

                var NewReport = new CityEvents()
                {

                    ReportHeader = reportHeader,
                    ReportBody = reportBody,
                    Latid = latid,
                    Longt = longt,
                    ActiveTime = activeTime,
                    CreateTime = createTime,
                    image1 = image1,
                    EtknilkIcerigi = etknilkIcerigi,
                    EtknilkTuru = etknilkTuru,
                    Status = status,
                    image2 = image2,
                    Id = redisUser.GetNextSequence()
                };

                redisUser.Store(NewReport);
                return NewReport.Id;

            }
        }

        public IEnumerable<CityEvents> getcityevents()
        {
            using (var redisclient = RedisManager.GetClient())
            {
                var redisUser = redisclient.As<CityEvents>();

                return redisUser.GetAll();
            }
        }


        public CityReports GetUserID(long id)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityReports>();

                return redisUser.GetById(id);

            }
        }


        public CityEvents FindEventID(long p)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityEvents>();
                return redisUser.GetById(p);
            }
        }

        public void UpdateCityEvent(CityEvents findReportsId)
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var redisUser = redisClient.As<CityEvents>();
                redisUser.Store(findReportsId);
            }
        }



        #endregion

        */






    }
}