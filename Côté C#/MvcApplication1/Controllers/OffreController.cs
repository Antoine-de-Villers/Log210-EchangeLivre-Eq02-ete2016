using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MvcApplication1.Filters;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    //[Authorize]
    public class OffreController : Controller
    {

        //
        // GET: /Ajouter offre

        [AllowAnonymous]
        public ActionResult AjouterOffre()
        {
            return View();
        }

        //
        // POST: /Ajouter offre

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AjouterOffre(AjouterOffreModel model)
        {
            if (ModelState.IsValid)
            {
                // Tentative d'ajout d'un offre
                try
                {
                    // Insérer un nouvel offre dans la base de données
                    using (OffreContext db = new OffreContext())
                    {

                        // Insérer les atributs dans la table des offres
                        db.OffreLivres.Add(new OffreLivre
                        {
                            Titre = model.Titre,
                            Auteur = model.Auteur,
                            Isbn = model.Isbn,
                            NuméroÉdition = model.NuméroÉdition,
                            ÉtatLivre = model.ÉtatLivre,
                            EstVente = model.EstVente,
                            Prix = model.Prix,
                            Cours = model.Cours
                        });
                        db.SaveChanges();

                    }

                    return RedirectToAction("Index", "Home");
                }
                catch 
                {

                }
            }

            // Si nous sommes arrivés là, quelque chose a échoué, réafficher le formulaire
            return View(model);
        }

        #region Applications auxiliaires
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //public enum ManageMessageId
        //{
        //    ChangePasswordSuccess,
        //    SetPasswordSuccess,
        //    RemoveLoginSuccess,
        //}

        internal class ExternalLoginResult : ActionResult
        {
            public ExternalLoginResult(string provider, string returnUrl)
            {
                Provider = provider;
                ReturnUrl = returnUrl;
            }

            public string Provider { get; private set; }
            public string ReturnUrl { get; private set; }

            public override void ExecuteResult(ControllerContext context)
            {
                OAuthWebSecurity.RequestAuthentication(Provider, ReturnUrl);
            }
        }

        //private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        //{
        //    // Consultez http://go.microsoft.com/fwlink/?LinkID=177550 pour
        //    // obtenir la liste complète des codes d'état.
        //    switch (createStatus)
        //    {
        //        case MembershipCreateStatus.DuplicateUserName:
        //            return "Le nom d'utilisateur existe déjà. Entrez un nom d'utilisateur différent.";

        //        case MembershipCreateStatus.DuplicateEmail:
        //            return "Un nom d'utilisateur pour cette adresse de messagerie existe déjà. Entrez une adresse de messagerie différente.";

        //        case MembershipCreateStatus.InvalidPassword:
        //            return "Le mot de passe fourni n'est pas valide. Entrez une valeur de mot de passe valide.";

        //        case MembershipCreateStatus.InvalidEmail:
        //            return "L'adresse de messagerie fournie n'est pas valide. Vérifiez la valeur et réessayez.";

        //        case MembershipCreateStatus.InvalidAnswer:
        //            return "La réponse de récupération du mot de passe fournie n'est pas valide. Vérifiez la valeur et réessayez.";

        //        case MembershipCreateStatus.InvalidQuestion:
        //            return "La question de récupération du mot de passe fournie n'est pas valide. Vérifiez la valeur et réessayez.";

        //        case MembershipCreateStatus.InvalidUserName:
        //            return "Le nom d'utilisateur fourni n'est pas valide. Vérifiez la valeur et réessayez.";

        //        case MembershipCreateStatus.ProviderError:
        //            return "Le fournisseur d'authentification a retourné une erreur. Vérifiez votre entrée et réessayez. Si le problème persiste, contactez votre administrateur système.";

        //        case MembershipCreateStatus.UserRejected:
        //            return "La demande de création d'utilisateur a été annulée. Vérifiez votre entrée et réessayez. Si le problème persiste, contactez votre administrateur système.";

        //        default:
        //            return "Une erreur inconnue s'est produite. Vérifiez votre entrée et réessayez. Si le problème persiste, contactez votre administrateur système.";
        //    }
        //}
        #endregion
    }
}
