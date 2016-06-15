<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Models.RechercherLivreModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Ajouter une offre
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Ajouter.</h1>
    </hgroup>

    <section id="loginForm">
    <h2>Veuillez entrer le code du livre :</h2>
    <% using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) { %>
        <%: Html.AntiForgeryToken() %>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Formulaire d'ajout d'offre</legend>
            <ol>
                <li>
                    <%: Html.LabelFor(m => m.Isbn) %>
                    <%: Html.TextBoxFor(m => m.Isbn) %>
                    <%: Html.ValidationMessageFor(m => m.Isbn) %>
                </li>
            </ol>
            <input type="submit" value="Rechercher" />
        </fieldset>
    <% } %>
    </section>

</asp:Content>

<asp:Content ID="scriptsContent" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
