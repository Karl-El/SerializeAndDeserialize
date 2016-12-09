<%@ Page Title="" Language="C#" MasterPageFile="~/First.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="EDP.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <%--<div class="input-group">
                <asp:TextBox ID="txt_Search" runat="server" CssClass=" form-control" />
                <span class="input-group-btn">
                    <asp:LinkButton ID="lnbtn_Search" runat="server" CssClass=" btn btn-outline-info">Search</asp:LinkButton>
                </span>
            </div>--%>
        <div class=" row">
            <div class="col-sm-4">
                <div class="card card-outline-primary">
                    <%--<div class="card-header">
                        Filter
                    </div>--%>
                    <div class="card-block">
                        <%--<h4 class="card-title">Brand</h4>--%>
                        <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                        <asp:RadioButtonList ID="rdbtnlst_Brand" runat="server" CssClass=" radio radio-info" AutoPostBack="true">
                            <asp:ListItem>Sample One</asp:ListItem>
                            <asp:ListItem>Sample Two</asp:ListItem>
                            <asp:ListItem>Sample Three</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
            </div>
            <div class="col-sm-8"></div>
        </div>
    </div>
</asp:Content>
