<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Models.AjouterOffreModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Ajouter une offre
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Ajouter.</h1>
    </hgroup>

    <section id="loginForm">
    <h2>Ajouter une offre de livre.</h2>
    <% using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) { %>
        <%: Html.AntiForgeryToken() %>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Formulaire d'ajout d'offre</legend>
            <ol>
                <li>
                    <%: Html.LabelFor(m => m.Titre) %>
                    <%: Html.TextBoxFor(m => m.Titre) %>
                    <%: Html.ValidationMessageFor(m => m.Titre) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Auteur) %>
                    <%: Html.TextBoxFor(m => m.Auteur) %>
                    <%: Html.ValidationMessageFor(m => m.Auteur) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Isbn) %>
                    <%: Html.TextBoxFor(m => m.Isbn) %>
                    <%: Html.ValidationMessageFor(m => m.Isbn) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.NuméroÉdition) %>
                    <%: Html.TextBoxFor(m => m.NuméroÉdition) %>
                    <%: Html.ValidationMessageFor(m => m.NuméroÉdition) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.ÉtatLivre) %>
                    <%: Html.TextBoxFor(m => m.ÉtatLivre) %>
                    <%: Html.ValidationMessageFor(m => m.ÉtatLivre) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Prix) %>
                    <%: Html.TextBoxFor(m => m.Prix) %>
                    <%: Html.ValidationMessageFor(m => m.Prix) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Cours) %>
                    <%: Html.TextBoxFor(m => m.Cours) %>
                    <%: Html.ValidationMessageFor(m => m.Cours) %>
                </li>
                <li>
                    <%: Html.CheckBoxFor(m => m.EstVente) %>
                    <%: Html.LabelFor(m => m.EstVente, new { @class = "checkbox" }) %>
                </li>
            </ol>
            <input type="submit" value="Ajouter" />
        </fieldset>
    <% } %>
    </section>

</asp:Content>

<asp:Content ID="scriptsContent" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
