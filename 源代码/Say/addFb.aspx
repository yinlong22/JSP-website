<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addFb.aspx.cs" Inherits="YGLT_addFb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML>
	<HEAD>
		<LINK href="../Css/style.css" type="text/css" rel="stylesheet">
		<base target="_self">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			
				<TABLE id="Table1" style="BORDER-RIGHT: #7f7f7f 2px dotted; BORDER-TOP: #7f7f7f 2px dotted; Z-INDEX: 101; LEFT: 8px; BORDER-LEFT: #7f7f7f 2px dotted; WIDTH: 728px; BORDER-BOTTOM: #7f7f7f 2px dotted; POSITION: absolute; TOP: 8px"
					cellSpacing="3" cellPadding="8" width="728" align="center">
					<TBODY>
						<TR>
							<TD class="smallText" id="TErr" align="left" colSpan="2" runat="server" 
                                style="HEIGHT: 17px"></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="2" style="HEIGHT: 2px"><FONT style="FONT-SIZE: medium" face="宋体" color="dimgray">
                                留言主题</TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="HEIGHT: 25px">
                                帐号：</TD>
							<TD class="smallText" style="HEIGHT: 25px" id="TUserName" runat="server"></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="HEIGHT: 25px">
                                角色：</TD>
							<TD class="smallText" style="HEIGHT: 25px" runat="server">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </TD>
						</TR>
						<TR>
							<TD class="smallText" style="HEIGHT: 25px" align="center">主题标题：</TD>
							<TD class="smallText" style="HEIGHT: 25px">
								<asp:TextBox id="TextBox1" runat="server" Width="600px"></asp:TextBox></TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" style="HEIGHT: 66px">
								主题内容：</TD>
							<TD class="smallText" style="HEIGHT: 66px"><asp:textbox id="Textbox3" runat="server" Width="598px" DESIGNTIMEDRAGDROP="98" Height="72px"
									TextMode="MultiLine"></asp:textbox></TD>
						</TR>
						<TR>
							<TD class="smallText" style="HEIGHT: 1px" align="center">
                                发布时间：</TD>
							<TD class="smallText" style="HEIGHT: 1px" vAlign="middle" id="Tdate" 
                                runat="server">
								
							</TD>
						</TR>
						<TR>
							<TD class="smallText" align="center" colSpan="2">
                                <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="LinkButton2_Click"
                                    Text="发布" />&nbsp;
            <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="LinkButton1_Click"
                Text="返回" /></form>
	</body>
</HTML>
