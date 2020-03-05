<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CKSXAPList.aspx.cs" Inherits="XS_CKSXAPList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title></title>
    <link href="../css/CSS.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   <div align="center">
            <table width="99%" border="0" cellspacing="0" cellpadding="0" align="center" id="Table1">
                <tr>
                    <td   valign="top">
                        <table width="100%" border="0" align="center" cellpadding="5" cellspacing="0">
                            <tr>
                                <td >
                                    <table  
                                        cellpadding="5" width="100%" 
                                        border="0" cellspacing="0">
                                        <tr>
                                           <td height="25" width="30%" align="center" class="tdHeader"> [我的实习安排]</td>
	                                   
                                        </tr>
                                       
                                        </table>
                                </td>
                            </tr>
                            <tr>
                            <td>
                            	<asp:GridView ID="gvData" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="4" SkinID="GridViewAuto" 
                                    UseAccessibleHeader="False" Width="100%" 
                                    BackColor="White" BorderColor="#3366CC" onrowcommand="gvData_RowCommand" 
                                    onrowcreated="gvData_RowCreated" onrowdatabound="gvData_RowDataBound">
                                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                    <EmptyDataTemplate>
                                        <div style="text-align:center;vertical-align:middle">
                                            <br />
                                            找不到和您的查询条件相符的信息 
                                        </div>
                                    </EmptyDataTemplate>
                                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                    <RowStyle BackColor="White" ForeColor="#003399" />
                                    
                                    <Columns>
				<asp:BoundField DataField="职位" HeaderText="职位" >
		</asp:BoundField>
				<asp:BoundField DataField="安排日期" HeaderText="安排日期" >
		</asp:BoundField>
				<asp:BoundField DataField="工作要求" HeaderText="工作要求" >
		</asp:BoundField>
				<asp:BoundField DataField="工作时间" HeaderText="工作时间" >
		</asp:BoundField>
		<asp:BoundField DataField="实际工作天数" HeaderText="实际工作天数" >
		</asp:BoundField>
				<asp:BoundField DataField="完成情况" HeaderText="完成情况" >
		</asp:BoundField>
		                                        
                                        <asp:BoundField DataField="实习总结" HeaderText="实习总结" />
		<asp:BoundField DataField="单位对个人评价" HeaderText="单位对个人评价" >
		</asp:BoundField>
				<asp:BoundField DataField="个人对单位评价" HeaderText="个人对单位评价" >
		</asp:BoundField>
		                                        
                                        <asp:TemplateField HeaderText="操作">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btn_Modify" runat="server" BackColor="Transparent" 
                                                    BorderStyle="None" CommandName="Mod" ForeColor="#3a6ea5" Text="实习总结"></asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" 
                                                Wrap="false" />
                                            <HeaderStyle HorizontalAlign="Center" Wrap="false" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="操作" Visible="False">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btn_Delete" runat="server" BackColor="Transparent" 
                                                    BorderStyle="None" CommandName="Del" ForeColor="#3a6ea5" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" 
                                                Wrap="false" />
                                            <HeaderStyle HorizontalAlign="Center" Wrap="false" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerSettings Visible="False" />
                                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                </asp:GridView>
                            
                            </td>
                            </tr>
                            </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
