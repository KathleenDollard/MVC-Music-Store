using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private MusicStoreDBContext storeDb ;

    public StoreManagerController(MusicStoreDBContext dbContext)
        {
            this.storeDb = dbContext;
        }

        string ShoppingCartId { get; set; }
        //
        // GET: /StoreManager/

        public ViewResult Index()
        {
            var albums = storeDb.Albums.Include(a => a.Genre).Include(a => a.Artist);
            return View(albums.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ViewResult Details(int id)
        {
            Album album = storeDb.Albums.Find(id);
            return View(album);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(storeDb.Genres, "GenreId", "Name");
            ViewBag.ArtistId = new SelectList(storeDb.Artists, "ArtistId", "Name");
            return View();
        } 

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                storeDb.Albums.Add(album);
                storeDb.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.GenreId = new SelectList(storeDb.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(storeDb.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }
        
        //
        // GET: /StoreManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Album album = storeDb.Albums.Find(id);
            ViewBag.GenreId = new SelectList(storeDb.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(storeDb.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                storeDb.Entry(album).State = EntityState.Modified;
                storeDb.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(storeDb.Genres, "GenreId", "Name", album.GenreId);
            ViewBag.ArtistId = new SelectList(storeDb.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }

        //
        // GET: /StoreManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Album album = storeDb.Albums.Find(id);
            return View(album);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Album album = storeDb.Albums.Find(id);
            storeDb.Albums.Remove(album);
            storeDb.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            storeDb.Dispose();
            base.Dispose(disposing);
        }
    }
}