using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTP.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult BoasVindas(string nome, int RA = 0)
        {

            string saida, saida2, saida3;
            if (RA == 0)
            {
                saida = "Ola Professor" + nome;
                saida2 = "(Sem RA)";
            }
            else
            {
                saida = "Olá " + nome; 
                saida2 = "RA = "+ RA;
            }

            saida3 = "Seja bem vindo";
            ViewBag.Inicio = saida;
            ViewBag.Meio = saida2;
            ViewBag.Fim = saida3;


            return View();

        }
    }
}
