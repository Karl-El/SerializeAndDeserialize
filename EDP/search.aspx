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
            <div class="col-sm-3">
                <div class="card card-outline-secondary">
                    <div class="card-block" style="text-align: center">
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
                        <asp:RadioButtonList ID="rdbtnlst_Brand" runat="server" CssClass=" radio radio-info" AutoPostBack="True" Font-Size="Small">
                        </asp:RadioButtonList>
                    </div>
                </div>
            </div>
            <div class="col-sm-9">
                <div class="card card-outline-secondary">
                    <div class="card-block">
                        <div class=" row">
                            <div class="col-sm-3" style="text-align: center">
                                <br />
                                <asp:Image ID="img_Prod" runat="server" AlternateText="No Image" Height="100" Width="100" ImageUrl="~/images/box.gif" CssClass="img-thumbnail" /><br />
                                <br />
                                <br />
                                <asp:CheckBox ID="chkbx_Compare" runat="server" Text="Compare" CssClass=" checkbox checkbox-success" />
                            </div>
                            <div class="col-sm-6">
                                <h6>
                                    <asp:Label ID="lbl_ProdName" runat="server" Text="Label">Microsoft Surface Book - Tablet - with detachable keyboard - Core i7 6600U / 2.6 GHz - Win 10 Pro 64-bit - 16 GB RAM - 512 GB SSD - 13.5" touchscreen 3000 x 2000 - GF 940M</asp:Label>
                                </h6>
                                <asp:Label ID="lbl_ProdDesc" runat="server" Text="Label" Font-Size="Small">Microsoft Surface Book - Tablet - with detachable keyboard - Core i7 6600U / 2.6 GHz - Win 10 Pro 64-bit - 16 GB RAM - 512 GB SSD - 13.5" touchscreen 3000 x 2000 - GF 940M</asp:Label>
                            </div>
                            <div class="col-sm-3"><br /><br />
                                <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True">$2,699.00</asp:Label>
                                <br /><br />
                                <asp:DropDownList ID="drpdwnlst_Quantity" runat="server" CssClass="form-control" Width="75">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList><br />
                                <asp:LinkButton ID="lnkbtn_AddToCart" runat="server" CssClass="btn btn-outline-primary" Font-Size="Small"><i class="fa fa-shopping-cart"></i>  Add to Cart</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card card-outline-secondary">
                    <div class="card-block">
                        <asp:PlaceHolder ID="plchldr_Prod" runat="server"></asp:PlaceHolder>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
