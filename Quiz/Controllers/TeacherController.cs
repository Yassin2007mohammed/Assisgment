using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;
using Quiz.Models.Entites;

namespace Quiz.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext Context;
        public TeacherController(AppDbContext context)
        {
            Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var r = await Context.Teachers.ToListAsync();
            return View(r);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
           
            await Context.Teachers.AddAsync(teacher);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var r = await Context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Teacher teacher)
        {
             Context.Teachers.Update(teacher);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var r = await Context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            return View(r);
        }
        [HttpPost]

        public async Task<IActionResult> Delete(Teacher teacher, int id )
        {
            var e = await Context.Assigments.FirstOrDefaultAsync(x => x.AssigmentId == id);
            if (e != null)
            {
                Context.Assigments.Remove(e);
                await Context.SaveChangesAsync();
            }
            Context.Teachers.Remove(teacher);
            await Context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
