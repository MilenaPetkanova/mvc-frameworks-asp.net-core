namespace Eventure.ViewModels.Users
{
    using Eventure.Helpers;
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [MinLength(3, ErrorMessage = Constants.USERNAME_RESTRICTION_LENGHT)]
        [RegularExpression(@"^[-_.*~a-zA-Z]+$", ErrorMessage = Constants.USERNAME_RESTRICTION_SYMBOLS)]
        public string UserName { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [EmailAddress(ErrorMessage = Constants.EMAIL_RESTRICTION_VALID)]
        public string Email { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [MinLength(5, ErrorMessage = Constants.PASSWORD_RESTRICTION_LENGHT)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = Constants.CONFIRM_PASSWORD_RESTRICTION)]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [RegularExpression(@"^[\d]{10}$", ErrorMessage = Constants.UCN_RESTRICTION_LENGHT)]
        public string UCN { get; set; }

    }
}
