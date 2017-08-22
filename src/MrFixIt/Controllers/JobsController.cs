using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MrFixIt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MrFixIt.Controllers
{
    public class JobsController : Controller
    {
        private MrFixItContext db = new MrFixItContext();

        public IActionResult Index()
        {
            return View(db.Jobs.Include(j => j.Worker).ToList());
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Job job)
        {
            db.Jobs.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Claim(int id)
        {
            Job thisJob = db.Jobs.FirstOrDefault(jobs => jobs.JobId == id);
            return View(thisJob);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Claim(Job job)
        { //this process is accessible/visible even when user isn't logged in; FIXED
            job.Worker = db.Workers.FirstOrDefault(w => w.UserName == User.Identity.Name);
            db.Entry(job).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpPost]
        public IActionResult MarkActive(int jobId)
        {
            Job thisJob = db.Jobs.FirstOrDefault(jobs => jobs.JobId == jobId);
            thisJob.Pending = true;
            db.Entry(thisJob).State = EntityState.Modified;
            db.SaveChanges();
            return Json(thisJob);
        }

        [Authorize]
        [HttpPost]
        public IActionResult MarkComplete(int jobId)
        {
            Job thisJob = db.Jobs.FirstOrDefault(jobs => jobs.JobId == jobId);
            thisJob.Completed = true;
            //thisJob.Pending = false;
            db.Entry(thisJob).State = EntityState.Modified;
            db.SaveChanges();
            return Json(thisJob);
        }
    }
}
