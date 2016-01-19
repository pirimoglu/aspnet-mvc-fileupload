using AspNetMVCFileUpload.Entities;
using AspNetMVCFileUpload.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCFileUpload.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            var context = new MainContext();
            var samples = context.Samples.Select(s => s);
            var model = Mapper.Map<IEnumerable<SampleViewModel>>(samples);
            return View(model);
        }
        
        public ActionResult Create()
        {
            var model = new SampleViewModel();
            model.Image.Width = 100;
            model.Image.Height = 100;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Create(SampleViewModel model)
        {
            var entity = Mapper.Map<Sample>(model);
            var context = new MainContext();
            context.Samples.Add(entity);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult Edit(int id)
        {
            var context = new MainContext();
            var sample = context.Samples.FirstOrDefault(s => s.Id == id);
            var model = Mapper.Map<SampleViewModel>(sample);
            model.Image.Width = 100;
            model.Image.Height = 100;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Edit(int id, SampleViewModel model)
        {
            var context = new MainContext();
            var sample = context.Samples.FirstOrDefault(s => s.Id == id);
            sample = Mapper.Map(model, sample);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
