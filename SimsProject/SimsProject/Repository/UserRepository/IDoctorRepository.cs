using Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.UserRepository
{
    public interface IDoctorRepository : GenericRepository.IGenericRepository<Doctor>
    {
        List<Doctor> GetDoctorsByDate(DateTime startDate, DateTime endDate);
        List<Doctor> GetDoctorBySpecility(Specialty speciality);
        Doctor GetDoctor(String username);
    }
}
