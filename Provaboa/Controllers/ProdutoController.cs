using Provaboa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Provaboa.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest)
            }
            ProdutoModel produtoModel = db.Produtos.Find(id);
            if (produtoModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProdutoModel produtoModel = db.Produtos.Find(id)
            db.Produtos.Remove(produtoModel)
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}