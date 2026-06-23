namespace Lesson_7_Encopsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<user> users = new List<user>();
            user user1 = new user();

            user1.UserId = Guid.NewGuid();
            user1.UserName = "Akbarjon";
            user1.FirstName = "Ismaylov";
            user1.Password = "qwerty123";   
            users.Add(user1);

        }
    }
}
