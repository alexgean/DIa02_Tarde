using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIa02_Tarde.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ArteAbstrata()
        {
            var Arq = Server.MapPath("~/Imagens/Imagem.jpg");
            return base.File(Arq, "Image/jpg");
        
        }

        public ActionResult Apostila()
        {
            var Arq = Server.MapPath("~/Imagens/PdfUser.pdf");
            return base.File(Arq, "application/pdf");

        }
        [HttpGet]
        public ActionResult ValidaAluno(int Id)
        {
            if (Id == 1)
                return Redirect("/Home/Aluno/1");
            else
                return Redirect("/Home/Erro");

        }

        public ActionResult Erro()
        {
            return View();
        }


        [HttpGet]
    public string Aluno(int Id)
        {
            return "Bem vindo " + Convert.ToString(Id);

        }

        public ActionResult Relatorio()
        {
            ViewBag.Cod = "1";
            ViewBag.Nome = "Rua. Algum Trem";
            
            ViewData["Endereco"] = "Rua. Algum Trem";
            ViewData["CEP"] = "05676-090";

            return View();
        }


        public ActionResult Empresa()
        {
            ViewBag.Empresa = "Impacta Tecnologia";
            ViewData["endereco"] = "Avenida Paulista, 1009";
            return View();
        }
        public string MostrarTexto()
        {
            return "<h1>Primeiro exemplo de action</h1>";
        }

    }



}