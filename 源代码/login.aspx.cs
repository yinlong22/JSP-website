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

/// <summary>
/// 登录页面
/// </summary>
public partial class login :PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    { 
    }

    /// <summary>
    /// 登录功能
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void IbtDL_Click(object sender, ImageClickEventArgs e)
    {
        DataTable dt = new DataTable();
        switch (this.DropDownList1.SelectedValue)
        {
            case "管理员":
                dt = DataControl.GetData("select * from 管理员 where 帐号='" + txtUser.Text + "' and 密码 ='" + txtPwd.Text + "'");
                if (dt.Rows.Count <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('帐号密码错误！');</script>");
                    return;
                }
                Session["UserID"] = txtUser.Text;
                Response.Redirect("Admin/index.aspx");
                break;
            case "教务管理员":
                dt = DataControl.GetData("select * from 人员 where 帐号='" + txtUser.Text + "' and 密码 ='" + txtPwd.Text + "' and 级别 ='教务管理员' ");
                if (dt.Rows.Count <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('帐号密码错误！');</script>");
                    return;
                }
                Session["UserID"] = txtUser.Text;
                Response.Redirect("JW/index.aspx");
                break;
            case "教师":
                dt = DataControl.GetData("select * from 人员 where 帐号='" + txtUser.Text + "' and 密码 ='" + txtPwd.Text + "' and 级别 ='教师' ");
                if (dt.Rows.Count <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('帐号密码错误！');</script>");
                    return;
                }
                Session["UserID"] = txtUser.Text;
                Response.Redirect("JS/index.aspx");
                break;
            case "实习生":
                dt = DataControl.GetData("select * from 实习生 where 学号='" + txtUser.Text + "' and 密码 ='" + txtPwd.Text + "'  ");
                if (dt.Rows.Count <= 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('学号密码错误！');</script>");
                    return;
                }
                Session["UserID"] = txtUser.Text;
                Response.Redirect("XS/index.aspx");
                break;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void IbtDL0_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Reg/Index.aspx");
    }
}
