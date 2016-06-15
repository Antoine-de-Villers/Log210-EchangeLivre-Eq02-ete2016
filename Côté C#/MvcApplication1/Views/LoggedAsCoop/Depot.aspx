<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Models>"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Dépot de livre
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Dépot de livre</h2>
    <% using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) { %>
        <%: Html.AntiForgeryToken() %>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Formulaire d'ajout d'offre</legend>
            <ol>
                <li>
                     <%: Html.LabelFor(m => m.UserName) %>
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Isbn) %>
                    <%: Html.TextBoxFor(m => m.Isbn) %>
                    <%: Html.ValidationMessageFor(m => m.Isbn) %>
                </li>
                <li>
                    <%: Html.LabelFor(m => m.Prix) %>
                    <%: Html.TextBoxFor(m => m.Prix) %>
                    <%: Html.ValidationMessageFor(m => m.Prix) %>
                </li>          
            </ol>
            <input type="submit" value="Depot" />
        </fieldset>
    <% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
