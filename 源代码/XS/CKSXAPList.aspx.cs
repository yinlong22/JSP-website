using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class XS_CKSXAPList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //组合查询条件 
            DataTable dt = DataControl.GetData("select *   from  V_安排 where  学号 = '" + Session["UserID"].ToString() + "'  ");
            if (dt != null)
            {
                this.gvData.DataKeyNames = new string[] { "安排编号" };
                this.gvData.DataSource = dt;
                this.gvData.DataBind();
                ShowStats(dt.Rows.Count.ToString());
            }
        }
    }

    #region 刷新列表下的统计信息
    private void ShowStats(string strRowNum)
    {

    }

    #endregion

    #region 列表事件

    /// <summary>
    /// 单击行事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int num = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Mod")
        {
            string strUrl = "SXZJNR.aspx?ID=" + gvData.DataKeys[num]["安排编号"].ToString();
            PageBase.OpenWebForm(strUrl);
        }

    }

    /// <summary>
    /// 列表创建事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            LinkButton LinkButton1 = (LinkButton)e.Row.FindControl("btn_Delete");

            LinkButton1.CommandArgument = e.Row.RowIndex.ToString();

            LinkButton LinkButton2 = (LinkButton)e.Row.FindControl("btn_Modify");

            LinkButton2.CommandArgument = e.Row.RowIndex.ToString();

        }
    }
    /// <summary>
    /// 绑定数据事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)//判定当前的行是否属于datarow类型的行
        {
            //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='CFD4E8',this.style.fontWeight='';");
            //当鼠标离开的时候 将背景颜色还原的以前的颜色


            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");

        }
    }

    #endregion
}
