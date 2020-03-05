<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XNPX.aspx.cs" Inherits="JW_XNPX" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

	
		<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="../css/CSS2.css" rel="Stylesheet" />
     <script type="text/javascript" src="../css/setday.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <!--******************************增加页面代码********************************-->

<table cellSpacing="0" cellPadding="0" border="0" class="table">
	<tr>
	<td height="25" align="center" class="tdHeader" colspan="2">
		[校内培训管理]</td>
	</tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 安排日期：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt安排日期" runat="server" Width="200px" onclick="setday(this);"></asp:TextBox>
             
        </td></tr>
        <tr>
	<td height="25" align="center" class="tdHeader" colspan="2">
		[实习生]</td>
	</tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 学号：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt学号" runat="server" Width="200px" AutoPostBack="True" 
                                    ontextchanged="txt学号_TextChanged"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            姓名：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt姓名" runat="server" Width="200px" BorderStyle="None" 
                                    ReadOnly="True"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            性别：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt性别" runat="server" Width="200px" BorderStyle="None" 
                                    ReadOnly="True"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            所在班级：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt所在班级" runat="server" Width="200px" BorderStyle="None" 
                                    ReadOnly="True"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            个人技能：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt个人技能" runat="server" Width="200px" Height="62px" 
                                    TextMode="MultiLine"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            培训单位：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:DropDownList ID="DropDownList1" runat="server"   Width="198px">
                                </asp:DropDownList>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            培训岗位：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt实习职位" runat="server" Width="200px"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		            培训描述：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt工作要求" runat="server" Width="200px" Height="87px" 
                                    TextMode="MultiLine"></asp:TextBox>
             
        </td></tr>
				<tr class="TdStyle"><td style=" text-align: center; width: 151px; height: 18px;">		
		 工作时间：</td>
        <td style="width: 235px; text-align: left; height: 18px;">
                                <asp:TextBox id="txt工作时间" runat="server" Width="200px"></asp:TextBox>
             
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