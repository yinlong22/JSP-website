using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class XS_SXZJ : PageBase
{
 
		
		protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        if (!Page.IsPostBack)
        {
            //绑定类别列表

            if (Request.QueryString["ID"] != null)
            {
                //显示当前的商品信息
                DataTable tmpda = new DataTable();
                tmpda = DataControl.GetData("select * from 实习周记 where  周记编号=" + Request.QueryString["ID"] + "");
                if (tmpda.Rows.Count > 0)
                {
                        this.txt周次.Text = tmpda.Rows[0]["周次"].ToString(); 
                        this.txt周记主题.Text = tmpda.Rows[0]["周记主题"].ToString(); 
                        this.txt周记内容.Text = tmpda.Rows[0]["周记内容"].ToString(); 

                }
            }
        }


    }

    

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("SXZJList.aspx");
    }
}
