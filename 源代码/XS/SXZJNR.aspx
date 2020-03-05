<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SXZJNR.aspx.cs" Inherits="XS_SXZJNR" %>

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
		[实习总结]</td>
	</tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 完成情况：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>已完成</asp:ListItem>
                                    <asp:ListItem>进行中</asp:ListItem>
                                    <asp:ListItem>未实习</asp:ListItem>
                                </asp:RadioButtonList>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 实际工作天数：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt实际工作天数" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 实习总结：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt实习总结" runat="server" Width="200px" Height="177px" 
                                    TextMode="MultiLine"></asp:TextBox>
             
        </td></tr>
			<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:ImageButton ID="btnAdd" runat="server" 
            ImageUrl="~/images/button_save.gif" onclick="btnAdd_Click" />
	&nbsp;<asp:ImageButton ID="btnCancel" runat="server" 
            ImageUrl="~/images/button_cancel.gif" onclick="btnCancel_Click" />
	</div></td></tr>
	</table>

    
    </div>
    </form>
</body>
</html>