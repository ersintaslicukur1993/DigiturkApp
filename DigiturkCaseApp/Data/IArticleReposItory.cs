using DigiturkCaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiturkCaseApp.Data
{
  public  interface IArticleReposItory
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        bool SaveAll();

        List<Article> GetArticles();
        Article GetArticleById(int articleId);
        List<Article> GetArticleByName(string name);
    }
}
