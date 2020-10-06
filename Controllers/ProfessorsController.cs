using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prova_Sistema_web_Ex4.Contexto;
using Prova_Sistema_web_Ex4.Models;

namespace Prova_Sistema_web_Ex4.Controllers
{
    public class ProfessorsController : Controller
    {
        private ContextoData db = new ContextoData();
       

        // GET: Professors/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Endereco,Email,Telefone,Disciplina")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                await db.SaveChangesAsync();
            }

            return View(professor);
        }
       
    }
}
