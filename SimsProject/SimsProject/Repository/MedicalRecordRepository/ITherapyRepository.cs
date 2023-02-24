using Model.Examination;
using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.MedicalRecordRepository
{
    public interface ITherapyRepository : GenericRepository.IGenericRepository<Therapy>
    {
        List<Therapy> GetTherapyByPatient(Patient patient);
        Therapy GetTherapyById(int id);
    }
}
