using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class JW_DW :PageBase
{
	
		
		protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["LB"] == "XW")
            {
                this.Label1.Text = "校外实习公司管理";
            }
            else
            {
                this.Label1.Text = "校内培训单位管理";
            }

            //绑定类别列表

            if (Request.QueryString["ID"] != null)
            {
                //显示当前的商品信息
                DataTable tmpda = new DataTable();
                tmpda = DataControl.GetData("select * from 单位 where  单位编号=" + Request.QueryString["ID"] + "");
                if (tmpda.Rows.Count > 0)
                {
						this.txt单位名称.Text = tmpda.Rows[0]["单位名称"].ToString(); 
                        this.txt单位性质.Text = tmpda.Rows[0]["单位性质"].ToString(); 
                        this.txt单位规模.Text = tmpda.Rows[0]["单位规模"].ToString(); 
                        this.txt所属行业.Text = tmpda.Rows[0]["所属行业"].ToString(); 
                        this.txt单位介绍.Text = tmpda.Rows[0]["单位介绍"].ToString();
                        this.txt联系电话.Text = tmpda.Rows[0]["联系电话"].ToString(); 
                        this.txt负责人.Text = tmpda.Rows[0]["负责人"].ToString(); 
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
        if (this.txt单位名称.Text == "")
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
            DataControl.Execute("UPDATE 单位 set 单位名称 = '" + txt单位名称.Text + "',单位性质 = '" + txt单位性质.Text + "',单位规模 = '" + txt单位规模.Text + "',所属行业 = '" + txt所属行业.Text + "',单位介绍 = '" + txt单位介绍.Text + "',联系电话 = '" + txt联系电话.Text + "',负责人 = '" + txt负责人.Text + "' WHERE  单位编号=" + Request.QueryString["ID"]);
        }
        else
        {
            DataControl.Execute("insert into 单位 (单位名称,单位性质,单位规模,所属行业,单位介绍,联系电话,负责人,单位类别) values ( '" +  txt单位名称.Text + "', '" +  txt单位性质.Text + "', '" +  txt单位规模.Text + "', '" +  txt所属行业.Text + "', '" +  txt单位介绍.Text + "', '" +  txt联系电话.Text + "', '" +  txt负责人.Text + "', '" +  Request.QueryString["LB"] + "')");

        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='DWList.aspx?LB="+Request.QueryString["LB"]+"';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("DWList.aspx?LB="+Request.QueryString["LB"]);
    }
}
