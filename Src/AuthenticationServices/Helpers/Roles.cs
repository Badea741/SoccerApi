namespace AuthenticationServices.Helpers
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string User = "User";
        public static List<string> AvailableRoles = new() { Admin, User };
    }
}
