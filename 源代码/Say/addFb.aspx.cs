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

public partial class YGLT_addFb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        if (!Page.IsPostBack)
        {
            //将相关内容显示在控件中
            this.TUserName.InnerHtml =  Session["UserID"].ToString();
            this.Label1.Text = Session["Type"].ToString();
            this.Tdate.InnerHtml = DateTime.Now.Date.ToShortDateString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //跳转页面
        Response.Redirect("YgltList.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //判断信息是否正确
        if (TextBox1.Text == "" || Textbox3.Text == "")
        {
            TErr.InnerHtml = "<font>主题或内容不能为空";
            return;
        }
        //添加新的主题信息
        DataControl.Execute("insert into 答疑(主题标题,主题内容,名称,留言时间,类型) values('" + this.TextBox1.Text + "','" + this.Textbox3.Text + "','" + this.TUserName.InnerHtml + "','" + DateTime.Now.Date.ToShortDateString() + "','" + Session["Type"].ToString()+ "')");
        Response.Redirect("YgltList.aspx");
    }
}
