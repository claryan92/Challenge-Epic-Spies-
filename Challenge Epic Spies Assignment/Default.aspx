<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_Epic_Spies_Assignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 242px;
			height: 190px;
		}
	</style>
</head>
<body>
    <p>
		<img alt="" class="auto-style1" src="epic-spies-logo.jpg"  /><br />
	</p>
    <form id="form1" runat="server">
        <div>
        	Spy New Assignment Form</div>
    	<p>
			Spy Code Name:&nbsp;
			<asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
		</p>
		<p>
			New Assignment Name:&nbsp;
			<asp:TextBox ID="newTextBox" runat="server"></asp:TextBox>
		</p>
		<p>
			End Date of Last Assignment</p>
		<p>
			<asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>
		</p>
		<p>
			Start Date of New Assignment</p>
		<p>
			<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
		</p>
		<p>
			Projected End Date of New Assignment</p>
		<p>
			<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
		</p>
		<p>
			<asp:Button ID="okButton" runat="server" Text="Assign Spy" OnClick="okButton_Click" />
		</p>
		<p>
			<asp:Label ID="resultLabel" runat="server"></asp:Label>
		</p>
    </form>
</body>
</html>
