<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %> 

<HTML>
	<HEAD>
			<LINK href="css/CSS.css"type="text/css" rel="stylesheet">
	         
	        <style type="text/css">
                .style1
                {
                    width: 138px;
                }
                .style2
                {
                    height: 175px;
                }
                .style3
                {
                    width: 242px;
                }
                .style4
                {
                    width: 234px;
                }
            </style>
	         
	</HEAD>
	<body  background="images/back.jpg">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" align="center"    
                style="WIDTH: 696px; HEIGHT: 385px;    background-image : url('Images/backLV.jpg');"  
                border="0">
					<TR>
						<TD colspan="2" class="style2"></TD>
					</TR>
					<TR>
						<TD id="TD1" class="style1">
                        </TD>
						<TD vAlign="top" class="style3" >
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                                
                                style="border: thin outset #FFFFFF; color: #FFFFFF; height: 173px; width: 354px;" 
                                bgcolor="#314A2D">
								<TR height="30px">
									<TD align="center" colspan="2"   >
			                            实习生管理系统</TD>
								</TR>
								<TR>
									<TD align="right"   >
                                        帐号：</TD>
									<TD class="style4"   >
										<asp:textbox id="txtUser" runat="server" BorderStyle="None" Width="140px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD align="right"   >
                                        密码：</TD>
									<TD class="style4"  >
										<asp:textbox id="txtPwd" runat="server" BorderStyle="None" Width="140px" 
                                            TextMode="Password"></asp:textbox></TD>
								</TR>
								<TR>
									<TD align="right"   >
			<FONT face="宋体">
				                        角色：</FONT></TD>
									<TD class="style4"  >
			<FONT face="宋体">
			                            <asp:DropDownList ID="DropDownList1" runat="server" Width="141px" Height="16px">
                                            <asp:ListItem>管理员</asp:ListItem>
                                            <asp:ListItem>教务管理员</asp:ListItem>
                                            <asp:ListItem>教师</asp:ListItem>
                                            <asp:ListItem>实习生</asp:ListItem>
                                        </asp:DropDownList>
			</FONT> 
		                            </TD>
								</TR>
								<TR>
									<TD align="center" colspan="2"   >
			                            &nbsp;</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 38px" align="center" colSpan="2">
                                        <asp:ImageButton ID="IbtDL" runat="server" 
                                            ImageUrl="~/Images/button-login.gif" onclick="IbtDL_Click" 
                                              />
			<FONT face="宋体">
				&nbsp;</FONT></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</FONT> 
		</form>
	</body>
</HTML>
