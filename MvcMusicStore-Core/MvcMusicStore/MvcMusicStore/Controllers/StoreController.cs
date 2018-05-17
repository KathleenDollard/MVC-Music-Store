using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreDBContext dbContext ;

        public StoreController(MusicStoreDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
 
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = dbContext.Genres.ToList();

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = dbContext.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = dbContext.Albums.Find(id);

            return View(album);
        }

        //
        // GET: /Store/GenreMenu

       // KAD: [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = dbContext.Genres.ToList();

            return PartialView(genres);
        }

    }
}