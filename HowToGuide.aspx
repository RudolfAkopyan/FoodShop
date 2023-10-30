<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HowToGuide.aspx.cs" Inherits="Template_Project.UnusedPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to Guide</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery.touchSwipe.min.js"></script>
    <script>
        $(function () {
            $('#form1').swipe(
                {
                    tap: function () { },
                    doubleTap: function () {
                        window.location.href = "Cereals.aspx"
                    }
                }

            );
        });
    </script>
</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server" style="height:100vh; width:100vw">
        <div class="jumbotron">
            <h1>How to Use the App</h1>
        </div>
        <h3 style="color:red#">Navigation</h3>
        
        <p>To navigate pages you can swipe left and right or click on link on the top of the page</p>

        <hr />
        <h3 style ="color:red">How to add and reset total calories number</h3>
        <p>To add calories you need to click on "add" buttom as muny times as you need and you will see total amount of calories on total label and then click on "reset calories" buttom</p>
        <hr />
        <h3 style="color:red">Contact Us</h3>
        <p>If you want to contact us you can swipe left or click on Contact us buttom and you will be able to get in touch with us</p>
        <p>Also you can send us letter on 30343322@cityoglacol.ac.uk</p>
        <p>Or you can visit our office at address: 190 Cathedral St, Glasgow (postCod:G4 0RF) </p>
        <h2 style="color:blue; font-weight:bold">Double tap to Continiue</h2>
        
    </form>
</body>
</html>
