<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vegetables.aspx.cs" Inherits="Template_Project.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vegetables</title>
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
                            window.location.href = "Meat.aspx"
                        }
                        else if (direction == "right") {
                            window.location.href = "Fruits.aspx"
                        }
                    },
                    threshold: 100
                });
        });
    </script>
</head>

<body style ="background-color:aquamarine">    
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
        
        <div>
            <asp:GridView ID="grgVegetables" runat="server" Width="100%" AutoGenerateColumns="false" BackColor="#99FF66" ForeColor="#009900">
                <Columns>
                    <asp:BoundField DataField="foodName" HeaderText="foodName" />
                    <asp:BoundField DataField="size" HeaderText="size" />
                    <asp:BoundField DataField="calories" HeaderText="calories" />
                    <asp:BoundField DataField="picture" HeaderText="picture" />
                    <asp:BoundField DataField="btnAddCalories" HeaderText="" />
                </Columns>
            </asp:GridView>
        </div>

        <br />

        <div style="margin-left:auto; margin-right:auto; text-align:center;">
            <asp:Label ID="lblTotal" runat="server" Text="lblTotal"></asp:Label>
        </div>
        <div style="margin-left:auto; margin-right:auto; text-align:center;">
            <asp:Button ID="btnAdd" runat="server" Text="Reset Calories" OnClick="btnAdd_Click" ForeColor="#996633"/>
        </div>

    </form>
</body>
</html>
