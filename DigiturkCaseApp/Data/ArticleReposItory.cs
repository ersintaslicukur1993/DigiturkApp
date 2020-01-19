using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkCaseApp.Models;

namespace DigiturkCaseApp.Data
{
    public class ArticleReposItory : IArticleReposItory
    {
        private DataContext _context;
        public ArticleReposItory(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public Article GetArticleById(int articleId)
        {
            var article = _context.Article.FirstOrDefault(x => x.ArticleID== articleId);
            return article;
        }

        public List<Article> GetArticleByName(string name)
        {
            var articles = _context.Article.Where(x => x.Name.Contains(name)).ToList();
            return articles;
        }

        public List<Article> GetArticles()
        {
            var articles = _context.Article.ToList();
            return articles;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
