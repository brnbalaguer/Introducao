﻿using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Bruno",
                Tipo = "Admin"
            };


            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }
    }
}