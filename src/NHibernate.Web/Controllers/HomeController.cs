using AutoMapper;
using NHibernate.Application.Interfaces;
using NHibernate.Application.ViewModel;
using NHibernate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHibernate.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoAppService _alunoAppService;

        public HomeController(IAlunoAppService alunoAppService)
        {
            _alunoAppService = alunoAppService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var alunos = _alunoAppService.Get().OrderBy(x => x.Id).ToList();

            var alunosViewModel = Mapper.Map<List<AlunoViewModel>>(alunos);

            return View(alunosViewModel);
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            var aluno = _alunoAppService.GetById(id);

            var alunoViewModel = Mapper.Map<AlunoViewModel>(aluno);

            return View(alunoViewModel);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                var aluno = Mapper.Map<Aluno>(alunoViewModel);

                _alunoAppService.Insert(aluno);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            var aluno = _alunoAppService.GetById(id);

            var alunoViewModel = Mapper.Map<AlunoViewModel>(aluno);

            return View(alunoViewModel);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                var aluno = Mapper.Map<Aluno>(alunoViewModel);

                _alunoAppService.Update(aluno);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            var aluno = _alunoAppService.GetById(id);

            var alunoViewModel = Mapper.Map<AlunoViewModel>(aluno);

            return View(alunoViewModel);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var aluno = _alunoAppService.GetById(id);

                _alunoAppService.Delete(aluno);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}