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
            this.RadioButtonList1.DataTextField="职位";
            this.RadioButtonList1.DataValueField="安排编号";
            this.RadioButtonList1.DataSource=DataControl.GetData("select * from  V_安排 where 学号='"+Session["UserID"].ToString()+"'");
            this.RadioButtonList1.DataBind();
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
                        this.RadioButtonList1.SelectedValue = tmpda.Rows[0]["安排编号"].ToString(); 
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
        if (this.txt周记主题.Text == "")
        {
            strErr += "帐号不能为空！\\n";
        }

        if (strErr != "")
        {
            ResponseMessage(this, strErr);
            return;
        }
        //根据标志判断是添加还是修改的操作 保存商品信息
        if (Request.QueryString["ID"] != null)
        {
            DataControl.Execute("UPDATE 实习周记 set 周记日期 = '" +  DateTime.Now.ToShortDateString() + "',周次 = '" +  txt周次.Text + "',周记主题 = '" +  txt周记主题.Text + "',周记内容 = '" +  txt周记内容.Text + "',安排编号 = " +  RadioButtonList1.SelectedValue + " WHERE  周记编号=" + Request.QueryString["ID"]);
        }
        else
        {
            DataControl.Execute("insert into 实习周记 (周记日期,周次,周记主题,周记内容,安排编号) values ( '" + DateTime.Now.ToShortDateString() + "', '" + txt周次.Text + "', '" + txt周记主题.Text + "', '" + txt周记内容.Text + "', " + RadioButtonList1.SelectedValue + ")");

        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='SXZJList.aspx';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("SXZJList.aspx");
    }
}
