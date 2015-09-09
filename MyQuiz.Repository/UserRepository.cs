using System;
using System.Linq;
using MyQuiz.Model;
using MyQuiz.Logger;

namespace MyQuiz.Repository
{
    public class UserRepository : RepositoryBase<MyQuizDbContext>, IUserRepository
    {
        ILogger _Logger;

        public UserRepository(ILogger logger) : base()
        {
            _Logger = logger;
        }

        public bool RegisterNewUser(string username, string email, string password)
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
                    _Logger.LogException(ex, "RegisterNewUser");
                    return false;
                }
            }
            return true;
        }

        public int LogInUser(string username, string password)
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
                    _Logger.LogException(ex, "LogInUser");
                    return 0;
                }
            }
        }

        public User GetUser(int userId)
        {
            using (var context = DataContext)
            {
                try
                {
                    var user = context.Users.Where(x => x.ID == userId).FirstOrDefault();
                    return user;
                }
                catch (Exception ex)
                {
                    _Logger.LogException(ex, "GetUser");
                    return null;
                }
            }
        }
    }
}
