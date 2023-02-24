using Model.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.BlogRepository
{
    public interface IArticleRepository : GenericRepository.IGenericRepository<Article>
    {
        List<Article> GetArticleByCategory(String category);
        Article GetArticle(int articleId);
    }
}
