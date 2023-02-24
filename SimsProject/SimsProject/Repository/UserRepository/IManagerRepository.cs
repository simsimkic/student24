using Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface IManagerRepository : GenericRepository.IGenericRepository<Manager>
    {
        Manager GetMenager(String username);
    }
}
