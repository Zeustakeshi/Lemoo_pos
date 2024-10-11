using Lemoo_pos.Data;
using Lemoo_pos.Models.Entities;
using Lemoo_pos.Services.Interfaces;

namespace Lemoo_pos.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _db;

        public UserService (ApplicationDbContext db ) {
            _db = db;
        }


        public List<User> GetAllUser()
        {
          return  _db.Users.ToList();
        }
    }
}
