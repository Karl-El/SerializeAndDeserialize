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
                <div class="card card-outline-secondary">
                    <div class="card-block" style="text-align:center">
                        <asp:LinkButton ID="lnkbtn_ClearFilter" runat="server" CssClass="btn btn-outline-danger"><i class="fa fa-times"></i> Clear Filter</asp:LinkButton>
                    </div>
                </div>
                <div class="card card-outline-secondary">
                    <div class="card-header">
                       View
                    </div>
                    <div class="card-block">
                        <asp:DropDownList ID="drpdwnlst_View" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpdwnlst_View_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>100</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="card card-outline-secondary">
                    <div class="card-header">
                        Brand
                    </div>
                    <div class="card-block">
                        <%--<h4 class="card-title">Brand</h4>--%>
                        <%--<p class="card-text">With supporting text below as a natural lead-in to additional content.</p>--%>
                        <asp:RadioButtonList ID="rdbtnlst_Brand" runat="server" CssClass=" radio radio-info" AutoPostBack="True" >
                        </asp:RadioButtonList>
                    </div>
                </div>
            </div>
            <div class="col-sm-8">
                <div class="card card-outline-secondary">
                    <div class="card-block">
                        <asp:PlaceHolder ID="plchldr_Prod" runat="server"></asp:PlaceHolder>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
