﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using Servico.Tabelas;
using Modelo.Tabelas;

namespace ExemploAula01.Controllers
{
    public class CategoriasController : Controller
    {

        private CategoriaServico categoriaServico = new CategoriaServico();

        private ActionResult ObterVisaoCategoriaPorId(long? id)
        {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaServico.ObterCategoriaPorId((long)id);
            if (categoria == null) return HttpNotFound();
            return View(categoria);
        }

        private ActionResult GravarCategoria(Categoria categoria) {
            try
            {
                if (ModelState.IsValid)
                {
                    categoriaServico.GravarCategoria(categoria);
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
            catch {
                return View(categoria);
            }
        }
        // GET: Categorias
        public ActionResult Index()
        {
            return View(categoriaServico.ObterCategoriasClassificadasPorNome());
        }
        // GET: Categorias Create
        public ActionResult Create() {
            return View(); 
        }
        // GET: Categorias Edit
        public ActionResult Edit(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            return GravarCategoria(categoria);
        }

        public ActionResult Details(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }

        public ActionResult Delete(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categoria categoria = categoriaServico.EliminarCategoriaPorId(id);
            TempData["Message"] = "Categoria " + categoria.Nome.ToUpper() + " foi removida";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria) {
            return GravarCategoria(categoria);
        }
    }
}