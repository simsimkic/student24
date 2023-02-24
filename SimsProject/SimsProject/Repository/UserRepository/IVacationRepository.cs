using Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface IVacationRepository : GenericRepository.IGenericRepository<Vacation>
    {
        List<Vacation> GetVacationOnHold(Boolean onHold);
        List<Vacation> GetApprovedVacation(Boolean approved);
    }
}
