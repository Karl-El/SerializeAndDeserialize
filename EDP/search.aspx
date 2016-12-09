<%@ Page Title="" Language="C#" MasterPageFile="~/First.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="EDP.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class=" row">
            <div class="input-group">
                <asp:TextBox ID="txt_Search" runat="server" CssClass=" form-control" />
                <span class="input-group-btn">
                    <asp:LinkButton ID="lnbtn_Search" runat="server" CssClass=" btn btn-outline-info">Search</asp:LinkButton>
                </span>
            </div>
        </div>
    </div>
</asp:Content>
