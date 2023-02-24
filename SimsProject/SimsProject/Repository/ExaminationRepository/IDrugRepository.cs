using Model.Examination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.ExaminationRepository
{
    public interface IDrugRepository : GenericRepository.IGenericRepository<Drug>
    {
        Drug GetById(int id);
        List<Drug> GetDrugsForValidation(String type);
    }
}
