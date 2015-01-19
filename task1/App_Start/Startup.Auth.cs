using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace task1
{


      
    public partial class Startup
    {
        // Дополнительные сведения о настройке проверки подлинности см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Включение использования файла cookie, в котором приложение может хранить информацию для пользователя, выполнившего вход,
            app.UseCookieAuthentication(options: new CookieAuthenticationOptions
            {    
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
           // app.UseCookieAuthentication()
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
            
            // Раскомментируйте приведенные далее строки, чтобы включить вход с помощью сторонних поставщиков входа
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");
      
       /*      
           app.UseTwitterAuthentication(new TwitterAuthenticationOptions()
            {
                ConsumerKey = "Ct2QTvhkaR9J6W8eeV7zGwLRh",
                ConsumerSecret = "8nXiOJNbsXfQd7irlYBdNg7YqjxAHnqMnUkGpaIFYPLmMcKMLT",
              //  AuthenticationMode = AuthenticationMode.Active,
              //   own=
                
                    
            });  */
               
    //        app.UseTwitterAuthentication(@"zaKgBNnXRyjpL42cESs0YjWlI", @"6yHWg1mhrcJzupvP6Jimnn4ehu80KuaU0sJaxv8qy34xl7jj7n" );
            app.UseFacebookAuthentication(
              appId: "841691999216555",
               appSecret: "791a2515499c2c6ad4195e6c8b27542b");  

            app.UseGoogleAuthentication();
          /*  app.UseVkontakteAuthentication(new VkAuthenticationOptions()
            {
                AppId = "3644806",
                AppSecret = "qWvhRRM76al9LgIRGQA0",
              //  AuthenticationMode =AuthenticationMode.Active
            });   */
        }
    }
}
