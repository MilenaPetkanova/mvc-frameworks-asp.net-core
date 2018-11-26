namespace Eventure.Helpers
{
    public static class Constants
    {
        public const string ROLE_USER = "User";
        public const string ROLE_ADMIN = "Admin";

        public const string RESTRICTION_NOTNULL = "This field is required.";

        public const string USERNAME_RESTRICTION_LENGHT = "Should be at least 3 symbols long.";
        public const string USERNAME_RESTRICTION_SYMBOLS = "May only contain alphanumeric characters, dashes, underscores, dots, asterisks and tildes.";
        public const string EMAIL_RESTRICTION_VALID = "Should be a valid email.";
        public const string PASSWORD_RESTRICTION_LENGHT = "Should be at least 5 symbols long.";
        public const string CONFIRM_PASSWORD_RESTRICTION = "Should match the password.";
        public const string UCN_RESTRICTION_LENGHT = "Should consist of exactly 10 numbers.";

        public const string EVENT_NAME_RESTRICTION_LENGHT = "Should be at least 10 symbols long.";
        public const string EVENT_DATE_RESTRICTION_VALID = "Should be a valid date.";
        public const string EVENT_TICKETS_RESTRICTION_POSITIVENUMBER = "Should be a non-zero integer number.";
        public const string EVENT_PRICE_RESTRICTION_DECIMAL = "Should be a decimal number.";
    }
}
