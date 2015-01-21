using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using language_statistic.Models;
using Facebook;
using System.Globalization;
using Google.Apis.Plus.v1;
using Google.Apis.Services;
using System.Web.Mvc;
using System.Web.Security;


namespace language_statistic.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(model.Email, model.Password);
                if (user != null)
                {
                    await UserManager.AddClaimAsync(user.Id, new Claim("ProfilePicUrl", user.ProfilePicUrl ?? String.Empty));
                    await SignInAsync(user, model.RememberMe);
                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };
                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await UserManager.AddClaimAsync(user.Id, new Claim("ProfilePicUrl", user.ProfilePicUrl ?? String.Empty));
                    await SignInAsync(user, isPersistent: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return RedirectToAction("RegisterCallback", "Account", user);
                }
                else
                {
                    AddErrors(result);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/RegisterCallback
        public ActionResult RegisterCallback()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            return View(user);
        }

        //
        // POST: /Account/ManageProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterCallback(ApplicationUser Item1)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("invalidModelError", "The given data was not valid! Please try again!");
                return View("RegisterCallback", Item1);
            }

            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                user.LastName = Item1.LastName;
                user.FirstName = Item1.FirstName;

                user.Hometown = Item1.Hometown;
                user.Location = Item1.Location;

                user.Gender = Item1.Gender;
                user.Birthdate = Item1.Birthdate;

                var result = await UserManager.UpdateAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");

                AddErrors(result);
                return View("RegisterCallback", Item1);
            }

            ModelState.AddModelError("userNotFoundModelError", "Something went wrong. Please try again!");
            return View("RegisterCallback", Item1);
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null) 
            {
                return View("Error");
            }

            IdentityResult result = await UserManager.ConfirmEmailAsync(userId, code);
            if (result.Succeeded)
            {
                return View("ConfirmEmail");
            }
            else
            {
                AddErrors(result);
                return View();
            }
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                {
                    ModelState.AddModelError("", "The user either does not exist or is not confirmed.");
                    return View();
                }

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                // await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                // return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
	
        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            if (code == null) 
            {
                return View("Error");
            }
            return View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "No user found.");
                    return View();
                }
                IdentityResult result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("ResetPasswordConfirmation", "Account");
                }
                else
                {
                    AddErrors(result);
                    return View();
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // POST: /Account/Disassociate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Disassociate(string loginProvider, string providerKey)
        {
            ManageMessageId? message = null;
            IdentityResult result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                await SignInAsync(user, isPersistent: false);
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("Manage", new { Message = message });
        }

        //
        // GET: /Account/Manage
        public ActionResult Manage(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.UpdateProfileSuccess ? "Your profile has been updated."
                : "";
            ViewBag.HasLocalPassword = HasPassword();
            ViewBag.ReturnUrl = Url.Action("Manage");

            ViewBag.HasExternalAccounts = (UserManager.GetLogins(User.Identity.GetUserId()).Count > 0 ? true : false);
            return View(Tuple.Create(UserManager.FindById(User.Identity.GetUserId()), new ManageUserViewModel()));
        }

        //
        // POST: /Account/ManageProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ManageProfile(ApplicationUser Item1, ManageUserViewModel Item2)
        {
            /*
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("invalidModelError", "The given data was not valid! Please try again!");
                return View("Manage", Tuple.Create(Item1, Item2));
            }*/

            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                user.LastName = Item1.LastName;
                user.FirstName = Item1.FirstName;

                user.Hometown = Item1.Hometown;
                user.Location = Item1.Location;

                user.Gender = Item1.Gender;
                user.Birthdate = Item1.Birthdate;

                user.SpokenLanguages = Item1.SpokenLanguages;
                user.LearningLanguages = Item1.LearningLanguages;
                
                var result = await UserManager.UpdateAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Manage", new { Message = ManageMessageId.UpdateProfileSuccess });

                AddErrors(result);
                return View("Manage", Tuple.Create(Tuple.Create(Item1, Item2), new ManageUserViewModel()));
            }

            ModelState.AddModelError("userNotFoundModelError", "Something went wrong. Please try again!");
            return View("Manage", Tuple.Create(Tuple.Create(Item1, Item2), new ManageUserViewModel()));
        }

        //
        // POST: /Account/ManageLocalPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ManageLocalPassword(ManageUserViewModel model)
        {
            bool hasPassword = HasPassword();
            ViewBag.HasLocalPassword = hasPassword;
            ViewBag.ReturnUrl = Url.Action("Manage");
            if (hasPassword)
            {
                if (ModelState.IsValid)
                {
                    IdentityResult result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                        await SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
                    }
                    else
                    {
                        AddErrors(result);
                    }
                }
            }
            else
            {
                // User does not have a password so remove any validation errors caused by a missing OldPassword field
                ModelState state = ModelState["OldPassword"];
                if (state != null)
                {
                    state.Errors.Clear();
                }

                if (ModelState.IsValid)
                {
                    IdentityResult result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
                    }
                    else
                    {
                        AddErrors(result);
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return View("Manage", Tuple.Create(UserManager.FindById(User.Identity.GetUserId()), model));
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            // Get the information about the user from the external login provider
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return View("ExternalLoginFailure");
            }
            // Sign in the user with this external login provider if the user already has a login
            var user = await UserManager.FindAsync(loginInfo.Login);
            if (user != null)
            {
                if (loginInfo.Login.LoginProvider == "Facebook")
                    await StoreFacebookAuthToken(user); //Save the FacebookToken in the database if not already there
                else if (loginInfo.Login.LoginProvider == "Google")
                    await StoreGoogleAuthToken(user); //Save the GoogleToken in the database if not already there
                await UserManager.AddClaimAsync(user.Id, new Claim("ProfilePicUrl", user.ProfilePicUrl ?? String.Empty));
                await SignInAsync(user, isPersistent: false);
                return RedirectToLocal(returnUrl);
            }
            else
            {
                //If the user does not have an account, make one for him
                user = new ApplicationUser() { UserName = loginInfo.Email, Email = loginInfo.Email };
                IdentityResult result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, loginInfo.Login);
                    if (result.Succeeded)
                    {
                        if (loginInfo.Login.LoginProvider == "Facebook")
                        {
                            await StoreFacebookAuthToken(user);
                            var access_token = user.Claims.FirstOrDefault(x => x.ClaimType == "FacebookAccessToken").ClaimValue;
                            var client = new FacebookClient(access_token);

                            dynamic userFB = client.Get("/me", new { fields = "email, birthday, gender, hometown, location, first_name, last_name" });
                            dynamic userFB_pic = client.Get("/me/picture", new { type = "large", redirect = "false" });

                            user.LastName = userFB.last_name;
                            user.FirstName = userFB.first_name;

                            user.Hometown = userFB.hometown.name;
                            user.Location = userFB.location.name;

                            user.Gender = (userFB.gender == "male" ? "m" : "f");
                            user.Birthdate = DateTime.ParseExact(userFB.birthday, @"MM/dd/yyyy", CultureInfo.InvariantCulture);
                            user.ProfilePicUrl = (!userFB_pic.data.is_silhouette ? userFB_pic.data.url : String.Empty);
                        } else if (loginInfo.Login.LoginProvider == "Google")
                        {
                            await StoreGoogleAuthToken(user);
                            var access_token = user.Claims.FirstOrDefault(x => x.ClaimType == "GoogleAccessToken").ClaimValue;
                            /*LOST!!!*/
                            
                            var client = new PlusService(new BaseClientService.Initializer { HttpClientInitializer = null, ApplicationName = "languageStatistic" });
                            dynamic userG = client.People.Get(loginInfo.Login.ProviderKey).Execute();
                        }
                        await UserManager.AddClaimAsync(user.Id, new Claim("ProfilePicUrl", user.ProfilePicUrl ?? String.Empty));
                        await UserManager.UpdateAsync(user);
                        await SignInAsync(user, isPersistent: false);

                        // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                        // Send an email with this link
                        // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                        // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                        // SendEmail(user.Email, callbackUrl, "Confirm your account", "Please confirm your account by clicking this link");

                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);

                ViewBag.ReturnUrl = returnUrl;
                return View("ExternalLoginFailure");
            }
        }

        //
        // POST: /Account/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new ChallengeResult(provider, Url.Action("LinkLoginCallback", "Account"), User.Identity.GetUserId());
        }

        //
        // GET: /Account/LinkLoginCallback
        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("Manage", new { Message = ManageMessageId.Error });
            }
            IdentityResult result = await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login);
            if (result.Succeeded)
            {
                ApplicationUser user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (loginInfo.Login.LoginProvider == "Facebook")
                {
                    await StoreFacebookAuthToken(user);
                    var access_token = user.Claims.FirstOrDefault(x => x.ClaimType == "FacebookAccessToken").ClaimValue;
                    var client = new FacebookClient(access_token);

                    dynamic userFB = client.Get("/me", new { fields = "email, birthday, gender, hometown, location, first_name, last_name" });
                    dynamic userFB_pic = client.Get("/me/picture", new { type = "large", redirect = "false" });

                    user.LastName = (user.LastName == null || user.LastName.Length == 0) ? userFB.last_name : user.LastName;
                    user.FirstName = (user.FirstName == null || user.LastName.Length == 0) ? userFB.first_name : user.FirstName;

                    user.Hometown = (user.Hometown == null || user.Hometown.Length == 0) ? userFB.hometown.name : user.Hometown;
                    user.Location = (user.Location == null || user.Location.Length == 0) ? userFB.location.name : user.Location;

                    user.Gender = (user.Gender == null || user.Gender.Length == 0) ? (userFB.gender == "male" ? "m" : "f") : user.Gender;
                    user.Birthdate = user.Birthdate == null ? DateTime.ParseExact(userFB.birthday, @"MM/dd/yyyy", CultureInfo.InvariantCulture) : user.Birthdate;
                    user.ProfilePicUrl = (user.ProfilePicUrl == null || user.ProfilePicUrl.Length == 0) ? (!userFB_pic.data.is_silhouette ? userFB_pic.data.url : String.Empty) : user.ProfilePicUrl;
                }
                else if (loginInfo.Login.LoginProvider == "Google")
                {
                    await StoreGoogleAuthToken(user);
                    var access_token = user.Claims.FirstOrDefault(x => x.ClaimType == "GoogleAccessToken").ClaimValue;
                    /*LOST!!!*/

                    var client = new PlusService(new BaseClientService.Initializer { HttpClientInitializer = null, ApplicationName = "languageStatistic" });
                    dynamic userG = client.People.Get(loginInfo.Login.ProviderKey).Execute();
                }

                await UserManager.AddClaimAsync(user.Id, new Claim("ProfilePicUrl", user.ProfilePicUrl ?? String.Empty));
                await UserManager.UpdateAsync(user);
                return RedirectToAction("Manage");
            }
            return RedirectToAction("Manage", new { Message = ManageMessageId.Error });
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult RemoveAccountList()
        {
            var linkedAccounts = UserManager.GetLogins(User.Identity.GetUserId());
            ViewBag.ShowRemoveButton = HasPassword() || linkedAccounts.Count > 1;
            return (ActionResult)PartialView("_RemoveAccountPartial", linkedAccounts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && UserManager != null)
            {
                UserManager.Dispose();
                UserManager = null;
            }
            base.Dispose(disposing);
        }

        #region Helpers
        private async Task StoreFacebookAuthToken(ApplicationUser user)
        {
            var claimsIdentity = await AuthenticationManager.GetExternalIdentityAsync(DefaultAuthenticationTypes.ExternalCookie);
            if (claimsIdentity != null)
            {
                // Retrieve the existing claims for the user and add the FacebookAccessTokenClaim
                var currentClaims = await UserManager.GetClaimsAsync(user.Id);
                var facebookAccessToken = claimsIdentity.FindAll("FacebookAccessToken").First();
                if (currentClaims.FirstOrDefault(c => c.Type == "FaceBookAccessToken") == null)
                {
                    await UserManager.AddClaimAsync(user.Id, facebookAccessToken);
                }
            }
        }
        private async Task StoreGoogleAuthToken(ApplicationUser user)
        {
            var claimsIdentity = await AuthenticationManager.GetExternalIdentityAsync(DefaultAuthenticationTypes.ExternalCookie);
            if (claimsIdentity != null)
            {
                // Retrieve the existing claims for the user and ass the GoogleAccessTokenClaim
                var currentClaims = await UserManager.GetClaimsAsync(user.Id);
                var googleAccessToken = claimsIdentity.FindAll("GoogleAccessToken").First();
                if (currentClaims.Count() <= 0)
                {
                    await UserManager.AddClaimAsync(user.Id, googleAccessToken);
                }
            }
        }

        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, await user.GenerateUserIdentityAsync(UserManager));
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private void SendEmail(string email, string callbackUrl, string subject, string message)
        {
            // For information on sending mail, please visit http://go.microsoft.com/fwlink/?LinkID=320771
        }

        public enum ManageMessageId
        {
            UpdateProfileSuccess,
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            Error
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri) : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties() { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}