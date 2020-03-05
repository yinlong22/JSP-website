using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SXS :PageBase
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
                tmpda = DataControl.GetData("select * from 实习生 where  学号='" + Request.QueryString["ID"] + "'");
                if (tmpda.Rows.Count > 0)
                {
						this.txt学号.Text = tmpda.Rows[0]["学号"].ToString(); 
                        this.txt姓名.Text = tmpda.Rows[0]["姓名"].ToString(); 
                        this.RadioButtonList1.SelectedValue = tmpda.Rows[0]["性别"].ToString(); 
                        this.txt所在班级.Text = tmpda.Rows[0]["所在班级"].ToString(); 
                        this.txt籍贯.Text = tmpda.Rows[0]["籍贯"].ToString(); 
                        this.txt联系电话.Text = tmpda.Rows[0]["联系电话"].ToString(); 
                        this.txt邮箱.Text = tmpda.Rows[0]["邮箱"].ToString(); 
                        this.txt个人技能.Text = tmpda.Rows[0]["个人技能"].ToString(); 
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
        if (this.txt学号.Text == "")
        {
            strErr += "学号不能为空！\\n";
        }

        if (strErr != "")
        {
            ResponseMessage(this, strErr);
            return;
        }
        //根据标志判断是添加还是修改的操作 保存商品信息
        if (Request.QueryString["ID"] != null)
        {
            DataControl.Execute("UPDATE 实习生 set 学号 = '" +  txt学号.Text + "',姓名 = '" +  txt姓名.Text + "',性别 = '" +  RadioButtonList1.SelectedValue + "',所在班级 = '" +  txt所在班级.Text + "',籍贯 = '" +  txt籍贯.Text + "',联系电话 = '" +  txt联系电话.Text + "',邮箱 = '" +  txt邮箱.Text + "',个人技能 = '" +  txt个人技能.Text + "' WHERE  学号='" + Request.QueryString["ID"]+"'");
        }
        else
        {
            DataControl.Execute("insert into 实习生 (学号,姓名,性别,所在班级,籍贯,联系电话,邮箱,个人技能,密码) values ( '" +  txt学号.Text + "', '" +  txt姓名.Text + "', '" +  RadioButtonList1.SelectedValue + "', '" +  txt所在班级.Text + "', '" +  txt籍贯.Text + "', '" +  txt联系电话.Text + "', '" +  txt邮箱.Text + "', '" +  txt个人技能.Text + "', '000000')");

        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('保存成功！');window.location.href='SXSList.aspx';</script>");




    }

    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("SXSList.aspx");
    }
}
