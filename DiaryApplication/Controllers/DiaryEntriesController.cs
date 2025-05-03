using DiaryApplication.Data;
using DiaryApplication.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApplication.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _db.DiaryEntries.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0 ) 
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.FirstOrDefault(e => e.Id == id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            _db.DiaryEntries.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.FirstOrDefault(e => e.Id == id);
            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            _db.DiaryEntries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
