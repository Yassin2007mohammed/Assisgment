using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.Models;
using Quiz.Models.Entites;
using Quiz.Models.Viewmodel;

namespace Quiz.Controllers
{
    public class AssigmentController : Controller
    {
        private readonly AppDbContext appDbContext;
        public AssigmentController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task< IActionResult> Index()
        {
            var r = await appDbContext.Assigments.Include(x =>x.Teacher).Include(c => c.Subjects).ToListAsync();
            return View(r);
        }

        public async Task<IActionResult> Create()
        {
            var teacherList  = await appDbContext.Teachers.ToListAsync();
            var subjectList = await appDbContext.Subjects.ToListAsync();

            var r = new ViewModel()
            {
                Teachers = teacherList,
                Subjects = subjectList,
            };
            return View(r);
               
        }
        [HttpPost]
        public async Task<IActionResult> Create(ViewModel model)
        {
            var r = new Assigment()
            {
                Date = model.Date,
                Tid = model.Tid,
                subid = model.SubId,
            };

            await appDbContext.Assigments.AddAsync(r);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit( int id)
        {
           var e =await appDbContext.Assigments.FirstOrDefaultAsync(x => x.AssigmentId == id);
            var teacherList = await appDbContext.Teachers.ToListAsync();
            var subjectList = await appDbContext.Subjects.ToListAsync();

            var r = new ViewModel()
            {
                Teachers = teacherList,
                Subjects = subjectList,
                SubId = e.subid,
                Tid = e.Tid,
                

            };
            return View(r);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ViewModel model , int id)
        {
            var r = await appDbContext.Assigments.FirstOrDefaultAsync(x => x.AssigmentId==id);
            r.Tid = model.Tid;
            r.subid = model.SubId;
            r.Date = model.Date;

            appDbContext.Assigments.Update(r);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
           await appDbContext.Assigments.Include(x => x.Teacher).Include(c => c.Subjects).ToListAsync();

            var r = await appDbContext.Assigments.FirstOrDefaultAsync(x => x.AssigmentId == id);
            return View(r);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ViewModel model,int id)
        {
            var r = await appDbContext.Assigments.FirstOrDefaultAsync(x => x.AssigmentId == id);
            appDbContext.Assigments.Remove(r);
            await appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
