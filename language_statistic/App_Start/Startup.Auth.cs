using Owin;
using System;
using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using language_statistic.Models;
using System.Collections.Generic;
using Microsoft.Owin.Security.Google;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;


namespace language_statistic
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
            
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            var g = new GoogleOAuth2AuthenticationOptions() { ClientId = "140915521135-kjve8411d64g5534cle7ranmujh8crf3.apps.googleusercontent.com", ClientSecret = "ISvaMsxFt4tXjxnpKGUCM137" };
            g.Provider = new GoogleOAuth2AuthenticationProvider()
            {
                OnAuthenticated = async context =>
                {
                    //Get the access token from Google and store it in the database and
                    //use GoogleC# SDK to get more information about the user
                    context.Identity.AddClaim(new System.Security.Claims.Claim("GoogleAccessToken", context.AccessToken));
                }
            };
            app.UseGoogleAuthentication(g);
            //Facebook authentification
            List<string> scopes = new List<string>() { "email", "user_birthday", "user_hometown", "user_location" };
            var f = new FacebookAuthenticationOptions() { AppId = "597526740362529", AppSecret = "5667962f1004dd6dda26ebed74d9dc94", SignInAsAuthenticationType = DefaultAuthenticationTypes.ExternalCookie };
            foreach (string s in scopes)
            {
                f.Scope.Add(s);
            }
            f.Provider = new FacebookAuthenticationProvider()
            {
                OnAuthenticated = async context =>
                {
                    //Get the access token from FB and store it in the database and
                    //use FacebookC# SDK to get more information about the user
                    context.Identity.AddClaim(new System.Security.Claims.Claim("FacebookAccessToken", context.AccessToken));
                }
            };
            app.UseFacebookAuthentication(f);
        }
    }
}