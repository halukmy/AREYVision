using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NeXTSR;
using NeXTSR.Api;
using NeXTSR.Services;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Caching;
using ServiceStack.Configuration;
using ServiceStack.Redis;

namespace NeXTSR
{
   // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
   // visit http://go.microsoft.com/?LinkId=9394801

   public class MvcApplication : System.Web.HttpApplication
   {
      protected void Application_Start()
      {
         AreaRegistration.RegisterAllAreas();

         //   WebApiConfig.Register(GlobalConfiguration.Configuration);
         FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
         RouteConfig.RegisterRoutes(RouteTable.Routes);
         BundleConfig.RegisterBundles(BundleTable.Bundles);

         new IDBServisleriAppHost().Init();
      }
   }
   public class IDBServisleriAppHost : AppHostBase
   {
      public IDBServisleriAppHost() : base("Wellcome 2 NeXTSR - Future is Here ", typeof(ClientService).Assembly) { }
      public override void Configure(Funq.Container container)
      {


         SetConfig(new HostConfig { HandlerFactoryPath = "api" });
         container.Register<IRedisClientsManager>(c => new PooledRedisClientManager());
         //    container.Register<RestApiMVC.Api.IRepository>(c => new Repository(c.Resolve<IRedisClientsManager>()));

         container.Register<VisionService>(c => new DBService(c.Resolve<IRedisClientsManager>()));



         Plugins.Add(new AuthFeature(() => new AuthUserSession(), new IAuthProvider[] { new BasicAuthProvider(), }));

         container.Register<ICacheClient>(new MemoryCacheClient());
         var userRepo = new InMemoryAuthRepository();

         container.Register<IUserAuthRepository>(userRepo);



         string hash, salt;

         new SaltedHash().GetHashAndSaltString("password", out hash, out salt);

         userRepo.CreateUserAuth(new UserAuth
         {
            Id = 1,
            DisplayName = "Haluk",
            Email = "hal",
            UserName = "haluk",
            FirstName = "haluk",
            LastName = "yılmaz",
            PasswordHash = hash,
            Salt = salt
         }, "password");











      }
   }



}