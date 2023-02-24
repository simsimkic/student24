using Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.BlogRepository
{
    public interface ISurveyRepository : GenericRepository.IGenericRepository<Survey>
    {
        Survey GetSurvey(int id);
    }
}
