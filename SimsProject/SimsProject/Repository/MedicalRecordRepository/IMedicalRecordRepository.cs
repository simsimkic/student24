using Model.MedicalRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.MedicalRecordRepository
{
    public interface IMedicalRecordRepository : GenericRepository.IGenericRepository<MedicalRecord>
    {
        MedicalRecord GetRecord(String username);
    }
}
