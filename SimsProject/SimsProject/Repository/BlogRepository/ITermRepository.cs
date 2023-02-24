using Service.TermService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.BlogRepository
{
    public interface ITermRepository : GenericRepository.IGenericRepository<Period>
    {
        List<Period> SearchTerm(String usernameDoctor, DateTime date);
    }
}
