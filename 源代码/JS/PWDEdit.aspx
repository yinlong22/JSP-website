<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PWDEdit.aspx.cs" Inherits="ADMIN_PWDEdit" %> 
	
		
		
		<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="../css/CSS2.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <!--******************************增加页面代码********************************-->

<table cellSpacing="0" cellPadding="0" border="0" class="table" align="center">
	<tr>
	<td height="25" align="center" class="tdHeader" colspan="2">
		[修改密码]</td>
	</tr>
				
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            密码：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt密码" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
             
        </td></tr>
				
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            确认密码：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt确认密码" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
             
        </td></tr>
				
			<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:ImageButton ID="btnAdd" runat="server" 
            ImageUrl="~/images/button_save.gif" onclick="btnAdd_Click" />
	&nbsp;</div></td></tr>
	</table>

    
    </div>
    </form>
</body>
</html>
