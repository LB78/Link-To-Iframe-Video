<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinkToIframeVideo.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .txt
        {
            border:1px solid #CCCCCC;
            padding:4px;
            width:300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label" runat="server" Text="Inserire l'URL del video YOUTUBE o VIMEO"></asp:Label><br />
    <asp:TextBox ID="Link" CssClass="txt" runat="server" header="https://"></asp:TextBox>&nbsp;<asp:Button ID="ButtonAvvia" OnClick="ButtonAvvia_Click" runat="server" Text="Carica" /><br /><br />
    <iframe width="720" height="405" runat="server" id="Video" frameborder="0" allowfullscreen></iframe>
</asp:Content>
