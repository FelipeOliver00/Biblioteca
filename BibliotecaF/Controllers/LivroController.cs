using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaF.Models;
using Microsoft.AspNetCore.Mvc;


namespace BibliotecaF.Controllers
{
    public class LivroController : Controller
    {

        //Simulando banco de dados da Biblioteca _bancob
        private static List<Livro> _bancob = new List<Livro>();
        
        //Listando Livros
        public IActionResult Index()
        {
            //Enviar a lista de livros
            return View(_bancob);

        }


    
        //Removendo Livro
        public IActionResult Remover(int id)
        {
            //Removendo
            _bancob.RemoveAt(_bancob.FindIndex(liv => liv.Codigo == id));
            //Mensagem de sucesso
            TempData["msg"] = "Livro Excluído";
            //Redirect
            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult Editar(Livro livro)
        {
            //Validando Usuário do _bancob
            //Editando Livro (usando index do livro e subistituindo o objeto)
            _bancob[ _bancob.FindIndex(liv => liv.Codigo == livro.Codigo)] = livro;
            //Mensagem de sucesso
            TempData["msg"] = "Livro Atualizado!";
            //Redierct para listagem
            return RedirectToAction("Index");
        }

        //Recebendo id do Livro e retorna os valores do livro para view
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Procurando livro com código
            var liv = _bancob.Find(l=> l.Codigo == id);

            //Enviando o livro para view objeto liv
            return View(liv);
        }

        //Cadastrando o Livro e retornando msg success
        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            livro.Codigo = _bancob.Count + 1;
            _bancob.Add(livro);
            TempData["msg"] = "Livro registrado na Biblioteca";
            return RedirectToAction("cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
