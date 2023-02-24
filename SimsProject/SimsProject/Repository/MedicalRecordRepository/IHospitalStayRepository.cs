using Model.Employee;
using Model.MedicalRecord;
using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.MedicalRecordRepository
{
    public interface IHospitalStayRepository : GenericRepository.IGenericRepository<HospitalStay>
    {
        List<HospitalStay> GetByPatient(Patient patient);
        List<HospitalStay> GetByDoctor(Doctor doctor);
    }
}
