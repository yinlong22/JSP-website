using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;



/// <summary>
/// 密码修改
/// </summary>
public partial class ADMIN_PWDEdit:PageBase
{
 
		protected void Page_Load(object sender, EventArgs e)
    {
        


    }

    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
          if (this.txt密码.Text.Trim() != this.txt确认密码.Text.Trim())
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('密码不一致！');</script>");
            return;
        }
          DataControl.Execute("UPDATE 人员 set 密码='" + txt密码.Text + "' WHERE  帐号='" + Session["UserID"].ToString() + "'");
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href=window.location.href;</script>");




    }

}
