using Model.Examination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.MedicalRecordRepository
{
    public interface IRefferalToSpecialistRepository : GenericRepository.IGenericRepository<RefferalToSpecialist>
    {
        RefferalToSpecialist GetRefferalToSpecialist(int id);
    }
}
