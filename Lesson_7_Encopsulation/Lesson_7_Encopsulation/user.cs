namespace Lesson_7_Encopsulation
{
    internal class user
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }

        private string UserPassword;
        public string Password
        {
            get { return UserPassword; }
            set { UserPassword = value; }
        }


    }
}
