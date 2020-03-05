using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class YGLT_addHf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //将内容显示在相关的控件中
            this.TUserName.InnerHtml = Session["UserID"].ToString();
            this.Label1.Text = Session["Type"].ToString();
            this.Tdate.InnerHtml = DateTime.Now.Date.ToShortDateString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //关闭窗体
        Response.Write("<script>window.close();</script>");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //判断信息是否正确
        if (this.Textbox3.Text.Trim() == "")
        {
            this.TErr.InnerHtml = "<font color='red'>回复信息不能为空";
            return;
        }
        //添加新的回复信息
        DataControl.Execute("insert into 信息回复(主题编号,回复内容,名称,回复时间,类型) values(" + Request.QueryString["ID"] + ",'" + Textbox3.Text + "','" + this.TUserName.InnerHtml + "','" + DateTime.Now.Date.ToShortDateString() + "','"+Session["Type"].ToString()+"')");
        Response.Write("<script>window.opener.location.href='YgltEdit.aspx?ID=" + Request.QueryString["ID"] + "';</script>");
        Response.Write("<script>window.close();</script>");
    }
}
