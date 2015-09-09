using System;
using System.Linq;
using MyQuiz.Model;

namespace MyQuiz.Repository
{
    public class UserRepository : RepositoryBase<MyQuizDbContext>, IUserRepository
    {
        public UserRepository() : base()
        { }

        public bool SignUpUser(string username, string email, string password)
        {
            using (var context = DataContext)
            {
                try
                {
                    User user = new User()
                    {
                        UserName = username,
                        Email = email,
                        Password = password
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    //log
                    return false;
                }
            }
            return true;
        }

        public int SignInUser(string username, string password)
        {
            using (var context = DataContext)
            {
                try
                {
                    var user = context.Users.Where(x => (x.UserName == username || x.Email == username) && x.Password == password).FirstOrDefault();
                    return user?.ID ?? 0;
                }
                catch (Exception ex)
                {
                    //log
                    return 0;
                }
            }
            return 0;
        }
    }
}
