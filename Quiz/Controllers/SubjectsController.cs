using Microsoft.AspNetCore.Mvc;
using Quiz.Models.Entites;
using Quiz.Models;
using Microsoft.EntityFrameworkCore;

namespace Quiz.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly AppDbContext Context;
        public SubjectsController(AppDbContext context)
        {
            Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var r = await Context.Subjects.ToListAsync();
            return View(r);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Subjects subjects)
        {

            await Context.Subjects.AddAsync(subjects);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var r = await Context.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Subjects subjects)
        {
            Context.Subjects.Update(subjects);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var r = await Context.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            return View(r);
        }
        [HttpPost]

        public async Task<IActionResult> Delete(Subjects subjects, int id)
        {
            var e = await Context.Assigments.FirstOrDefaultAsync(x => x.AssigmentId == id);
            if (e != null)
            {
                Context.Assigments.Remove(e);
                await Context.SaveChangesAsync();
            }
            Context.Subjects.Remove(subjects);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
