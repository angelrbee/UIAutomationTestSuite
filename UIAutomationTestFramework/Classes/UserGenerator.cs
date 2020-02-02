namespace UIAutomationTestFramework.Classes
{
    public class UserGenerator
    {


        public static User LastGeneratedUser;

        public static void Initialize()
        {
            LastGeneratedUser = null;
        }

        public static User Generate()
        {
            var user = new User
            {
                FirstName = "Juan",
                LastName = "Peter",
                EmailAddress = EmailAddressGenerator.RandomEmail(),
                Password = PasswordGenerator.RandomPassword(10),
                Day = "15",
                Month = "Jan",
                Year = "1980"
            };

            LastGeneratedUser = user;
            return user;
        }


    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
    }
}
