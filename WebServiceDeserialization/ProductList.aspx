<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WebServiceDeserialization.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="panel panel-danger">
            <%--<div class="panel-heading">
            </div>--%>
            <div class="panel-body">
                <div class="col-sm-2"></div>
                <div class="col-sm-8">
                    <div class="form-inline">
                        <div class="input-group col-sm-12">
                            <asp:TextBox ID="_txtSearch" runat="server" CssClass="form-control" />
                            <span class="input-group-btn">
                                <asp:LinkButton runat="server" ID="_btnSearch" CssClass="btn btn-danger"><span class="glyphicon glyphicon-search"></span> Search</asp:LinkButton>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="col-sm-2">
                    <asp:DropDownList ID="_drpdwnlstRow" runat="server" CssClass="form-control">
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                        <asp:ListItem>100</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <asp:LinkButton ID="_btnClearFilter" runat="server" Text="Clear Filter" CssClass="btn btn-link" OnClick="_btnClearFilter_Click"><i class="fa fa-times"></i>   Clear Filter</asp:LinkButton>
                </div>
                <div class="panel-body">
                    <asp:RadioButtonList ID="_rdbtnlstManufact" runat="server" CssClass=" radio radio-info" AutoPostBack="true" OnSelectedIndexChanged="_rdbtnlstManufact_SelectedIndexChanged"></asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div class="col-sm-8">
            <asp:PlaceHolder ID="_plchldrProdInfo" runat="server"></asp:PlaceHolder>
        </div>
    </div>
    <script type="text/javascript">
        document.onkeydown = function (ev) {
            var key;
            ev = ev || event;
            key = ev.which;
            if (key == 37 || key == 38 || key == 39 || key == 40 || key == 9) {

                ev.cancelBubble = true;
                ev.returnValue = false;
            }
        }
    </script>
</asp:Content>


<%--<div class="col-sm-4"></div>--%>
<%--<asp:Repeater ID="_rptrEDP" runat="server" OnPreRender="_rptrEDP_PreRender">
        <ItemTemplate>
            <div class="row">
                <div class="col-sm-4">
                    <asp:RadioButtonList ID="_rdbtnlstManufact" runat="server"></asp:RadioButtonList>
                </div>
                <div class="col-sm-4">
                    <div class=" panel panel-info">
                        <div class="panel-body">
                            <asp:Image ID="img_Prod" runat="server" CssClass="img-responsive img-thumbnail center-block" AlternateText="Not Available" Width="100" Height="100" /></br>
                            <asp:HyperLink runat="server" CssClass="btn btn-hyperlink" Text='<%# Container.DataItem.ToString()%>' NavigateUrl='<%#string.Concat("~/ProductDetails.aspx?id=",Container.DataItem.ToString()) %>' ID="_hyprlnkEDP"></asp:HyperLink></br>
                            <asp:Label ID="lbl_Store" runat="server" Text="Store:"></asp:Label></br>
                            <asp:Label ID="lbl_Name" runat="server" Text="Name:"></asp:Label></br>
                            <asp:Label ID="lbl_Description" runat="server" Text="Description:"></asp:Label></br>
                            <asp:Label ID="lbl_Price" runat="server" Text="Price:"></asp:Label></br>
                            <asp:Label ID="lbl_Manufacturer" runat="server" Text="Manufacturer:"></asp:Label></br>
                            <asp:Label ID="lbl_Availability" runat="server" Text="Availability:"></asp:Label></br>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4"></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>--%>