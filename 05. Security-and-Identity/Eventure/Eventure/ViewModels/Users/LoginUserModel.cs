namespace Eventure.ViewModels.Users
{
    using Eventure.Helpers;
    using System.ComponentModel.DataAnnotations;

    public class LoginUserModel
    {
        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        public string UserName { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        public string Password { get; set; }
    }
}
