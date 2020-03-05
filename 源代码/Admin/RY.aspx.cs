using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_RY :PageBase
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
                tmpda = DataControl.GetData("select * from 人员 where  帐号='" + Request.QueryString["ID"] + "'");
                if (tmpda.Rows.Count > 0)
                {
						this.txt帐号.Text = tmpda.Rows[0]["帐号"].ToString(); 
                        this.txt姓名.Text = tmpda.Rows[0]["姓名"].ToString(); 
                        this.RadioButtonList1.SelectedValue= tmpda.Rows[0]["性别"].ToString(); 
                        this.txt年龄.Text = tmpda.Rows[0]["年龄"].ToString(); 
                        this.txt介绍.Text = tmpda.Rows[0]["介绍"].ToString(); 
                        this.RadioButtonList2.SelectedValue = tmpda.Rows[0]["级别"].ToString(); 
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
        if (this.txt帐号.Text == "")
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
            DataControl.Execute("UPDATE 人员 set 帐号 = '" +  txt帐号.Text + "',姓名 = '" +  txt姓名.Text + "',性别 = '" +  RadioButtonList1.SelectedValue + "',年龄 = '" +  txt年龄.Text + "',介绍 = '" +  txt介绍.Text + "',级别 = '" +  RadioButtonList2.SelectedValue + "' WHERE  帐号='" + Request.QueryString["ID"]+"'");
        }
        else
        {
            DataControl.Execute("insert into 人员 (帐号,姓名,性别,年龄,介绍,密码,级别) values ( '" +  txt帐号.Text + "', '" +  txt姓名.Text + "', '" +  RadioButtonList1.SelectedValue + "', '" +  txt年龄.Text + "', '" +  txt介绍.Text + "', '000000', '" +  RadioButtonList2.SelectedValue + "')");

        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='RYList.aspx';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("RYList.aspx");
    }
}
