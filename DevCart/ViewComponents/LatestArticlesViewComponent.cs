
using DevCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCart.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
     new Article(1,"آمورش زبان دات نت","بهترین آموزش زبان","blog-post-thumb-card-2.jpg"),
     new Article(2,"آمورش زبان انگلیسی","بهترین آموزش زبان","blog-post-thumb-card-3.jpg"),
     new Article(3,"آمورش گیت","بهترین آموزش زبان","blog-post-thumb-card-4.jpg"),
            };

            return View("_LetestArticles", articles);
        }
    }
}
