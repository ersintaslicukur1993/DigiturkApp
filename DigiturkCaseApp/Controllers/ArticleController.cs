using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiturkCaseApp.Data;
using DigiturkCaseApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigiturkCaseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleReposItory _articleReposItory;

        public ArticleController(IArticleReposItory articleReposItory)
        {
            _articleReposItory = articleReposItory;
        }

        public ActionResult GetArticles()
        {
            var articles = _articleReposItory.GetArticles();

            return Ok(articles);
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult Add([FromBody]Article article)
        {
            if (article == null)
            {
                return BadRequest("Geçersiz model");
            }
            if (article.ArticleID>0)
            {
                article.ArticleID = 0;
            }
            article.CreateDate = DateTime.Now;
            article.UpdateDate = new DateTime(2000, 1, 1);
            _articleReposItory.Add(article);
            _articleReposItory.SaveAll();
            return Ok(article);
        }

        [HttpGet]
        [Route("detail")]
        public ActionResult GetArticleById(int Id)
        {
            var article = _articleReposItory.GetArticleById(Id);

            return Ok(article);
        }
        [HttpGet]
        [Route("search")]
        public ActionResult GetArticleBySearch(string name)
        {
            var articles = _articleReposItory.GetArticleByName(name);

            return Ok(articles);
        }

        [HttpPost]
        [Route("Update")]
        public ActionResult Update([FromBody]Article article)
        {
            if (article == null)
            {
                return BadRequest("Geçersiz model.");
            }
            if (article.ArticleID==0)
            {
                return BadRequest("Geçersiz article id.");
            }

            article.UpdateDate = DateTime.Now;
            _articleReposItory.Update(article);

            _articleReposItory.SaveAll();
            return Ok(article);
        }
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var article = _articleReposItory.GetArticleById(id);
            if (article != null)
            {
                _articleReposItory.Delete(article);
            }
            return Ok($"{id} nolu kayıt silindi.");
        }
    }
}
