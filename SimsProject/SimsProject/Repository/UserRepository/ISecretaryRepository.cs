using Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface ISecretaryRepository : GenericRepository.IGenericRepository<Secretary>
    {
        Secretary GetSecretary(String username);
    }
}
