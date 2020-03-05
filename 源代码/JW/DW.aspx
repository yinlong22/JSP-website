<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DW.aspx.cs" Inherits="JW_DW" %>

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
		[<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        ]</td>
	</tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 单位名称：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt单位名称" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 单位性质：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt单位性质" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 单位规模：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt单位规模" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 所属行业：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt所属行业" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
        <tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 联系电话：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt联系电话" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 负责人：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt负责人" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 单位介绍：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt单位介绍" runat="server" Width="200px" Height="69px" 
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
