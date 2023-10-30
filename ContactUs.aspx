<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Template_Project.Page5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ContactUs</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery.touchSwipe.min.js"></script>
    <script>
        $(function () {
            $("#form1").swipe(
                {
                    swipe: function (event, direction, distance, duration, fingerCount) {
                        if (direction == "left") {
                            window.location.href = "Fruits.aspx"
                        }
                        else if (direction == "right") {
                            window.location.href = "Cereals.aspx"
                        }
                    },
                    threshold: 100
                });
        });
    </script>
</head>

<body style="background-color:aqua">
    <form id="form1" runat="server" style="height:100vh; width:100vw">
        
        <div class ="row">            
            <div class="col-sm-2 offset-sm-1"  >
                <asp:LinkButton ID="lnkFru" runat="server" OnClick="lnkFru_Click">Fruits</asp:LinkButton>            
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="lnkVeg" runat="server" OnClick="lnkVeg_Click">Vegetables</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="lnkMeat" runat="server" OnClick="lnkMeat_Click">Meat</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="lnkCer" runat="server" OnClick="lnkCer_Click">Cereals</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="lnkCon" runat="server" OnClick="lnkCon_Click">ContactUs</asp:LinkButton>
            </div>
        </div>

        <br/>

         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label1" runat="server" Text="Enter your first Name" ForeColor="Red"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            </div>             
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label2" runat="server" Text="Enter your last Name" ForeColor="Red"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </div>
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label3" runat="server" Text="Enter Email Address" ForeColor="Red"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            </div>
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label4" runat="server" Text="Comment" ForeColor="Red"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
            </div>
         </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                     <asp:Label ID="lblConfirm" runat="server" Text="Confirm" ForeColor="Red"></asp:Label>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="button1_Click" ForeColor="#CC00CC"/>
             </div>
        </div>
    </form>
</body>
</html>
