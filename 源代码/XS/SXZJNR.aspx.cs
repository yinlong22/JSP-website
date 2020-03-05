using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class XS_SXZJNR : PageBase
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
                tmpda = DataControl.GetData("select * from 实习安排 where  安排编号=" + Request.QueryString["ID"] + "");
                if (tmpda.Rows.Count > 0)
                {
 
                        RadioButtonList1.SelectedValue= tmpda.Rows[0]["完成情况"].ToString(); 
                        this.txt实际工作天数.Text = tmpda.Rows[0]["实际工作天数"].ToString(); 
                        this.txt实习总结.Text = tmpda.Rows[0]["实习总结"].ToString(); 
                }
            }
        }


    }

    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
        string strErr = "";
        if (this.txt实际工作天数.Text == "")
        {
            strErr += "实际工作天数不能为空！\\n";
        }

        if (strErr != "")
        {
            ResponseMessage(this, strErr);
            return;
        }
        //根据标志判断是添加还是修改的操作 保存商品信息
        if (Request.QueryString["ID"] != null)
        {
            DataControl.Execute("UPDATE 实习安排 set 完成情况 = '" +  RadioButtonList1.SelectedValue + "',实际工作天数 = '" +  txt实际工作天数.Text + "',实习总结 = '" +  txt实习总结.Text + "' WHERE  安排编号=" + Request.QueryString["ID"]);
        }

        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='CKSXAPList.aspx';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("CKSXAPList.aspx");
    }
}
