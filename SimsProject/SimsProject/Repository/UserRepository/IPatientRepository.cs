using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface IPatientRepository : GenericRepository.IGenericRepository<Patient>
    {
        Patient getPatientByJmbg(String jmbg);
        Patient getPatient(String username);
    }
}
