using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class JW_XNPX :PageBase
{

    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        if (!Page.IsPostBack)
        {
            //绑定类别列表
            DropDownList1.DataTextField = "单位名称";
            DropDownList1.DataValueField = "单位编号";
            DropDownList1.DataSource = DataControl.GetData("select * from 单位 where 单位类别='XN'");
            DropDownList1.DataBind();

            if (Request.QueryString["ID"] != null)
            {
                //显示当前的商品信息
                DataTable tmpda = new DataTable();
                tmpda = DataControl.GetData("select * from 实习安排 where  安排编号=" + Request.QueryString["ID"] + "");
                if (tmpda.Rows.Count > 0)
                {
                    this.txt安排日期.Text = tmpda.Rows[0]["安排日期"].ToString();
                    this.txt学号.Text = tmpda.Rows[0]["学号"].ToString();
                    if (this.txt学号.Text != "")
                    {
                        txt学号_TextChanged(null, null);
                    }
                    DropDownList1.SelectedValue = tmpda.Rows[0]["单位编号"].ToString();
                    this.txt实习职位.Text = tmpda.Rows[0]["实习职位"].ToString();
                    this.txt工作要求.Text = tmpda.Rows[0]["工作要求"].ToString();
                    this.txt工作时间.Text = tmpda.Rows[0]["工作时间"].ToString();
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
        if (this.txt实习职位.Text == "")
        {
            strErr += "实习职位不能为空！\\n";
        }

        if (strErr != "")
        {
            ResponseMessage(this, strErr);
            return;
        }
        //根据标志判断是添加还是修改的操作 保存商品信息
        if (Request.QueryString["ID"] != null)
        {
            DataControl.Execute("UPDATE 实习安排 set 安排日期 = '" + txt安排日期.Text + "',学号 = '" + txt学号.Text + "',单位编号 = " + DropDownList1.SelectedValue + ",实习职位 = '" + txt实习职位.Text + "',工作要求 = '" + txt工作要求.Text + "',工作时间 = '" + txt工作时间.Text + "' WHERE  安排编号=" + Request.QueryString["ID"]);
        }
        else
        {
            DataControl.Execute("insert into 实习安排 (安排日期,学号,单位编号,实习职位,工作要求,工作时间) values (  '" + txt安排日期.Text + "', '" + txt学号.Text + "', " + DropDownList1.SelectedValue + ", '" + txt实习职位.Text + "', '" + txt工作要求.Text + "', '" + txt工作时间.Text + "')");

        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='XNPXList.aspx';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("XNPXList.aspx");
    }
    protected void txt学号_TextChanged(object sender, EventArgs e)
    {
        DataTable dt = DataControl.GetData("select * from 实习生 where 学号='" + txt学号.Text + "'");
        if (dt.Rows.Count > 0)
        {
            txt学号.Text = dt.Rows[0]["学号"] + "";
            txt姓名.Text = dt.Rows[0]["姓名"] + "";
            txt性别.Text = dt.Rows[0]["性别"] + "";
            txt所在班级.Text = dt.Rows[0]["所在班级"] + "";
            txt个人技能.Text = dt.Rows[0]["个人技能"] + "";
        }
        else
        {
            txt学号.Text = "";
            txt姓名.Text = "";
            txt性别.Text = "";
            txt所在班级.Text = "";
            txt个人技能.Text = "";
        }
    }
}
