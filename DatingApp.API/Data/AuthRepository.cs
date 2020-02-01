

namespace DatingApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
            
        }
        public Task<User> Login(string username,string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user,string password)
        {
            byte[] passwordHash,passwordSalt;
            CreatePasswordHash(password,out passwordHash,out passwordSalt);
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }


    }
}