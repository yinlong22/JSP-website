<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SXS.aspx.cs" Inherits="Admin_SXS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


		<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="../css/CSS2.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <!--******************************增加页面代码********************************-->

<table cellSpacing="0" cellPadding="0" border="0" class="table">
	<tr>
	<td height="25" align="center" class="tdHeader" colspan="2">
		[实习生管理]</td>
	</tr>
			<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 学号：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt学号" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 姓名：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt姓名" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 性别：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>男</asp:ListItem>
                                    <asp:ListItem>女</asp:ListItem>
                                </asp:RadioButtonList>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 所在班级：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt所在班级" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 籍贯：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt籍贯" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 联系电话：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt联系电话" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 邮箱：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt邮箱" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 个人技能：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt个人技能" runat="server" Width="200px" Height="85px" 
                                    TextMode="MultiLine"></asp:TextBox>
             
        </td></tr>
			<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:ImageButton ID="btnAdd" runat="server" 
            ImageUrl="~/images/button_save.gif" onclick="btnAdd_Click" />
	&nbsp;<asp:ImageButton ID="btnCancel" runat="server" 
            ImageUrl="~/images/button_cancel.gif" onclick="btnCancel_Click" />
	</div></td></tr>
	<tr>
	<td height="25" colspan="2">注：新实习生密码为000000！</td></tr>
</table>

    
    </div>
    </form>
</body>
</html>