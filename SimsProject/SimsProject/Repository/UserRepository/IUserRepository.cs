using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace SimsProject.Repository.UserRepository
{
   public interface IUserRepository : GenericRepository.IGenericRepository<User>
   {
        Boolean saveCurrentUser(User user);
        User getUserByUsername(String username);
        User getUserByJmbg(String jmbg);

   }
}
